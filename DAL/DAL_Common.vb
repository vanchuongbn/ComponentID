Imports System.Data.SqlClient

Public Class DAL_Common

    ' Dim connectionString_26 As String = "Data Source=172.16.1.26\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd;"

    Private Shared ReadOnly connectionString_26 As String =
        "Data Source=172.16.1.26\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd;"

    Public Shared Function Components_Wating_WI_Create_Add(
        ByVal PO_NUMBER As String,
        ByVal UPN As String,
        ByVal MFG_PART_NUMBER As String,
        ByVal MANUFACTURER As String,
        ByVal MFR_LOT_CODE As String,
        ByVal MFR_DATE_CODE As String,
        ByVal Receipt_num As String,
        ByVal Transaction_Time As String
    ) As Boolean

        Try
            Using cn As New SqlConnection(connectionString_26),
                  cmd As New SqlCommand("Components_Wating_WI_Create_Add", cn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@PO_NUMBER", SqlDbType.VarChar, 20).Value = If(PO_NUMBER, "").Trim()
                cmd.Parameters.Add("@UPN", SqlDbType.NVarChar, 40).Value = If(UPN, "").Trim()
                cmd.Parameters.Add("@MFG_PART_NUMBER", SqlDbType.NVarChar, 50).Value = If(MFG_PART_NUMBER, "").Trim()
                cmd.Parameters.Add("@MANUFACTURER", SqlDbType.NVarChar, 50).Value = If(MANUFACTURER, "").Trim()
                cmd.Parameters.Add("@MFR_LOT_CODE", SqlDbType.NVarChar, 40).Value = If(MFR_LOT_CODE, "").Trim()
                cmd.Parameters.Add("@MFR_DATE_CODE", SqlDbType.NVarChar, 40).Value = If(MFR_DATE_CODE, "").Trim()
                cmd.Parameters.Add("@Receipt_num", SqlDbType.NVarChar, 50).Value = If(Receipt_num, "").Trim()
                cmd.Parameters.Add("@Transaction_Time", SqlDbType.NVarChar, 50).Value = If(Transaction_Time, "").Trim()

                cn.Open()
                cmd.ExecuteNonQuery()
                Return True
            End Using

        Catch ex As Exception
            ' Nếu muốn log: Debug.WriteLine(ex.ToString())
            Return False
        End Try
    End Function




    Public Function GetListUsers_NeedToDo(ByVal DocNo As String, ByVal Docrev As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim Str_Querry As String = "select distinct TblCreateTrainingrequest.EmployeeID, TblEmployee.Fullname as EmployeeName,  ISNULL(CONVERT(bit, NeedToRetrain), CONVERT(bit, 0)) as NeedToRetrain
                from TblCreateTrainingrequest
                inner join TblEmployee on TblCreateTrainingrequest.EmployeeID = TblEmployee.EmployeeID
                left join (select EmployeeID,NeedToRetrain, DocNo from tblEmployeeList_NeedToTrain_ForNewDoc where DocNo = @DocNo and DocRev = @DocRev) as c
					on TblEmployee.EmployeeID = c.EmployeeID
                where TblCreateTrainingrequest.DocNo = @DocNo and TblEmployee.ActiveYESNO = 'yes'
                union
                select EmployeeID, EmployeeName, NeedToRetrain from tblEmployeeList_NeedToTrain_ForNewDoc where DocNo = @DocNo and DocRev = @DocRev
                order by EmployeeID"
        Dim cn As SqlConnection = New SqlConnection(connectionString_26)
        cn.Open()
        Try
            Dim cmd As SqlCommand = New SqlCommand(Str_Querry, cn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@DocNo", SqlDbType.VarChar).Value = DocNo
            cmd.Parameters.Add("@DocRev", SqlDbType.NChar).Value = Docrev
            Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
            adap.Fill(dt)
        Catch ex As Exception
        Finally
            cn.Close()
        End Try

        Return dt

    End Function




End Class
