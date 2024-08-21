
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Net.Mail

Public Class frmCheckOverdateCode
    Dim dr As SqlDataReader
    Dim ConnSQL As SqlConnection
    Dim obj As ListItem

    Private Function PopulateForm_11(ByVal Ten_Thu_tuc As String, ByVal ID As String) As SqlDataReader
        Dim SqlDr As SqlDataReader
        Try

            Dim Sqlcmd As SqlCommand = New SqlCommand(" " & Ten_Thu_tuc & "   '" & ID & "'", Me.ConnSQL)
            SqlDr = Sqlcmd.ExecuteReader
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
        Return SqlDr
        SqlDr.Close()
        ConnSQL.Close()
    End Function
    Private Sub load_combo()
        Me.ConnSQL = New SqlConnection
        Me.ConnSQL.ConnectionString = Strconn
        Me.ConnSQL.Open()
      

        dr = Me.PopulateForm_11("SP_MslLevel_View", "")
        Me.cmbMsl.Items.Clear()
        While dr.Read
            obj = New ListItem(CStr(dr.Item("msllevel").ToString.Trim), dr.Item("id").ToString().Trim)
            Me.cmbMsl.Items.Add(obj)
        End While
        dr.Close()


        Me.ConnSQL.Close()
        Me.cmbMsl.SelectedIndex = 0
    End Sub
    Private Sub frmCheckOverdateCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_combo()
        chk()

    End Sub
    Public Sub find()
        Try

            If chkdate.Checked = True And chkUGPN.Checked = True And chkMFGPN.Checked = True And chkMSL.Checked = True Then
                Dim a As String = Convert.ToDateTime(DateTimePicker1.Text).ToString("MM/dd/yyyy")
                'Dim b As String = Convert.ToDateTime(dapto.Text).ToString("MM/dd/yyyy")
                Dim sl As String = "SELECT dbo.ComponentID_tbl_WH.ComponentID, dbo.ComponentIDController_WH.UGPN,dbo.ComponentIDController_WH.DateRevc, dbo.ComponentIDController_WH.MfgPN,dbo.ComponentIDController_WH.DateCode,"
                sl += " dbo.ComponentIDController_WH.Ex_DateCode, dbo.ComponentIDController_WH.DateExpire, dbo.ComponentIDController_WH.OriginQty,  dbo.ComponentIDController_WH.QtyPerPackage,dbo.ComponentIDController_WH.StorageLoc, "
                sl += " dbo.ComponentID_tbl_WH.ControllID, dbo.ComponentIDController_WH.StartSN, dbo.ComponentIDController_WH.NoOfPackages, dbo.ComponentIDController_WH.EndSN, "
                sl += " dbo.ComponentIDController_WH.PO,dbo.ComponentIDController_WH.Mfger,dbo.ComponentIDController_WH.LotCode, "
                sl += " dbo.ComponentIDController_WH.FirmWareVersion, dbo.ComponentIDController_WH.UserName, "
                sl += " dbo.ComponentIDController_WH.YWeek, dbo.ComponentIDController_WH.TempID, dbo.ComponentIDController_WH.MSL,"
                sl += " dbo.ComponentIDController_WH.ParentComponentID, dbo.ComponentIDController_WH.COO, dbo.ComponentIDController_WH.TIER, dbo.ComponentIDController_WH.Receipt_num"
                sl += " FROM dbo.ComponentID_tbl_WH INNER JOIN dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where  ComponentIDController_WH.OriginQty !=0 "
                Dim ds As DataSet = Datalayer.getDataset(sl)
                Dim dt As DataTable = Datalayer.DataTable_Sql(sl)
                dgv.DataSource = ds.Tables(0)
                dgv.Refresh()
                lbltotal.Text = "Total:" & dt.Rows.Count.ToString()

            Else

                Dim a As String = Convert.ToDateTime(DateTimePicker1.Text).ToString("MM/dd/yyyy")
                'Dim b As String = Convert.ToDateTime(dapto.Text).ToString("MM/dd/yyyy")
                Dim sl As String = "SELECT dbo.ComponentID_tbl_WH.ComponentID, dbo.ComponentIDController_WH.UGPN,dbo.ComponentIDController_WH.DateRevc, dbo.ComponentIDController_WH.MfgPN,dbo.ComponentIDController_WH.DateCode,"
                sl += " dbo.ComponentIDController_WH.Ex_DateCode, dbo.ComponentIDController_WH.DateExpire, dbo.ComponentIDController_WH.OriginQty,  dbo.ComponentIDController_WH.QtyPerPackage,dbo.ComponentIDController_WH.StorageLoc, "
                sl += " dbo.ComponentID_tbl_WH.ControllID, dbo.ComponentIDController_WH.StartSN, dbo.ComponentIDController_WH.NoOfPackages, dbo.ComponentIDController_WH.EndSN, "
                sl += " dbo.ComponentIDController_WH.PO,dbo.ComponentIDController_WH.Mfger,dbo.ComponentIDController_WH.LotCode, "
                sl += " dbo.ComponentIDController_WH.FirmWareVersion, dbo.ComponentIDController_WH.UserName, "
                sl += " dbo.ComponentIDController_WH.YWeek, dbo.ComponentIDController_WH.TempID, dbo.ComponentIDController_WH.MSL,"
                sl += " dbo.ComponentIDController_WH.ParentComponentID, dbo.ComponentIDController_WH.COO, dbo.ComponentIDController_WH.TIER, dbo.ComponentIDController_WH.Receipt_num"
                sl += " FROM dbo.ComponentID_tbl_WH INNER JOIN dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where  ComponentIDController_WH.OriginQty !=0 "


                If (txtUGPN.Text.Trim() <> String.Empty) Or (txtUGPN.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.UGPN='" & txtUGPN.Text.Trim() & "' "
                ElseIf (txtMFG.Text.Trim() <> String.Empty) Or (txtMFG.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.MfgPN='" & txtMFG.Text.Trim() & "' "
                    'ElseIf (DateTimePicker1.Text.Trim() <> String.Empty) Or (DateTimePicker1.Text.Trim <> "") Then
                ElseIf (cmbMsl.Text.Trim <> String.Empty) Then
                    sl += " and dbo.ComponentIDController_WH.MSL='" & cmbMsl.Text.Trim() & "' "
                End If
                sl += " and DATEDIFF(DAY, '" + a + "',dbo.ComponentIDController_WH.DateExpire) < 0 "
                sl += " order by dbo.ComponentIDController_WH.DateExpire asc"

                Dim ds As DataSet = Datalayer.getDataset(sl)
                Dim dt As DataTable = Datalayer.DataTable_Sql(sl)
                dgv.DataSource = ds.Tables(0)
                dgv.Refresh()
                lbltotal.Text = "Total:" & dt.Rows.Count.ToString()
            End If


        Catch __unusedException1__ As Exception
            MessageBox.Show(__unusedException1__.Message)
        End Try
    End Sub
    Public Sub chk()

        If chkdate.Checked = True Then
            DateTimePicker1.Enabled = False
        Else
            DateTimePicker1.Enabled = True
        End If


        If chkUGPN.Checked = True Then
            txtUGPN.Enabled = False
        Else
            txtUGPN.Enabled = True
        End If


        If chkMFGPN.Checked = True Then
            txtMFG.Enabled = False
        Else
            txtMFG.Enabled = True
        End If


        If chkMSL.Checked = True Then
            cmbMsl.Enabled = False
        Else
            cmbMsl.Enabled = True
        End If



    End Sub


    Private Sub tbnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSearch.Click
        find()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMSL.CheckedChanged
        chk()
    End Sub

    Private Sub chkdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdate.CheckedChanged
        chk()
    End Sub

    Private Sub chkUGPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUGPN.CheckedChanged
        chk()
    End Sub

    Private Sub chkMFGPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMFGPN.CheckedChanged
        chk()
    End Sub
    Private Sub export_excel()
        If (Me.dgv.Rows.Count = 0) Then Return
        Dim dset As DataSet = New DataSet()
        dset.Tables.Add()

        For i As Integer = 0 To Me.dgv.ColumnCount - 1
            dset.Tables(0).Columns.Add(Me.dgv.Columns(i).HeaderText)
        Next

        Dim dr1 As DataRow

        For i As Integer = 0 To dgv.RowCount - 1
            dr1 = dset.Tables(0).NewRow()

            For j As Integer = 0 To dgv.Columns.Count - 1
                dr1(j) = dgv.Rows(i).Cells(j).Value
            Next

            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add()
        wSheet = CType((wBook.ActiveSheet), Microsoft.Office.Interop.Excel.Worksheet)
        Dim dt As DataTable = dset.Tables(0)
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc As DataColumn In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr As DataRow In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0

            For Each dc As DataColumn In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName).ToString()
            Next
        Next

        wSheet.Columns.AutoFit()
        Dim dialog As SaveFileDialog = New SaveFileDialog()
        Dim strFileName As String = "Hardware.xlsx"
        dialog.FileName = strFileName
        dialog.ShowDialog()
        Dim blnFileOpen As Boolean = False

        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch __unusedException1__ As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then System.IO.File.Delete(strFileName)
        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True
    End Sub
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        export_excel()
    End Sub

    Private Sub cmbMsl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMsl.SelectedIndexChanged

    End Sub
End Class