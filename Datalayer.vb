Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports Oracle.ManagedDataAccess.Client
Imports System.Runtime.InteropServices



Public Class Datalayer


    Public Shared Function GetConnection() As SqlConnection
        ' Dim connectionString As String = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        Try
            Dim connectionString As String = "Data Source=172.16.1.66;Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
            Dim connectionString_26 As String = "Data Source=UGHNSQL1\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
            'Dim connectionString As String = "Data Source=10.0.0.12;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
            '' Dim connectionString As String = "Data Source=192.168.1.41;Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
            'Dim connectionString As String _
            ' = "Data Source=(local);Initial Catalog=UnigenTrax;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
            ' ''    = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
            Return New SqlConnection(connectionString)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.ToString())
            Throw
        End Try

    End Function

    Public Username As String = "None"

    Public Shared Function getDataset(ByVal [select] As String) As DataSet
        Using conn As SqlConnection = New SqlConnection(GetConnection.ConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter([select], conn)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Return ds
        End Using
    End Function

    Public Shared Function DataTable_Sql(ByVal sql As String) As DataTable
        Try

            Using conn As SqlConnection = New SqlConnection(GetConnection.ConnectionString)

                Using dap As SqlDataAdapter = New SqlDataAdapter(sql, conn)

                    Using ds As DataSet = New DataSet()
                        dap.Fill(ds)
                        conn.Close()
                        conn.Dispose()
                        Return ds.Tables(0)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function PopulateForm(ByVal Ten_Thu_tuc As String) As SqlDataReader
        Dim SqlDr As SqlDataReader
        Try
            Dim SqlConn As SqlConnection = New SqlConnection

            SqlConn.ConnectionString = Strconn_66
            SqlConn.Open()
            Dim Sqlcmd As SqlCommand = New SqlCommand("" & Ten_Thu_tuc & "", SqlConn)
            SqlDr = Sqlcmd.ExecuteReader
            'SqlConn.Close()
            'SqlConn.Dispose()

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
        Return SqlDr
        'SqlDr.Close()

    End Function

    Public Shared Function GetConnection1() As SqlConnection
        ' Dim connectionString As String = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        'Dim connectionString As String = "Data Source=172.16.1.66;Initial Catalog=UnigenTrax;User ID=philip;Password=philipp@n2004; " 'providerName = System.Data.SqlClient"
        Dim connectionString_26 As String = "Data Source=UGHNSQL1\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        'Dim connectionString As String = "Data Source=10.0.0.12;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"



        '' Dim connectionString As String = "Data Source=192.168.1.41;Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"

        'Dim connectionString As String _
        ' = "Data Source=(local);Initial Catalog=UnigenTrax;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
        ' ''    = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString_26)
    End Function
    Public Shared Function GetConnection_70() As SqlConnection
        Dim connectionString_us As String = "Data Source=172.16.1.70;Initial Catalog=UHAN_COMMON;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString_us)
    End Function
    Public Shared Function GetConnectionUS() As SqlConnection
        Dim connectionString_us As String = "Data Source=192.168.7.70;Initial Catalog=MSL;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString_us)
    End Function



    Public Shared Function GetOracleConnection() As OracleConnection
        Dim connectionString As String = "User ID=appsr;password=Unigen123;Data Source=192.168.1.21:1541/PROD;Persist Security Info=False"
        Return New OracleConnection(connectionString)
    End Function

    Public Sub InsertPrintJobHistory(
    ByVal CreatedBy As String,
    ByVal ComponentID As String,
    ByVal ControlID As Integer?,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal Mfger As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal StorageLoc As String,
    ByVal QtyBefore As Integer?,
    ByVal QtyAfter As Integer?,
    ByVal QtyInput As Integer?,
    ByVal ParentComponentID As String,
    ByVal Area As String,
    ByVal MSL As String,
    ByVal HF As String,
    ByVal Copies As Integer?,
    ByVal Template As String,
    ByVal IsNewData As Boolean?,
    ByVal Status As String,
    Optional ByVal ErrorMsg As String = Nothing
)
        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s.Trim(), Object))

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("dbo.p_InsertPrintJobHistory", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60
                cn.Open()

                cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar, 50).Value = ToDbNullStr(CreatedBy)
                cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ComponentID)
                cmd.Parameters.Add("@ControlID", SqlDbType.Int).Value = If(ControlID.HasValue, CType(ControlID.Value, Object), DBNull.Value)

                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(MfgPN)
                cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Mfger)

                cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(LotCode)
                cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(DateCode)
                cmd.Parameters.Add("@StorageLoc", SqlDbType.NVarChar, 40).Value = ToDbNullStr(StorageLoc)

                cmd.Parameters.Add("@QtyBefore", SqlDbType.Int).Value = If(QtyBefore.HasValue, CType(QtyBefore.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@QtyAfter", SqlDbType.Int).Value = If(QtyAfter.HasValue, CType(QtyAfter.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@QtyInput", SqlDbType.Int).Value = If(QtyInput.HasValue, CType(QtyInput.Value, Object), DBNull.Value)

                cmd.Parameters.Add("@ParentComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ParentComponentID)

                cmd.Parameters.Add("@Area", SqlDbType.NVarChar, 10).Value = ToDbNullStr(Area)
                cmd.Parameters.Add("@MSL", SqlDbType.NVarChar, 50).Value = ToDbNullStr(MSL)
                cmd.Parameters.Add("@HF", SqlDbType.NVarChar, 10).Value = ToDbNullStr(HF)

                cmd.Parameters.Add("@Copies", SqlDbType.Int).Value = If(Copies.HasValue, CType(Copies.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@Template", SqlDbType.NVarChar, 260).Value = ToDbNullStr(Template)

                cmd.Parameters.Add("@IsNewData", SqlDbType.Bit).Value = If(IsNewData.HasValue, CType(IsNewData.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = ToDbNullStr(Status)
                cmd.Parameters.Add("@ErrorMsg", SqlDbType.NVarChar, 4000).Value = ToDbNullStr(ErrorMsg)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function dsGetFromOracle(ByVal RECEIPT_NUM As String, ByVal SHIPMENT_LINE_ID As String) As DataSet


        Dim myConnection As OracleConnection = GetOracleConnection()
        Dim mySelectQuery As String

        If SHIPMENT_LINE_ID <> "" Then

            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " &
                    "UPPER(NVL(rt.attribute8, pla.attribute11))  mfg_part_number, pla.attribute10 manufacturer, " &
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " &
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " &
                    "pla.item_Description description, " &
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " &
                    "PO_V.VENDOR_NAME, rt.TRANSACTION_DATE,rt.Country_of_ORIGIN_code " &
                   " FROM rcv_transactions rt,  " &
                    "rcv_shipment_headers rsh, " &
                    "po_headers_all pha, " &
                    "po_lines_all pla, " &
                   " mtl_system_items_b msi, " &
                   " PO_VENDORS  PO_V " &
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " &
                   " AND rt.po_header_id = pha.po_header_id " &
                   " AND rt.po_line_id = pla.po_line_id " &
                   " AND pha.po_header_id = pla.po_header_id " &
                   " AND pla.item_id = msi.inventory_item_id  " &
                   " AND rt.organization_id = msi.organization_id " &
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " &
                   " AND rt.transaction_type = 'RECEIVE' " &
                   " AND  msi.ORGANIZATION_ID IN ('142','144') " &
                    "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        ElseIf RECEIPT_NUM <> "" Then

            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " &
                    "UPPER(NVL(rt.attribute8, pla.attribute11)) mfg_part_number, pla.attribute10 manufacturer, " &
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " &
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " &
                    "pla.item_Description description, " &
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " &
                    "PO_V.VENDOR_NAME, rt.TRANSACTION_DATE,rt.Country_of_ORIGIN_code " &
                    "FROM rcv_transactions rt,  " &
                    "rcv_shipment_headers rsh, " &
                    "po_headers_all pha, " &
                    "po_lines_all pla, " &
                   " mtl_system_items_b msi, " &
                   " PO_VENDORS  PO_V " &
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " &
                   " AND rt.po_header_id = pha.po_header_id " &
                   " AND rt.po_line_id = pla.po_line_id " &
                   " AND pha.po_header_id = pla.po_header_id " &
                   " AND pla.item_id = msi.inventory_item_id  " &
                   " AND rt.organization_id = msi.organization_id " &
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " &
                   " AND rt.transaction_type = 'RECEIVE' " &
                   " AND  msi.ORGANIZATION_ID IN ('142','144') " &
                   "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        Else
            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " &
                    "UPPER(NVL(rt.attribute8, pla.attribute11)) mfg_part_number, pla.attribute10 manufacturer, " &
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " &
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " &
                    "pla.item_Description description, " &
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " &
                    "PO_V.VENDOR_NAME, rt.TRANSACTION_DATE,rt.Country_of_ORIGIN_code " &
                   " FROM rcv_transactions rt,  " &
                    "rcv_shipment_headers rsh, " &
                    "po_headers_all pha, " &
                    "po_lines_all pla, " &
                   " mtl_system_items_b msi, " &
                   " PO_VENDORS  PO_V " &
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " &
                   " AND rt.po_header_id = pha.po_header_id " &
                   " AND rt.po_line_id = pla.po_line_id " &
                   " AND pha.po_header_id = pla.po_header_id " &
                   " AND pla.item_id = msi.inventory_item_id  " &
                   " AND rt.organization_id = msi.organization_id " &
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " &
                   " AND rt.transaction_type = 'RECEIVE' " &
                   " AND  msi.ORGANIZATION_ID IN ('142','144') " &
                   "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        End If


        Dim da As New OracleDataAdapter()

        da.SelectCommand = New OracleCommand(mySelectQuery, myConnection)

        Dim ds As New DataSet

        Try
            myConnection.Open()
            da.Fill(ds, "OracleLabel")
            myConnection.Close()
        Catch ex As OracleException
            ' Throw
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Close()
        End Try
        Return ds

    End Function



    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsUser(ByVal UserID As String) As DataSet
        Dim sqlcon As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand("p_selectuser", sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_selectuser"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserID", SqlDbType.NVarChar, 20))
        If UserID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UserID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "UserID")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsReprintLabel(ByVal ComponentID As String) As DataSet

        Dim ds As New DataSet()

        Using con As SqlConnection = GetConnection(),
          cmd As New SqlCommand("p_SelectReprintLabel", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 60
            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(ComponentID),
               CType(DBNull.Value, Object),
               ComponentID.Trim())

            Using da As New SqlDataAdapter(cmd)
                da.Fill(ds, "Compontlabel")
            End Using
        End Using

        Return ds
    End Function
    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Sub InsertPrintHistory_OuterPCB(
    ByVal PrintedBy As String,
    ByVal ControlID As Integer?,
    ByVal ComponentID As String,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal StorageLoc As String,
    ByVal QtyPerPackage As Integer?,
    ByVal Copies As Integer,
    ByVal Area As String,
    ByVal HF As String,
    ByVal TemplateFile As String,
    ByVal SeqPattern As String,
    ByVal Status As String,
    Optional ByVal ErrorMessage As String = Nothing
)
        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s.Trim(), Object))

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("dbo.p_InsertPrintHistory_OuterPCB", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60
                cn.Open()

                cmd.Parameters.Add("@PrintedBy", SqlDbType.NVarChar, 50).Value = ToDbNullStr(PrintedBy)
                cmd.Parameters.Add("@ControlID", SqlDbType.Int).Value = If(ControlID.HasValue, CType(ControlID.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ComponentID)

                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(MfgPN)
                cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(LotCode)
                cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(DateCode)
                cmd.Parameters.Add("@StorageLoc", SqlDbType.NVarChar, 40).Value = ToDbNullStr(StorageLoc)

                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = If(QtyPerPackage.HasValue, CType(QtyPerPackage.Value, Object), DBNull.Value)
                cmd.Parameters.Add("@Copies", SqlDbType.Int).Value = Copies

                cmd.Parameters.Add("@Area", SqlDbType.NVarChar, 10).Value = ToDbNullStr(Area)
                cmd.Parameters.Add("@HF", SqlDbType.NVarChar, 10).Value = ToDbNullStr(HF)

                cmd.Parameters.Add("@TemplateFile", SqlDbType.NVarChar, 260).Value = ToDbNullStr(TemplateFile)
                cmd.Parameters.Add("@SeqPattern", SqlDbType.NVarChar, 30).Value = ToDbNullStr(SeqPattern)

                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = ToDbNullStr(Status)
                cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, 4000).Value = ToDbNullStr(ErrorMessage)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsComponentinfoByComponentID(ByVal ComponentID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID1", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID1"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsComponentinfoByComponentID_Product(ByVal ComponentID As String) As DataSet
        Dim ds As New DataSet()

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_SelectComponentinfoByComponentID_", cn)
                cmd.CommandType = CommandType.StoredProcedure

                Dim p = cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50)
                p.Value = If(String.IsNullOrWhiteSpace(ComponentID), CType(DBNull.Value, Object), ComponentID.Trim())

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(ds, "ComponentInfo")
                End Using
            End Using
        End Using

        Return ds
    End Function
    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsDateCode_FIFO_S(ByVal componentID As String,
                                   ByVal ugpn As String,
                                   ByVal dateFrom As Nullable(Of Date),
                                   ByVal dateTo As Nullable(Of Date)) As DataSet

        Dim ds As New DataSet()

        Using cn As SqlConnection = GetConnection(),
          cmd As New SqlCommand("p_CheckFIFO_DATECODE_S", cn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 60

            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(componentID), CType(DBNull.Value, Object), componentID.Trim())

            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())

            cmd.Parameters.Add("@DateRevcFrom", SqlDbType.Date).Value =
            If(dateFrom.HasValue, CType(dateFrom.Value.Date, Object), DBNull.Value)

            cmd.Parameters.Add("@DateRevcTo", SqlDbType.Date).Value =
            If(dateTo.HasValue, CType(dateTo.Value.Date, Object), DBNull.Value)

            Using da As New SqlDataAdapter(cmd)
                da.Fill(ds, "FIFO")
            End Using
        End Using

        Return ds
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsDateCode_FIFO(ByVal componentID As String, ByVal ugpn As String) As DataSet
        Dim ds As New DataSet()

        Using cn As SqlConnection = GetConnection(),
          cmd As New SqlCommand("p_CheckFIFO_DATECODE", cn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(componentID), CType(DBNull.Value, Object), componentID.Trim())

            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())

            Using da As New SqlDataAdapter(cmd)
                da.Fill(ds, "FIFO")
            End Using
        End Using

        Return ds
    End Function

    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsComponentinfoByComponentID_Reprint(ByVal ComponentID As String) As DataSet 'old
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID_1", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID_1"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    'jerry add new for origin qty

    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsComponentinfoByComponentID_(ByVal ComponentID As String) As DataSet
        Dim ds As New DataSet()

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_SelectComponentinfoByComponentID1_New", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
                If(String.IsNullOrWhiteSpace(ComponentID), CType(DBNull.Value, Object), ComponentID.Trim())

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(ds, "ComponentInfo")
                End Using
            End Using
        End Using

        Return ds
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsCompontByPO(ByVal PO As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByPO", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByPO"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        If PO = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PO
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Compont")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsCompontByPN(ByVal PN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByPN", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByPN"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 50))
        If PN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Compont")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsCompontByID(ByVal CompontID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByID", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByID"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If CompontID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = CompontID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Component")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    '-- jerry add new get Unigen PN-------------
    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsUnigenPN(ByVal UGPN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("Sp_GetUnigenPN", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_GetUnigenPN"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ugpn", SqlDbType.NVarChar, 50))
        If UGPN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "UnigenPN")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    '-- jerry add new get date_exchange -------------
    <DataObjectMethod(DataObjectMethodType.Fill)>
    Public Function GetdsdateTime_Exchange(ByVal UGPN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("Sp_GetDate_Exchage", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_GetDate_Exchage"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ugpn", SqlDbType.NVarChar, 50))
        If UGPN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "DateExchange")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function



    Public Sub UpdateComponentInfo(ByVal QtyPerPackage As Integer,
    ByVal PO As String,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal Mfger As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal FirmWare As String,
    ByVal User As String,
    ByVal Loc As String,
    ByVal ControlID As Integer)


        Dim sqlcon As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand("p_updateComponentinfo", sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateComponentinfo"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))
        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        pmtemp.Value = PO
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@FirmWareVersion", SqlDbType.NVarChar, 30))
        If FirmWare = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = FirmWare
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))
        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))
        If ControlID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input


        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()

        Catch err As SqlClient.SqlException
            Throw
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If

        End Try
    End Sub




    'jerry add new
    Public Function updateComponent_j(ByVal NoOfPackages As Integer,
                                  ByVal PO As String,
                                  ByVal MfgPN As String,
                                  ByVal UGPN As String,
                                  ByVal Mfger As String,
                                  ByVal LotCode As String,
                                  ByVal DateCode As String,
                                  ByVal QtyPerPackage As Integer,
                                  ByVal QtyOrigin As Integer,
                                  ByVal StorageLoc As String,
                                  ByVal User As String,
                                  ByVal ControlID As String) As DataSet

        Dim dsDB As New DataSet()

        Using sqlcon As SqlConnection = GetConnection(),
          cmd As New SqlCommand("p_updateComponent_j", sqlcon)

            cmd.CommandType = CommandType.StoredProcedure

            ' INT
            cmd.Parameters.Add("@NoOfPackages", SqlDbType.Int).Value = NoOfPackages

            ' NVARCHAR(20)
            cmd.Parameters.Add("@PO", SqlDbType.NVarChar, 20).Value =
            If(String.IsNullOrWhiteSpace(PO), CType(DBNull.Value, Object), PO.Trim())

            ' NVARCHAR(50)
            cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(MfgPN), CType(DBNull.Value, Object), MfgPN.Trim())

            ' *** QUAN TRỌNG: NVARCHAR(40) đúng với SP ***
            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(UGPN), CType(DBNull.Value, Object), UGPN.Trim())

            ' *** QUAN TRỌNG: NVARCHAR(50) đúng với SP ***
            cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(Mfger), CType(DBNull.Value, Object), Mfger.Trim())

            ' *** QUAN TRỌNG: NVARCHAR(40) đúng với SP ***
            cmd.Parameters.Add("@StoLocation", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(StorageLoc), CType(DBNull.Value, Object), StorageLoc.Trim())

            ' INT - giữ logic cũ: 0 => DBNull (nếu 0 nghĩa là "không nhập")
            cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value =
            If(QtyPerPackage = 0, CType(DBNull.Value, Object), QtyPerPackage)

            cmd.Parameters.Add("@QtyOrigin", SqlDbType.Int).Value =
            If(QtyOrigin = 0, CType(DBNull.Value, Object), QtyOrigin)

            ' NVARCHAR(40)
            cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(LotCode), CType(DBNull.Value, Object), LotCode.Trim())

            ' NVARCHAR(40)
            cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(DateCode), CType(DBNull.Value, Object), DateCode.Trim())

            ' NVARCHAR(20)
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value =
            If(String.IsNullOrWhiteSpace(User), CType(DBNull.Value, Object), User.Trim())

            ' NVARCHAR(20) - khóa update
            cmd.Parameters.Add("@ControlID", SqlDbType.NVarChar, 20).Value =
            If(String.IsNullOrWhiteSpace(ControlID), CType(DBNull.Value, Object), ControlID.Trim())

            Using daDB As New SqlDataAdapter(cmd)
                daDB.Fill(dsDB, "ProcessStation")
            End Using
        End Using

        Return dsDB
    End Function


    Public Function Update_OriginQty(ByVal QtyPerPackage As Integer,
    ByVal User As String, ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateOriginQty", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateOriginQty"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    'jerry add new 
    Public Function Update_Qty_reduce_new(ByVal QtyPerPackage As Integer,
                                      ByVal QtyOrigin As Integer,
                                      ByVal User As String,
                                      ByVal ControlID As Integer) As DataSet

        Dim dsDB As New DataSet()

        Using sqlcon As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60

                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = QtyPerPackage
                cmd.Parameters.Add("@QtyOrigin", SqlDbType.Int).Value = QtyOrigin
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value =
                If(String.IsNullOrWhiteSpace(User), CType(DBNull.Value, Object), User.Trim())
                cmd.Parameters.Add("@ControlID", SqlDbType.Int).Value = ControlID

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        Return dsDB
    End Function


    'Public Function Update_Qty_reduce_new(ByVal QtyPerPackage As Integer, ByVal QtyOrigin As Integer,
    'ByVal User As String, ByVal ControlID As String) As DataSet


    '    Dim sqlcon As SqlConnection = GetConnection()
    '    ''ResetConnString()
    '    Dim cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
    '    Dim daDB As SqlClient.SqlDataAdapter
    '    Dim dsDB As New DataSet
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = "p_updateQty_reduce"

    '    Dim pmtemp As SqlParameter

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
    '    If User Is Nothing Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = User
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
    '    If ControlID Is Nothing Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = ControlID
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

    '    If QtyPerPackage = 0 Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = QtyPerPackage
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyOrigin", SqlDbType.Int))

    '    If QtyOrigin = 0 Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = QtyOrigin
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    Try
    '        daDB = New SqlClient.SqlDataAdapter(cmd)
    '        daDB.Fill(dsDB, "ProcessStation")
    '        Return dsDB
    '    Catch err As SqlClient.SqlException
    '        Throw
    '    Finally
    '        With cmd.Connection
    '            If .State = ConnectionState.Open Then
    '                .Close()
    '            End If
    '        End With
    '    End Try
    'End Function

    Public Function Update_Qty_reduce_old(ByVal QtyPerPackage As Integer,
                                      ByVal User As String,
                                      ByVal ControlID As Integer) As DataSet

        Dim dsDB As New DataSet()

        Using sqlcon As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60

                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = QtyPerPackage
                cmd.Parameters.Add("@QtyOrigin", SqlDbType.Int).Value = QtyPerPackage ' giữ nguyên pattern nếu anh muốn
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value =
                If(String.IsNullOrWhiteSpace(User), CType(DBNull.Value, Object), User.Trim())
                cmd.Parameters.Add("@ControlID", SqlDbType.Int).Value = ControlID

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        Return dsDB
    End Function



    Public Function Update_infor_componentid(ByVal spName As String,
                                         ByVal Loc As String,
                                         ByVal PN As String,
                                         ByVal MfgPN As String,
                                         ByVal MyTier As String,
                                         ByVal LotCode As String,
                                         ByVal DateCode As String,
                                         ByVal ControlID As Integer,
                                         Optional ByVal UserName As String = Nothing) As DataSet

        Dim ds As New DataSet()

        Using sqlcon As SqlConnection = GetConnection(),
          cmd As New SqlCommand(spName, sqlcon)

            cmd.CommandType = CommandType.StoredProcedure

            AddParam(cmd, "@ControlID", SqlDbType.Int, If(ControlID = 0, CType(DBNull.Value, Object), ControlID))
            AddParam(cmd, "@Loc", SqlDbType.NVarChar, 40, Loc)
            AddParam(cmd, "@PN", SqlDbType.NVarChar, 40, PN)
            AddParam(cmd, "@MfgPN", SqlDbType.NVarChar, 40, MfgPN)
            AddParam(cmd, "@MyTier", SqlDbType.NVarChar, 50, MyTier)
            AddParam(cmd, "@LotCode", SqlDbType.NVarChar, 40, LotCode)
            AddParam(cmd, "@DateCode", SqlDbType.NVarChar, 40, DateCode)
            AddParam(cmd, "@User", SqlDbType.NVarChar, 50, UserName)

            Using da As New SqlDataAdapter(cmd)
                da.Fill(ds, "ProcessStation")
            End Using
        End Using

        Return ds
    End Function

    Private Sub AddParam(ByVal cmd As SqlCommand,
                     ByVal name As String,
                     ByVal dbType As SqlDbType,
                     Optional ByVal size As Integer = 0,
                     Optional ByVal value As Object = Nothing)

        Dim p As SqlParameter
        If size > 0 Then
            p = cmd.Parameters.Add(name, dbType, size)
        Else
            p = cmd.Parameters.Add(name, dbType)
        End If

        If value Is Nothing Then
            p.Value = DBNull.Value
            Return
        End If

        ' Chuẩn hóa string: Nothing/""/whitespace => DBNull
        If TypeOf value Is String Then
            Dim s = DirectCast(value, String)
            If String.IsNullOrWhiteSpace(s) Then
                p.Value = DBNull.Value
            Else
                p.Value = s.Trim()
            End If
        Else
            p.Value = value
        End If
    End Sub

    '  Public Function Update_Qty_reduce_old(ByVal QtyPerPackage As Integer,
    'ByVal User As String, ByVal ControlID As String) As DataSet


    '      Dim sqlcon As SqlConnection = GetConnection()
    '      ''ResetConnString()
    '      Dim cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
    '      Dim daDB As SqlClient.SqlDataAdapter
    '      Dim dsDB As New DataSet
    '      cmd.CommandType = CommandType.StoredProcedure
    '      cmd.CommandText = "p_updateQty_reduce"

    '      Dim pmtemp As SqlParameter

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
    '      If User Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = User
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
    '      If ControlID Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = ControlID
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

    '      If QtyPerPackage = 0 Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = QtyPerPackage
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input



    '      Try
    '          daDB = New SqlClient.SqlDataAdapter(cmd)
    '          daDB.Fill(dsDB, "ProcessStation")
    '          Return dsDB
    '      Catch err As SqlClient.SqlException
    '          Throw
    '      Finally
    '          With cmd.Connection
    '              If .State = ConnectionState.Open Then
    '                  .Close()
    '              End If
    '          End With
    '      End Try
    '  End Function




    '  Public Function Update_infor_componentid_New(ByVal Loc As String, ByVal PN As String, ByVal MfgPN As String, ByVal MyTier As String, ByVal LotCode As String, ByVal DateCode As String,
    ' ByVal ControlID As Integer, ByVal User As String) As DataSet


    '      Dim sqlcon As SqlConnection = GetConnection()
    '      ''ResetConnString()
    '      Dim cmd As New SqlCommand("p_updateLoc_new", sqlcon)
    '      Dim daDB As SqlClient.SqlDataAdapter
    '      Dim dsDB As New DataSet
    '      cmd.CommandType = CommandType.StoredProcedure
    '      cmd.CommandText = "p_updateLoc_new"

    '      Dim pmtemp As SqlParameter
    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))
    '      If ControlID = 0 Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = ControlID
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))

    '      If Loc Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = Loc
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 40))

    '      If PN Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = PN
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))

    '      If MfgPN Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = MfgPN
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@MyTier", SqlDbType.NVarChar, 50))

    '      If MyTier Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = MyTier
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))

    '      If LotCode Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = LotCode
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input
    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))

    '      If DateCode Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = DateCode
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      Try
    '          daDB = New SqlClient.SqlDataAdapter(cmd)
    '          daDB.Fill(dsDB, "ProcessStation")
    '          Return dsDB
    '      Catch err As SqlClient.SqlException
    '          Throw
    '      Finally
    '          With cmd.Connection
    '              If .State = ConnectionState.Open Then
    '                  .Close()
    '              End If
    '          End With
    '      End Try
    '  End Function
    '  Public Function Update_infor_componentid_Old(ByVal Loc As String, ByVal PN As String, ByVal MfgPN As String, ByVal MyTier As String, ByVal LotCode As String, ByVal DateCode As String,
    'ByVal ControlID As Integer, ByVal User As String) As DataSet


    '      Dim sqlcon As SqlConnection = GetConnection()
    '      ''ResetConnString()
    '      Dim cmd As New SqlCommand("p_updateLoc_old", sqlcon)
    '      Dim daDB As SqlClient.SqlDataAdapter
    '      Dim dsDB As New DataSet
    '      cmd.CommandType = CommandType.StoredProcedure
    '      cmd.CommandText = "p_updateLoc_old"

    '      Dim pmtemp As SqlParameter
    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))

    '      If ControlID = 0 Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = ControlID
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))

    '      If Loc Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = Loc
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input


    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 40))

    '      If PN Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = PN
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))

    '      If MfgPN Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = MfgPN
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@MyTier", SqlDbType.NVarChar, 50))

    '      If MyTier Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = MyTier
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))

    '      If LotCode Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = LotCode
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input
    '      pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))

    '      If DateCode Is Nothing Then
    '          pmtemp.Value = System.DBNull.Value
    '      Else
    '          pmtemp.Value = DateCode
    '      End If
    '      pmtemp.Direction = ParameterDirection.Input

    '      Try
    '          daDB = New SqlClient.SqlDataAdapter(cmd)
    '          daDB.Fill(dsDB, "ProcessStation")
    '          Return dsDB
    '      Catch err As SqlClient.SqlException
    '          Throw
    '      Finally
    '          With cmd.Connection
    '              If .State = ConnectionState.Open Then
    '                  .Close()
    '              End If
    '          End With
    '      End Try
    '  End Function


    'jerry add new delete old componentid already convert all
    Public Function Dalete_Componetid_Convert_material(ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_delete_convert_material", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_delete_convert_material"

        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    'jerry add new
    Public Function Update_Qtypackage_Convert_material(ByVal QtyPerPackage As Integer,
    ByVal User As String, ByVal ControlID As String, ByVal OriginQty As Integer) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateQtyPackage", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateQtyPackage"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@OriginQty", SqlDbType.Int))

        If OriginQty = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = OriginQty
        End If

        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    ''jerry addd new
    Public Function InsertComponent_reduce(ByVal ComponentID_reduce As String,
                                       ByVal componentID_Increase As String,
                                       ByVal UGPN As String,
                                       ByVal MfgPN As String,
                                       ByVal Mfger As String,
                                       ByVal Qty_reduce As Integer,
                                       ByVal Qty_Oregin_reduce As Integer,
                                       ByVal UserName As String) As DataSet

        Dim dsDB As New DataSet()

        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s.Trim(), Object))

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_InsertComponetID_reduce", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60

                cmd.Parameters.Add("@ComID_reduce", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ComponentID_reduce)
                cmd.Parameters.Add("@ComID_Increase", SqlDbType.NVarChar, 50).Value = ToDbNullStr(componentID_Increase)
                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(MfgPN)
                cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Mfger)

                cmd.Parameters.Add("@Qty_reduce", SqlDbType.Int).Value =
                If(Qty_reduce = 0, CType(DBNull.Value, Object), Qty_reduce)

                cmd.Parameters.Add("@Qty_Origin_reduce", SqlDbType.Int).Value =
                If(Qty_Oregin_reduce = 0, CType(DBNull.Value, Object), Qty_Oregin_reduce)

                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = ToDbNullStr(UserName)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        Return dsDB
    End Function


    'Public Function InsertComponent_reduce(ByVal ComponentID_reduce As String, ByVal componentID_Increase As String,
    ' ByVal UGPN As String,
    ' ByVal MfgPN As String,
    ' ByVal Mfger As String,
    ' ByVal Qty_reduce As Integer, ByVal Qty_Oregin_reduce As Integer) As DataSet

    '    Dim sqlcon As SqlConnection = GetConnection()
    '    ''ResetConnString()
    '    Dim cmd As New SqlCommand("p_InsertComponetID_reduce", sqlcon)
    '    Dim daDB As SqlClient.SqlDataAdapter
    '    Dim dsDB As New DataSet
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = "p_InsertComponetID_reduce"

    '    Dim pmtemp As SqlParameter

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
    '    pmtemp.Value = UGPN
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
    '    pmtemp.Value = MfgPN
    '    pmtemp.Direction = ParameterDirection.Input


    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
    '    If Mfger Is Nothing Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = Mfger
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@ComID_reduce", SqlDbType.NVarChar, 40))
    '    If ComponentID_reduce Is Nothing Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = ComponentID_reduce
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@ComID_Increase", SqlDbType.NVarChar, 40))
    '    If componentID_Increase Is Nothing Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = componentID_Increase
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@Qty_reduce", SqlDbType.Int))
    '    If Qty_reduce = 0 Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = Qty_reduce
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input

    '    pmtemp = cmd.Parameters.Add(New SqlParameter("@Qty_Origin_reduce", SqlDbType.Int))
    '    If Qty_Oregin_reduce = 0 Then
    '        pmtemp.Value = System.DBNull.Value
    '    Else
    '        pmtemp.Value = Qty_Oregin_reduce
    '    End If
    '    pmtemp.Direction = ParameterDirection.Input


    '    Try
    '        daDB = New SqlClient.SqlDataAdapter(cmd)
    '        daDB.Fill(dsDB, "ProcessStation")
    '        Return dsDB
    '    Catch err As SqlClient.SqlException
    '        Throw
    '    Finally
    '        With cmd.Connection
    '            If .State = ConnectionState.Open Then
    '                .Close()
    '            End If
    '        End With
    '    End Try
    'End Function


    Public Function GetMSLfromCloud(ByVal PN As String) As String
        Dim MSL As String = ""
        Try
            Dim URL As String = "http://192.168.1.51:3001/api/oracleplm/item/" & PN
            Dim fr As System.Net.HttpWebRequest
            Dim targetURI As New Uri(URL)
            Dim Jstring As String = ""

            fr = DirectCast(HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
            If (fr.GetResponse().ContentLength > 0) Then
                Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                Jstring = str.ReadToEnd()
                str.Close()
            End If
            Dim jsonstr As JObject = JObject.Parse(Jstring)

            Try
                MSL = IIf(jsonstr("Attributes")("GeneralDetails")(0)("moistureSensitivityLevelMsl") Is Nothing, "", jsonstr("Attributes")("GeneralDetails")(0)("moistureSensitivityLevelMsl")).ToString

            Catch ex As Exception
                '  Throw

                Try
                    MSL = IIf(jsonstr("Attributes")("ElectricalComponentsMGeneralDe")(0)("moistureSensitivityLevelMsl") Is Nothing, "", jsonstr("Attributes")("ElectricalComponentsMGeneralDe")(0)("moistureSensitivityLevelMsl")).ToString

                Catch ex1 As Exception
                    Throw

                End Try
            End Try

        Catch ex As System.Net.WebException
            Throw
            ''  MessageBox.Show(ex.Message)
        Catch ex As Exception
            Throw
            ''   MessageBox.Show(ex.Message)


        End Try

        Return MSL


    End Function



    Public Function InsertNewComponent(
    ByVal DEV As Integer,
    ByVal NoOfPackages As Integer,
    ByVal QtyPerPackage As Integer,
    ByVal PO As String,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal Mfger As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal FirmWare As String,
    ByVal User As String,
    ByVal Loc As String,
    Optional ByVal ParentComponentID As String = "",
    Optional ByVal COO As String = "",
    Optional ByVal Tier As String = "",
    Optional ByVal Receipt_num As String = "",
    Optional ByVal MSL As String = "",
    Optional ByVal DESC As String = "",
    Optional ByVal Vendor As String = "",
    Optional ByVal Area As String = ""
) As DataSet

        Dim dsDB As New DataSet

        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String)
            If String.IsNullOrWhiteSpace(s) Then Return DBNull.Value
            Return s.Trim()
        End Function

        Using sqlcon As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_InsertNewComponent1", sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                ' ====== INT: truyền đầy đủ, không DBNull (đúng "không bỏ trường nào") ======
                cmd.Parameters.Add("@NoOfPackages", SqlDbType.Int).Value = NoOfPackages
                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = QtyPerPackage
                cmd.Parameters.Add("@DEV", SqlDbType.Int).Value = DEV

                ' ====== NVARCHAR: ĐÚNG LENGTH theo SP ======
                cmd.Parameters.Add("@PO", SqlDbType.NVarChar, 20).Value = ToDbNullStr(PO)
                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)

                ' SP @MfgPN NVARCHAR(50)  -> VB phải 50 (anh đang 40 là sai)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 50).Value = ToDbNullStr(MfgPN)

                cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Mfger)
                cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(LotCode)
                cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(DateCode)

                ' SP FirmWareVersion NVARCHAR(20)
                cmd.Parameters.Add("@FirmWareVersion", SqlDbType.NVarChar, 20).Value = ToDbNullStr(FirmWare)

                ' SP UserName NVARCHAR(20)
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = ToDbNullStr(User)

                cmd.Parameters.Add("@Loc", SqlDbType.NVarChar, 40).Value = ToDbNullStr(Loc)

                cmd.Parameters.Add("@ParentComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ParentComponentID)
                cmd.Parameters.Add("@COO", SqlDbType.NVarChar, 50).Value = ToDbNullStr(COO)
                cmd.Parameters.Add("@TIER", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Tier)

                ' Theo yêu cầu anh: Receipt_num truyền đúng, SP tự override MSL nếu Receipt_num chứa "MSL"
                cmd.Parameters.Add("@Receipt_num", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Receipt_num)
                cmd.Parameters.Add("@MSL", SqlDbType.NVarChar, 50).Value = ToDbNullStr(If(MSL, "").Trim())

                ' SP DESC NVARCHAR(400)  -> VB phải 400 (anh đang 50 là sai)
                cmd.Parameters.Add("@DESC", SqlDbType.NVarChar, 400).Value = ToDbNullStr(DESC)
                cmd.Parameters.Add("@Area", SqlDbType.NVarChar, 20).Value = ToDbNullStr(Area)
                ' SP Vendor NVARCHAR(500)
                cmd.Parameters.Add("@Vendor", SqlDbType.NVarChar, 500).Value = ToDbNullStr(Vendor)

                Using daDB As New SqlDataAdapter(cmd)
                    daDB.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        Return dsDB
    End Function

    Public Function InsertNewComponent2(
    ByVal NoOfPackages As Integer,
    ByVal QtyPerPackage As Integer,
    ByVal PO As String,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal Mfger As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal FirmWare As String,
    ByVal UserName As String,
    ByVal Loc As String,
    Optional ByVal ParentComponentID As String = "",
    Optional ByVal COO As String = "",
    Optional ByVal Tier As String = "",
    Optional ByVal Receipt_num As String = "",
    Optional ByVal MSL As String = "",
    Optional ByVal DESC As String = "",
    Optional ByVal Vendor As String = "",
    Optional ByVal Area As String = ""
) As DataSet

        Dim dsDB As New DataSet()

        ' Helper: Nothing/"" -> DBNull, luôn Trim để tránh space thừa
        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s.Trim(), Object))

        Using cn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_InsertNewComponent2", cn)
                cmd.CommandType = CommandType.StoredProcedure

                ' ====== REQUIRED ======
                cmd.Parameters.Add("@NoOfPackages", SqlDbType.Int).Value = NoOfPackages
                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = QtyPerPackage

                cmd.Parameters.Add("@PO", SqlDbType.NVarChar, 20).Value = ToDbNullStr(PO)
                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(MfgPN)
                cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Mfger)
                cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(LotCode)
                cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(DateCode)

                cmd.Parameters.Add("@FirmWareVersion", SqlDbType.NVarChar, 20).Value = ToDbNullStr(FirmWare)
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = ToDbNullStr(UserName)
                cmd.Parameters.Add("@Loc", SqlDbType.NVarChar, 40).Value = ToDbNullStr(Loc)

                ' ====== OPTIONAL (đúng đúng tên SP) ======
                cmd.Parameters.Add("@ParentComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ParentComponentID)
                cmd.Parameters.Add("@COO", SqlDbType.NVarChar, 50).Value = ToDbNullStr(COO)
                cmd.Parameters.Add("@TIER", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Tier)
                cmd.Parameters.Add("@Receipt_num", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Receipt_num)
                cmd.Parameters.Add("@MSL", SqlDbType.NVarChar, 50).Value = ToDbNullStr(MSL)

                cmd.Parameters.Add("@DESC", SqlDbType.NVarChar, 400).Value = ToDbNullStr(DESC)
                cmd.Parameters.Add("@Vendor", SqlDbType.NVarChar, 300).Value = ToDbNullStr(Vendor)
                cmd.Parameters.Add("@Area", SqlDbType.NVarChar, 20).Value = ToDbNullStr(Area)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        ' Check schema: thiếu cột thì báo ngay (tránh lúc in tem mới lỗi)
        EnsureInsertNewComponent2Schema(dsDB)

        Return dsDB
    End Function

    Private Sub EnsureInsertNewComponent2Schema(ByVal ds As DataSet)
        If ds Is Nothing OrElse ds.Tables.Count = 0 Then
            Throw New Exception("p_InsertNewComponent2 returned no tables.")
        End If

        Dim t As DataTable = ds.Tables(0)
        If t.Rows.Count = 0 Then
            ' Không bắt buộc lỗi, nhưng thường là bất thường
            ' Throw New Exception("p_InsertNewComponent2 returned 0 rows.")
            Exit Sub
        End If

        Dim requiredCols As String() = {
        "ComponentID",
        "QtyPerPackage",
        "UGPN",
        "LotCode",
        "StorageLoc",
        "MfgPN",
        "DateCode",
        "TIER",
        "Receipt_num",
        "FirmWareVersion",
        "MSL",
        "Description",
        "VENDOR",
        "COO",
        "ESDS",
        "None_InSpection",
        "Area"
    }

        For Each c As String In requiredCols
            If Not t.Columns.Contains(c) Then
                Throw New Exception("Missing column from p_InsertNewComponent2 output: " & c)
            End If
        Next
    End Sub


    Public Function InsertNewComponent2_fromproduct(
    ByVal DEV As Integer,
    ByVal NoOfPackages As Integer,
    ByVal QtyPerPackage As Integer,
    ByVal PO As String,
    ByVal UGPN As String,
    ByVal MfgPN As String,
    ByVal Mfger As String,
    ByVal LotCode As String,
    ByVal DateCode As String,
    ByVal FirmWare As String,
    ByVal UserName As String,
    ByVal Loc As String,
    Optional ByVal ParentComponentID As String = "",
    Optional ByVal MSL As String = "",
    Optional ByVal Tier As String = "",
    Optional ByVal Receipt_num As String = "",
    Optional ByVal COO As String = "",
    Optional ByVal DESC As String = "",
    Optional ByVal Vendor As String = "",
    Optional ByVal Area As String = ""
) As DataSet

        Dim dsDB As New DataSet()

        ' Helper: ""/Nothing -> DBNull
        Dim ToDbNullStr As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s, Object))

        Using sqlcon As SqlConnection = GetConnection()
            Using cmd As New SqlCommand("p_InsertNewComponent1", sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                ' ====== ĐÚNG TÊN / ĐÚNG TYPE / ĐÚNG LENGTH theo SP ======
                cmd.Parameters.Add("@NoOfPackages", SqlDbType.Int).Value = NoOfPackages

                cmd.Parameters.Add("@QtyPerPackage", SqlDbType.Int).Value = QtyPerPackage

                cmd.Parameters.Add("@PO", SqlDbType.NVarChar, 20).Value = ToDbNullStr(PO)
                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value = ToDbNullStr(UGPN)
                cmd.Parameters.Add("@MfgPN", SqlDbType.NVarChar, 50).Value = ToDbNullStr(MfgPN)
                cmd.Parameters.Add("@Mfger", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Mfger)
                cmd.Parameters.Add("@LotCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(LotCode)
                cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 40).Value = ToDbNullStr(DateCode)

                cmd.Parameters.Add("@FirmWareVersion", SqlDbType.NVarChar, 20).Value = ToDbNullStr(FirmWare)

                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = ToDbNullStr(UserName)

                cmd.Parameters.Add("@Loc", SqlDbType.NVarChar, 40).Value = ToDbNullStr(Loc)

                cmd.Parameters.Add("@ParentComponentID", SqlDbType.NVarChar, 50).Value = ToDbNullStr(ParentComponentID)
                cmd.Parameters.Add("@COO", SqlDbType.NVarChar, 50).Value = ToDbNullStr(COO)
                cmd.Parameters.Add("@TIER", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Tier)

                cmd.Parameters.Add("@Receipt_num", SqlDbType.NVarChar, 50).Value = ToDbNullStr(Receipt_num)
                cmd.Parameters.Add("@MSL", SqlDbType.NVarChar, 50).Value = ToDbNullStr(If(MSL, "").Trim())

                cmd.Parameters.Add("@DESC", SqlDbType.NVarChar, 400).Value = ToDbNullStr(DESC)
                cmd.Parameters.Add("@Vendor", SqlDbType.NVarChar, 500).Value = ToDbNullStr(Vendor)
                cmd.Parameters.Add("@Area", SqlDbType.NVarChar, 20).Value = ToDbNullStr(Area)
                cmd.Parameters.Add("@DEV", SqlDbType.Int).Value = DEV

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dsDB, "ProcessStation")
                End Using
            End Using
        End Using

        Return dsDB
    End Function


    Private Shared _LoginName As String
    Private Shared _Level As String


    Public Shared Property LoginName() As String
        Get
            Return _LoginName
        End Get
        Set(ByVal value As String)
            _LoginName = value
        End Set
    End Property

    Public Shared Property Level() As String 'Jerry Add new
        Get
            Return _Level
        End Get
        Set(ByVal value As String)
            _Level = value
        End Set
    End Property
End Class

