Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Public Class ComponentRepository
    Private ReadOnly _connectionString As String

    Public Sub New()
        Me.New(DatabaseSettings.ConnectionString)
    End Sub

    Public Sub New(connectionString As String)
        If String.IsNullOrWhiteSpace(connectionString) Then
            Throw New ArgumentException("Connection string không được để trống.", NameOf(connectionString))
        End If
        _connectionString = connectionString
    End Sub

    Public Function TestConnection() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Return connection.State = ConnectionState.Open
        End Using
    End Function

    Public Function UgpnExists(ugpn As String) As Boolean
        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("dbo.SP_ComponentLocation_CheckUGPN_WH", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ugpn.Trim()
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                Return result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Convert.ToBoolean(result)
            End Using
        End Using
    End Function

    Public Function FindByComponentId(componentId As String) As ComponentItem
        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("dbo.SP_ComponentLocation_GetComponent_WH", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value = componentId.Trim()
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader(CommandBehavior.SingleRow)
                    If Not reader.Read() Then Return Nothing

                    Return New ComponentItem With {
                        .ComponentId = Convert.ToString(reader("ComponentID")).Trim(),
                        .ControlId = Convert.ToInt64(reader("ControlID")),
                        .Ugpn = Convert.ToString(reader("UGPN")).Trim(),
                        .CurrentLocation = Convert.ToString(reader("CurrentLocation")).Trim(),
                        .Quantity = Convert.ToDecimal(reader("OriginQty"))
                    }
                End Using
            End Using
        End Using
    End Function

    Public Function SaveHistoryAndTransfer(items As IEnumerable(Of ComponentItem),
                                           declaredUgpn As String,
                                           newLocation As String,
                                           operatorName As String) As TransferResult
        Dim validItems As List(Of ComponentItem) = items.
            Where(Function(item) item.Status = ComponentCheckStatus.Valid).
            GroupBy(Function(item) item.ComponentId, StringComparer.OrdinalIgnoreCase).
            Select(Function(group) group.First()).
            ToList()

        If validItems.Count = 0 Then
            Throw New InvalidOperationException("Không có Component ID hợp lệ để chuyển Location.")
        End If

        Dim componentTable As New DataTable()
        componentTable.Columns.Add("ComponentID", GetType(String))
        For Each item As ComponentItem In validItems
            componentTable.Rows.Add(item.ComponentId)
        Next

        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("dbo.SP_ComponentLocation_Transfer_WH", connection)
                command.CommandType = CommandType.StoredProcedure
                command.CommandTimeout = 120

                Dim listParameter As SqlParameter = command.Parameters.AddWithValue("@Items", componentTable)
                listParameter.SqlDbType = SqlDbType.Structured
                listParameter.TypeName = "dbo.ComponentLocationTransferItemType"

                command.Parameters.Add("@DeclaredUGPN", SqlDbType.NVarChar, 40).Value = declaredUgpn.Trim()
                command.Parameters.Add("@NewStorageLoc", SqlDbType.NVarChar, 40).Value = newLocation.Trim()
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = operatorName.Trim()

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader(CommandBehavior.SingleRow)
                    If Not reader.Read() Then
                        Throw New DataException("Stored procedure không trả về kết quả giao dịch.")
                    End If

                    Return New TransferResult With {
                        .TransactionId = DirectCast(reader("TransactionID"), Guid),
                        .TransferredCount = Convert.ToInt32(reader("TransferredCount")),
                        .TotalQuantity = Convert.ToDecimal(reader("TotalOriginQty")),
                        .NewLocation = Convert.ToString(reader("NewStorageLoc"))
                    }
                End Using
            End Using
        End Using
    End Function
End Class

Public Class TransferResult
    Public Property TransactionId As Guid
    Public Property TransferredCount As Integer
    Public Property TotalQuantity As Decimal
    Public Property NewLocation As String = String.Empty
End Class
