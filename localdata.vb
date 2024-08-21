Imports System.data
Imports System.Data.OleDb
Imports System.Management
Imports System
Imports System.Data.SqlClient
Public Class localdata

    Public Function getMachineName() As String
        Return Environment.MachineName
    End Function

    Public Shared Function GetConnection() As OleDb.OleDbConnection
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TempComp.mdb"
        Return New OleDb.OleDbConnection(connectionString)
    End Function


    Function Str2Len(ByVal OriginalStr As String, ByVal requiredlen As Integer) As String
        While Len(OriginalStr) < requiredlen
            OriginalStr = "0" + OriginalStr
            Continue While
        End While
        Return OriginalStr

    End Function
    Public Shared Function getDataset(ByVal [select] As String) As DataSet
        Using conn As SqlConnection = New SqlConnection(ModVar.Strconn_66)
            Dim da As SqlDataAdapter = New SqlDataAdapter([select], conn)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Return ds
        End Using
    End Function

    Public Shared Function DataTable_Sql(ByVal sql As String) As DataTable
        Try

            Using conn As SqlConnection = New SqlConnection(ModVar.Strconn_66)

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


    Function dec2hex(ByVal OriginalStr As Integer) As String
        Return Hex(OriginalStr).ToString
    End Function

    Function GenerateComponentIDs(ByVal SSN As Integer, ByVal ESN As Integer, ByVal QtyerPack As Integer, ByVal ControlID As Integer) As ArrayList
        Dim ComponentIDList As New ArrayList
        While SSN <= ESN
            'genetqte componentID

            Dim ComponentID As String = GetComponentID(QtyerPack, SSN)
            'insert componentID
            InsertNewComponentID(ComponentID, ControlID)
            'add to AArray List
            ComponentIDList.Add(ComponentID)
            SSN = SSN + 1
            Continue While
        End While
        Return ComponentIDList
        End

    End Function

    Function GetComponentID(ByVal QtyPerPack As Integer, ByVal Input As Integer) As String
        Dim Sn As String
        Dim YY As String
        Dim WW As String
        Dim SSSS As String
        YY = Year(Date.Now).ToString.Substring(2, 2)
        WW = Str2Len(getWeek(), 2)
        SSSS = Str2Len(dec2hex(Input), 4)
        Sn = "CC" + Str2Len(QtyPerPack, 5) + YY + WW + SSSS
        Return Sn
    End Function



    Public Sub InsertNewComponentID(ByVal ComponentID As String, ByVal ControllID As Integer)
        Try
            Dim connection As OleDb.OleDbConnection = GetConnection()
            Dim SqlString As String = "Insert Into ComponentID_tbl (ComponentID, ControllID) Values (@ComponentID, @ControllID)"

            Dim cmdInser As OleDbCommand = New OleDbCommand(SqlString, connection)
            cmdInser.CommandType = CommandType.Text

            Dim parameter As OleDbParameter
            parameter = cmdInser.Parameters.Add("@ComponentID", OleDbType.VarChar, 20)
            parameter.Value = ComponentID

            parameter = cmdInser.Parameters.Add("@ControllID", OleDbType.Integer)
            parameter.Value = ControllID

            connection.Open()
            cmdInser.ExecuteNonQuery()
            connection.Close()
        Catch
            Throw
        End Try



    End Sub

    Public Function SelectEndSN(ByVal YWeek As String) As Integer
        Dim connection As OleDb.OleDbConnection = GetConnection()
        Dim SqlString As String = "SELECT Top 1 EndSN FROM ComponentIDController Where YWeek=@YWeek order by EndSN desc;"
        Dim adapter As New OleDbDataAdapter(SqlString, connection)
        Dim dataSet As New DataSet
        ' Set the parameters.
        With adapter.SelectCommand.Parameters
            .Add("@YWeek", OleDbType.VarChar, 20).Value = YWeek
        End With
        Try
            connection.Open()
            adapter.Fill(dataSet)
            connection.Close()
        Catch
            Throw
        End Try
        If dataSet.Tables(0).Rows.Count > 0 Then
            Return dataSet.Tables(0).Rows(0).Item(0)
        Else
            Return 0
        End If

    End Function



    Public Sub InsertNewMaterial(ByVal NoOfPackages As Integer, ByVal StartSN As Integer, ByVal EndSN As Integer, ByVal QtyPerPackage As Integer, ByVal PO As String, ByVal UGPN As String, ByVal MfgPN As String, ByVal Mfger As String, _
    ByVal LotCode As String, ByVal DateCode As String, ByVal FirmWareVersion As String, ByVal YWeek As String, ByVal UserName As String, ByVal StorageLoc As String, ByVal tempKey As String)
        Try
            Dim connection As OleDb.OleDbConnection = GetConnection()
            Dim SqlString As String = "Insert Into ComponentIDController ([NoOfPackages], [StartSN], [EndSN], [QtyPerPackage], [PO], [UGPN], [MfgPN],[Mfger], [LotCode], [DateCode], [FirmWareVersion], [YWeek],[UserName], [StorageLoc],[TempID],[DateRevc])" & _
                               " Values (@NoOfPackages, @StartSN, @EndSN, @QtyPerPackage, @PO, @UGPN, @MfgPN, @Mfger, @LotCode, @DateCode, @FirmWareVersion, @YWeek, @UserName, @StorageLoc , @TempKey, @Date)"


            Dim cmdInser As OleDbCommand = New OleDbCommand(SqlString, connection)
            cmdInser.CommandType = CommandType.Text

            Dim parameter As OleDbParameter
            parameter = cmdInser.Parameters.Add("@NoOfPackages", OleDbType.Integer)
            parameter.Value = NoOfPackages

            parameter = cmdInser.Parameters.Add("@StartSN", OleDbType.Integer)
            parameter.Value = StartSN

            parameter = cmdInser.Parameters.Add("@EndSN", OleDbType.Integer)
            parameter.Value = EndSN

            parameter = cmdInser.Parameters.Add("@QtyPerPackage", OleDbType.Integer)
            parameter.Value = QtyPerPackage

            parameter = cmdInser.Parameters.Add("@PO", OleDbType.VarChar, 20)
            parameter.Value = PO

            parameter = cmdInser.Parameters.Add("@UGPN", OleDbType.VarChar, 40)
            parameter.Value = UGPN


            parameter = cmdInser.Parameters.Add("@MfgPN", OleDbType.VarChar, 40)
            parameter.Value = MfgPN

            parameter = cmdInser.Parameters.Add("@Mfger", OleDbType.VarChar, 50)
            parameter.Value = Mfger

            parameter = cmdInser.Parameters.Add("@LotCode", OleDbType.VarChar, 20)
            parameter.Value = LotCode

            parameter = cmdInser.Parameters.Add("@DateCode", OleDbType.VarChar, 20)
            parameter.Value = DateCode

            parameter = cmdInser.Parameters.Add("@FirmWareVersion", OleDbType.VarChar, 30)
            If FirmWareVersion = "N/A" Then
                parameter.Value = System.DBNull.Value
            Else
                parameter.Value = FirmWareVersion
            End If


            parameter = cmdInser.Parameters.Add("@YWeek", OleDbType.VarChar, 20)
            parameter.Value = YWeek

            parameter = cmdInser.Parameters.Add("@UserName", OleDbType.VarChar, 20)
            parameter.Value = UserName



            parameter = cmdInser.Parameters.Add("@StorageLoc", OleDbType.VarChar, 20)
            If StorageLoc = "" Then
                parameter.Value = System.DBNull.Value
            Else
                parameter.Value = StorageLoc
            End If


            parameter = cmdInser.Parameters.Add("@tempKey", OleDbType.VarChar, 50)
            parameter.Value = tempKey
            parameter = cmdInser.Parameters.Add("@Date", OleDbType.Date)
            parameter.Value = Date.Now


            connection.Open()
            cmdInser.ExecuteNonQuery()
            connection.Close()
        Catch
            Throw
        End Try



    End Sub


    Public Function GetLastControlID(ByVal tempKey As String) As Integer

        Dim connection As OleDb.OleDbConnection = GetConnection()
        Dim queryString As String = "SELECT Top 1 ControlID FROM ComponentIDController Where TempID=@tempKey order by ControlID desc"
        Dim adapter As New OleDbDataAdapter(queryString, connection)
        Dim dataSet As New DataSet
        ' Set the parameters.
        With adapter.SelectCommand.Parameters
            .Add("@tempKey", OleDbType.VarChar, 50).Value = tempKey
        End With
        Try
            connection.Open()
            adapter.Fill(dataSet)
            connection.Close()
        Catch
            Throw
        End Try
        Return dataSet.Tables(0).Rows(0).Item(0)

    End Function

    Public Function getWeek() As String

        Dim DateTime As Date = Date.Now
        Dim cult_info As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("no")
        Dim cal As System.Globalization.Calendar = cult_info.Calendar
        Dim weekNo As Integer = cal.GetWeekOfYear(DateTime, Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Friday)
        Return Str2Len(weekNo.ToString, 2)

    End Function




    Public Function getYYYYWW() As String

        Dim DateTime As Date = Date.Now
        Dim cult_info As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("no")
        Dim cal As System.Globalization.Calendar = cult_info.Calendar
        Dim weekNo As Integer = cal.GetWeekOfYear(DateTime, Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Friday)
        Return Year(Date.Now).ToString + "W" + Str2Len(weekNo.ToString, 2)

    End Function

End Class

Public Class ComponentGroup
    Private _UnigenPN As String = ""
    Private _QtyPerPack As String = 0
    Private _StorageLoc As String = ""
    Private _LotCode As String = ""
    Private _DateCode As String = ""
    Private _MfgPN As String = ""
    Private _Customer As String = ""
    Public Sub New(ByVal UnigenPN As String, ByVal ComponentID As String, ByVal QtyPerPack As Double, ByVal StorageLoc As String, ByVal LotCode As String, ByVal DateCode As String, ByVal MfgPN As String, ByVal Customer As String)
        _UnigenPN = UnigenPN
        _QtyPerPack = QtyPerPack
        _StorageLoc = StorageLoc
        _LotCode = LotCode
        _DateCode = DateCode
        _MfgPN = MfgPN
        _Customer = Customer
    End Sub


    Public Property Customer() As String
        Get
            Return _Customer
        End Get
        Set(ByVal value As String)
            _Customer = value
        End Set
    End Property
    Public Property UnigenPN() As String
        Get
            Return _UnigenPN
        End Get
        Set(ByVal value As String)
            _UnigenPN = value
        End Set
    End Property

    Public Property QtyPerPack() As Double
        Get
            Return _QtyPerPack
        End Get
        Set(ByVal value As Double)
            _QtyPerPack = value

        End Set
    End Property


    Public Property StorageLoc() As String
        Get
            Return _StorageLoc
        End Get
        Set(ByVal value As String)
            _StorageLoc = value
        End Set
    End Property

    Public Property LotCode() As String

        Get
            Return _LotCode
        End Get
        Set(ByVal value As String)
            _LotCode = value
        End Set
    End Property

    Public Property MfgPN() As String
        Get
            Return _MfgPN
        End Get
        Set(ByVal value As String)
            _MfgPN = value
        End Set
    End Property

    Public Property DateCode() As String
        Get
            Return _DateCode
        End Get
        Set(ByVal value As String)
            _DateCode = value
        End Set
    End Property

End Class

