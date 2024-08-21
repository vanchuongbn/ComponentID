Public Class frmBrokerExport

    Private Sub tbnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSearch.Click
        Try


            If chkAuthentic.Checked = True Then

                Dim sl As String = "SELECT dbo.ComponentID_tbl_WH.ComponentID, dbo.ComponentIDController_WH.ControlID, dbo.ComponentIDController_WH.NoOfPackages, dbo.ComponentIDController_WH.StartSN,  "
                sl += " dbo.ComponentIDController_WH.EndSN, dbo.ComponentIDController_WH.QtyPerPackage, dbo.ComponentIDController_WH.PO, dbo.ComponentIDController_WH.UGPN, dbo.ComponentIDController_WH.MfgPN, "
                sl += " dbo.ComponentIDController_WH.Mfger, dbo.ComponentIDController_WH.LotCode, dbo.ComponentIDController_WH.DateCode, dbo.ComponentIDController_WH.FirmWareVersion, "
                sl += " dbo.ComponentIDController_WH.YWeek, dbo.ComponentIDController_WH.UserName, dbo.ComponentIDController_WH.DateRevc, dbo.ComponentIDController_WH.StorageLoc, "
                sl += " dbo.ComponentIDController_WH.TempID, dbo.ComponentIDController_WH.ParentComponentID, dbo.ComponentIDController_WH.COO, dbo.ComponentIDController_WH.TIER, "
                sl += " dbo.ComponentIDController_WH.Receipt_num, dbo.ComponentIDController_WH.Ex_DateCode, dbo.ComponentIDController_WH.DateExpire, dbo.ComponentIDController_WH.OriginQty as Balance_OH, "
                sl += " dbo.ComponentIDController_WH.MSL, dbo.ComponentIDController_WH.Description, dbo.ComponentIDController_WH.VENDOR"
                sl += " FROM dbo.ComponentID_tbl_WH INNER JOIN"
                sl += " dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where ComponentIDController_WH.OriginQty !=0 and dbo.ComponentIDController_WH.VENDOR not in (SELECT [BrokerName] FROM [UnigenTrax].[dbo].[tblUnAuthentic]) and dbo.ComponentIDController_WH.VENDOR is not null  "
                If (txtUGPN.Text.Trim() <> String.Empty) Or (txtUGPN.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.UGPN='" & txtUGPN.Text.Trim() & "' "
                ElseIf (txtMFG.Text.Trim() <> String.Empty) Or (txtMFG.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.MfgPN='" & txtMFG.Text.Trim() & "' "
                End If
                'sl += " and DATEDIFF(DAY, '" + a + "',dbo.ComponentIDController_WH.DateExpire) < 0 "
                sl += " order by dbo.ComponentIDController_WH.DateRevc desc"

                Dim ds As DataSet = Datalayer.getDataset(sl)
                Dim dt As DataTable = Datalayer.DataTable_Sql(sl)
                dgv.DataSource = ds.Tables(0)
                dgv.Refresh()
                lbltotal.Text = "Total:" & dt.Rows.Count.ToString()

                'sum total
                Dim sl_sumqty As String = "Select sum(ComponentIDController_WH.OriginQty) as total "
                sl_sumqty += " FROM dbo.ComponentID_tbl_WH INNER JOIN"
                sl_sumqty += " dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where ComponentIDController_WH.OriginQty !=0 and dbo.ComponentIDController_WH.VENDOR not in (SELECT [BrokerName] FROM [UnigenTrax].[dbo].[tblUnAuthentic]) and dbo.ComponentIDController_WH.VENDOR is not null  "
                If (txtUGPN.Text.Trim() <> String.Empty) Or (txtUGPN.Text.Trim <> "") Then
                    sl_sumqty += " and dbo.ComponentIDController_WH.UGPN='" & txtUGPN.Text.Trim() & "' "
                ElseIf (txtMFG.Text.Trim() <> String.Empty) Or (txtMFG.Text.Trim <> "") Then
                    sl_sumqty += " and dbo.ComponentIDController_WH.MfgPN='" & txtMFG.Text.Trim() & "' "
                End If
                Dim ds_qty As DataSet = Datalayer.getDataset(sl_sumqty)
                If ds_qty.Tables(0).Rows.Count > 0 Then
                    lblsum.Text = "Total:" + ds_qty.Tables(0).Rows(0)("total").ToString().Trim()
                End If


            ElseIf (chkUnauthentic.Checked = True) Then
                Dim sl As String = "SELECT dbo.ComponentID_tbl_WH.ComponentID, dbo.ComponentIDController_WH.ControlID, dbo.ComponentIDController_WH.NoOfPackages, dbo.ComponentIDController_WH.StartSN, "
                sl += " dbo.ComponentIDController_WH.EndSN, dbo.ComponentIDController_WH.QtyPerPackage, dbo.ComponentIDController_WH.PO, dbo.ComponentIDController_WH.UGPN, dbo.ComponentIDController_WH.MfgPN, "
                sl += " dbo.ComponentIDController_WH.Mfger, dbo.ComponentIDController_WH.LotCode, dbo.ComponentIDController_WH.DateCode, dbo.ComponentIDController_WH.FirmWareVersion, "
                sl += " dbo.ComponentIDController_WH.YWeek, dbo.ComponentIDController_WH.UserName, dbo.ComponentIDController_WH.DateRevc, dbo.ComponentIDController_WH.StorageLoc, "
                sl += " dbo.ComponentIDController_WH.TempID, dbo.ComponentIDController_WH.ParentComponentID, dbo.ComponentIDController_WH.COO, dbo.ComponentIDController_WH.TIER, "
                sl += " dbo.ComponentIDController_WH.Receipt_num, dbo.ComponentIDController_WH.Ex_DateCode, dbo.ComponentIDController_WH.DateExpire, dbo.ComponentIDController_WH.OriginQty as Balance_OH, "
                sl += " dbo.ComponentIDController_WH.MSL, dbo.ComponentIDController_WH.Description, dbo.ComponentIDController_WH.VENDOR"
                sl += " FROM dbo.ComponentID_tbl_WH INNER JOIN"
                sl += " dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where ComponentIDController_WH.OriginQty !=0 and dbo.ComponentIDController_WH.VENDOR in (SELECT [BrokerName] FROM [UnigenTrax].[dbo].[tblUnAuthentic]) "
                If (txtUGPN.Text.Trim() <> String.Empty) Or (txtUGPN.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.UGPN='" & txtUGPN.Text.Trim() & "' "
                ElseIf (txtMFG.Text.Trim() <> String.Empty) Or (txtMFG.Text.Trim <> "") Then
                    sl += " and dbo.ComponentIDController_WH.MfgPN='" & txtMFG.Text.Trim() & "' "
                End If
                'sl += " and DATEDIFF(DAY, '" + a + "',dbo.ComponentIDController_WH.DateExpire) < 0 "
                sl += " order by dbo.ComponentIDController_WH.DateRevc desc"

                Dim ds As DataSet = Datalayer.getDataset(sl)
                Dim dt As DataTable = Datalayer.DataTable_Sql(sl)
                dgv.DataSource = ds.Tables(0)
                dgv.Refresh()
                lbltotal.Text = "Total:" & dt.Rows.Count.ToString()


                'sum total
                Dim sl_sumqty As String = "Select sum(ComponentIDController_WH.OriginQty) as total "
                sl_sumqty += " FROM dbo.ComponentID_tbl_WH INNER JOIN"
                sl_sumqty += " dbo.ComponentIDController_WH ON dbo.ComponentID_tbl_WH.ControllID = dbo.ComponentIDController_WH.ControlID where ComponentIDController_WH.OriginQty !=0 and dbo.ComponentIDController_WH.VENDOR in (SELECT [BrokerName] FROM [UnigenTrax].[dbo].[tblUnAuthentic]) "
                If (txtUGPN.Text.Trim() <> String.Empty) Or (txtUGPN.Text.Trim <> "") Then
                    sl_sumqty += " and dbo.ComponentIDController_WH.UGPN='" & txtUGPN.Text.Trim() & "' "
                ElseIf (txtMFG.Text.Trim() <> String.Empty) Or (txtMFG.Text.Trim <> "") Then
                    sl_sumqty += " and dbo.ComponentIDController_WH.MfgPN='" & txtMFG.Text.Trim() & "' "
                End If
                Dim ds_qty As DataSet = Datalayer.getDataset(sl_sumqty)
                If ds_qty.Tables(0).Rows.Count > 0 Then
                    lblsum.Text = "Total:" + ds_qty.Tables(0).Rows(0)("total").ToString().Trim()
                End If
            Else
               
            End If

            ' Dim a As String = Convert.ToDateTime(DateTimePicker1.Text).ToString("MM/dd/yyyy")
            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        export_excel()
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
        Dim strFileName As String = "BrokerFile.xlsx"
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

    Private Sub frmBrokerExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
    End Sub
End Class