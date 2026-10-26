

Imports System.Data.SqlClient
Imports ClosedXML.Excel
Public Class frmCheckFIFO
    Dim mydaya As New Datalayer
    Dim dsComponent As DataSet

    Private Sub frmCheckFIFO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub searchFIFO(ByVal component As String,
                      ByVal ugpn As String,
                      ByVal dateFrom As Nullable(Of Date),
                      ByVal dateTo As Nullable(Of Date))

        dsComponent = mydaya.GetdsDateCode_FIFO_S(component, ugpn, dateFrom, dateTo)
        DGRFIFO.DataSource = dsComponent.Tables(0)
        lbltotal.Text = "Total Records: " & dsComponent.Tables(0).Rows.Count.ToString()
    End Sub


    'Private Sub SearchFIFO_Summary(ByVal componentID As String, ByVal ugpn As String)
    '    Dim dt As New DataTable()

    '    Using cn As SqlConnection = Datalayer.GetConnection(),
    '      cmd As New SqlCommand("p_CheckFIFO_DATECODE_Summary", cn)

    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandTimeout = 60

    '        cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
    '        If(String.IsNullOrWhiteSpace(componentID), CType(DBNull.Value, Object), componentID.Trim())

    '        cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
    '        If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())
    '        Using da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '        End Using
    '    End Using

    '    DGVSummary.AutoGenerateColumns = True
    '    DGVSummary.DataSource = dt

    '    ' Ẩn SortOrder
    '    If DGVSummary.Columns.Contains("SortOrder") Then
    '        DGVSummary.Columns("SortOrder").Visible = False
    '    End If

    '    ' Format Quantity
    '    If DGVSummary.Columns.Contains("Quantity") Then
    '        DGVSummary.Columns("Quantity").DefaultCellStyle.Format = "N0"
    '        DGVSummary.Columns("Quantity").DefaultCellStyle.Alignment =
    '        DataGridViewContentAlignment.MiddleRight
    '    End If

    '    ' Tô màu theo GroupName
    '    For Each r As DataGridViewRow In DGVSummary.Rows
    '        If r.IsNewRow Then Continue For

    '        Dim g As String = Convert.ToString(r.Cells("GroupName").Value)

    '        Select Case g
    '            Case "OLD DATE CODE"
    '                r.DefaultCellStyle.BackColor = Color.LightYellow

    '            Case "NEW DATE CODE"
    '                r.DefaultCellStyle.BackColor = Color.AliceBlue

    '            Case "TOTAL QUANTITY"
    '                r.DefaultCellStyle.BackColor = Color.LightSteelBlue
    '                r.DefaultCellStyle.Font = New Font(DGVSummary.Font, FontStyle.Bold)
    '        End Select
    '    Next
    'End Sub

    ''--------------------------------2/2/2026----------------------------------- start 
    Public Sub RunFIFO(ByVal component As String,
                   ByVal ugpn As String,
                   ByVal dateFrom As Nullable(Of Date),
                   ByVal dateTo As Nullable(Of Date),
                   Optional ByVal clickType As String = "NONE",
                   Optional ByVal clickValue As String = Nothing)

        Dim ds As New DataSet()

        Using cn As SqlConnection = Datalayer.GetConnection(),
          cmd As New SqlCommand("dbo.p_FIFO_Search_AllInOne", cn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 60

            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(component), CType(DBNull.Value, Object), component.Trim())

            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())

            cmd.Parameters.Add("@DateRevcFrom", SqlDbType.Date).Value =
            If(dateFrom.HasValue, CType(dateFrom.Value.Date, Object), DBNull.Value)

            cmd.Parameters.Add("@DateRevcTo", SqlDbType.Date).Value =
            If(dateTo.HasValue, CType(dateTo.Value.Date, Object), DBNull.Value)

            cmd.Parameters.Add("@ClickType", SqlDbType.NVarChar, 20).Value =
            If(String.IsNullOrWhiteSpace(clickType), "NONE", clickType.Trim().ToUpper())

            cmd.Parameters.Add("@ClickValue", SqlDbType.NVarChar, 100).Value =
            If(String.IsNullOrWhiteSpace(clickValue), CType(DBNull.Value, Object), clickValue.Trim())

            Using da As New SqlDataAdapter(cmd)
                da.Fill(ds)
            End Using
        End Using

        If ds.Tables.Count < 6 Then
            MessageBox.Show("SP p_FIFO_Search_AllInOne phải trả 6 tables.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' (0) Detail main
        DGRFIFO.AutoGenerateColumns = True
        DGRFIFO.DataSource = ds.Tables(0)

        ' (1) Summary DateCode
        DGVSummary.AutoGenerateColumns = True
        DGVSummary.DataSource = ds.Tables(1)
        ApplySummaryDateCodeFormat()

        ' ====== (2) Summary User (HIỂN THỊ VÙNG USER) ======
        DGVUser.AutoGenerateColumns = True
        DGVUser.DataSource = ds.Tables(2)
        ApplyUserAreaFormat(DGVUser, qtyCol:="TotalOriginQty")

        ' ====== (3) Summary Area (HIỂN THỊ VÙNG AREA) ======
        DGVArea.AutoGenerateColumns = True
        DGVArea.DataSource = ds.Tables(3)
        ApplyUserAreaFormat(DGVArea, qtyCol:="TotalOriginQty")

        ' (4) Drilldown detail ( đang dùng DGVDetail)
        DGVDetail.AutoGenerateColumns = True
        DGVDetail.DataSource = ds.Tables(4)
        UpdateTotalOriginQty_DGVDetail()
        ' (5) Totals
        Dim totalRecords As Integer = 0
        Dim totalQty As Long = 0

        If ds.Tables(5).Rows.Count > 0 Then
            totalRecords = Convert.ToInt32(ds.Tables(5).Rows(0)("TotalRecords"))
            totalQty = Convert.ToInt64(ds.Tables(5).Rows(0)("TotalOriginQty"))
        End If

        lbltotal.Text = "Total Records: " & totalRecords.ToString()

        ' Label to Total QTY (anh có lbltotalOriginQty to)
        lbltotalOriginQty.Text = "Total QTY: " & totalQty.ToString("N0")

        dsComponent = ds
    End Sub
    Private Sub UpdateTotalOriginQty_DGVDetail()
        Try
            Dim dt As DataTable = TryCast(DGVDetail.DataSource, DataTable)
            If dt Is Nothing OrElse dt.Rows.Count = 0 OrElse Not dt.Columns.Contains("OriginQty") Then
                lbltotalOriginBy.Text = "Total QTY: 0"
                Exit Sub
            End If

            Dim total As Long = 0

            For Each r As DataRow In dt.Rows
                If r.RowState = DataRowState.Deleted Then Continue For
                Dim v As Object = r("OriginQty")
                If v Is Nothing OrElse v Is DBNull.Value Then Continue For

                ' handle numeric + string numeric
                Dim n As Long
                If Long.TryParse(v.ToString().Trim(), n) Then
                    total += n
                Else
                    ' nếu có dạng thập phân
                    Dim d As Decimal
                    If Decimal.TryParse(v.ToString().Trim(), d) Then
                        total += CLng(Math.Truncate(d))
                    End If
                End If
            Next

            lbltotalOriginBy.Text = "Total QTY: " & total.ToString("N0")
        Catch ex As Exception
            ' Nếu muốn log thì log, còn không thì hiển thị tối thiểu
            lbltotalOriginBy.Text = "Total QTY: N/A"
        End Try
    End Sub

    Private Sub ApplyUserAreaFormat(ByVal dgv As DataGridView, ByVal qtyCol As String)
        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub

        ' Format số lượng
        If dgv.Columns.Contains(qtyCol) Then
            dgv.Columns(qtyCol).DefaultCellStyle.Format = "N0"
            dgv.Columns(qtyCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        ' (Tuỳ chọn) Hide cột ngày nếu  không cần
        'If dgv.Columns.Contains("FirstDateRevc") Then dgv.Columns("FirstDateRevc").DefaultCellStyle.Format = "MM/dd/yyyy"
        'If dgv.Columns.Contains("LastDateRevc") Then dgv.Columns("LastDateRevc").DefaultCellStyle.Format = "MM/dd/yyyy"

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub DGVUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUser.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim u As String = Convert.ToString(DGVUser.Rows(e.RowIndex).Cells("UserName").Value)
        If String.IsNullOrWhiteSpace(u) Then Exit Sub
        RunFIFO(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim(), GetFromDate(), GetToDate(), "USER", u)
    End Sub

    Private Sub DGVArea_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVArea.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim a As String = Convert.ToString(DGVArea.Rows(e.RowIndex).Cells("Area").Value)
        If String.IsNullOrWhiteSpace(a) Then Exit Sub
        RunFIFO(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim(), GetFromDate(), GetToDate(), "AREA", a)
    End Sub

    Private Function GetFromDate() As Nullable(Of Date)
        If chkFrom.Checked AndAlso chkTo.Checked Then Return dtpFrom.Value.Date
        Return Nothing
    End Function

    Private Function GetToDate() As Nullable(Of Date)
        If chkFrom.Checked AndAlso chkTo.Checked Then Return dtpTo.Value.Date
        Return Nothing
    End Function

    'Public Sub RunFIFO(ByVal component As String,
    '               ByVal ugpn As String,
    '               ByVal dateFrom As Nullable(Of Date),
    '               ByVal dateTo As Nullable(Of Date),
    '               Optional ByVal clickType As String = "NONE",
    '               Optional ByVal clickValue As String = Nothing)

    '    Dim ds As New DataSet()

    '    Using cn As SqlConnection = Datalayer.GetConnection(),
    '      cmd As New SqlCommand("dbo.p_FIFO_Search_AllInOne", cn)

    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandTimeout = 60

    '        cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
    '        If(String.IsNullOrWhiteSpace(component), CType(DBNull.Value, Object), component.Trim())

    '        cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
    '        If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())

    '        cmd.Parameters.Add("@DateRevcFrom", SqlDbType.Date).Value =
    '        If(dateFrom.HasValue, CType(dateFrom.Value.Date, Object), DBNull.Value)

    '        cmd.Parameters.Add("@DateRevcTo", SqlDbType.Date).Value =
    '        If(dateTo.HasValue, CType(dateTo.Value.Date, Object), DBNull.Value)

    '        cmd.Parameters.Add("@ClickType", SqlDbType.NVarChar, 20).Value =
    '        If(String.IsNullOrWhiteSpace(clickType), "NONE", clickType.Trim().ToUpper())

    '        cmd.Parameters.Add("@ClickValue", SqlDbType.NVarChar, 100).Value =
    '        If(String.IsNullOrWhiteSpace(clickValue), CType(DBNull.Value, Object), clickValue.Trim())

    '        Using da As New SqlDataAdapter(cmd)
    '            da.Fill(ds)
    '        End Using
    '    End Using

    '    If ds.Tables.Count < 6 Then
    '        MessageBox.Show("SP p_FIFO_Search_AllInOne phải trả 6 tables.", "Error",
    '                    MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If

    '    ' (0) Detail main
    '    DGRFIFO.AutoGenerateColumns = True
    '    DGRFIFO.DataSource = ds.Tables(0)

    '    ' (1) Summary DateCode
    '    DGVSummary.AutoGenerateColumns = True
    '    DGVSummary.DataSource = ds.Tables(1)
    '    ApplySummaryDateCodeFormat()

    '    ' (4) Drilldown detail
    '    DGVDetail.AutoGenerateColumns = True
    '    DGVDetail.DataSource = ds.Tables(4)

    '    ' (5) Totals
    '    Dim totalRecords As Integer = 0
    '    Dim totalQty As Long = 0

    '    If ds.Tables(5).Rows.Count > 0 Then
    '        totalRecords = Convert.ToInt32(ds.Tables(5).Rows(0)("TotalRecords"))
    '        totalQty = Convert.ToInt64(ds.Tables(5).Rows(0)("TotalOriginQty"))
    '    End If

    '    lbltotal.Text = "Total Records: " & totalRecords.ToString() &
    '                " | Total Qty(OriginQty): " & totalQty.ToString("N0")

    '    ' Giữ dataset nếu anh cần dùng lại
    '    dsComponent = ds
    'End Sub

    Private Sub ApplySummaryDateCodeFormat()

        If DGVSummary.Columns.Contains("SortOrder") Then
            DGVSummary.Columns("SortOrder").Visible = False
        End If

        If DGVSummary.Columns.Contains("Quantity") Then
            DGVSummary.Columns("Quantity").DefaultCellStyle.Format = "N0"
            DGVSummary.Columns("Quantity").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
        End If

        For Each r As DataGridViewRow In DGVSummary.Rows
            If r.IsNewRow Then Continue For
            Dim g As String = Convert.ToString(r.Cells("GroupName").Value)

            Select Case g
                Case "OLD DATE CODE"
                    r.DefaultCellStyle.BackColor = Color.LightYellow
                Case "NEW DATE CODE"
                    r.DefaultCellStyle.BackColor = Color.AliceBlue
                Case "TOTAL QUANTITY"
                    r.DefaultCellStyle.BackColor = Color.LightSteelBlue
                    r.DefaultCellStyle.Font = New Font(DGVSummary.Font, FontStyle.Bold)
            End Select
        Next
    End Sub


    '2/2/2026----------------------------------- end-----------------------------

    Private Sub tbnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSearch.Click

        DGVDetail.DataSource = Nothing
        DGVDetail.Rows.Clear()

        Dim fromDate As Nullable(Of Date) = Nothing
        Dim toDate As Nullable(Of Date) = Nothing

        If chkFrom.Checked AndAlso chkTo.Checked Then
            If dtpFrom.Value.Date > dtpTo.Value.Date Then
                MessageBox.Show("From date must be <= To date.", "Invalid date range",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            fromDate = dtpFrom.Value.Date
            toDate = dtpTo.Value.Date
        End If

        RunFIFO(txtComponentID.Text.Trim(),
                txtUGPN_.Text.Trim(),
                fromDate,
                toDate,
                clickType:="NONE",
                clickValue:=Nothing)

        ''''''''' Clear Grid 2 (detail theo DateCode click)
        ''''''''DGVDetail.DataSource = Nothing
        ''''''''DGVDetail.Rows.Clear()

        ''''''''Dim fromDate As Nullable(Of Date) = Nothing
        ''''''''Dim toDate As Nullable(Of Date) = Nothing

        ''''''''' CHỈ khi CẢ HAI checkbox đều được check mới áp điều kiện DateRevc
        ''''''''If chkFrom.Checked AndAlso chkTo.Checked Then
        ''''''''    If dtpFrom.Value.Date > dtpTo.Value.Date Then
        ''''''''        MessageBox.Show("From date must be <= To date.", "Invalid date range",
        ''''''''                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ''''''''        Exit Sub
        ''''''''    End If
        ''''''''    fromDate = dtpFrom.Value.Date
        ''''''''    toDate = dtpTo.Value.Date
        ''''''''End If


        ''''''''searchFIFO(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim(), fromDate, toDate)
        ''''''''SearchFIFO_Summary(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim())
        ''''''''' searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
    End Sub
    Private Sub DGRFIFO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRFIFO.CellClick
        ' Bỏ qua click header hoặc vùng ngoài row
        If e.RowIndex < 0 Then Exit Sub

        Dim row = DGRFIFO.Rows(e.RowIndex)

        txtComponent_ID.Text = GetCellText(row, 0) ' ComponentID
        txtUGPN.Text = GetCellText(row, 1) ' UGPN
        txtDateCode.Text = GetCellText(row, 4) ' DateCode
        txtLoc.Text = GetCellText(row, 9) ' StorageLoc
    End Sub

    Private Function GetCellText(row As DataGridViewRow, colIndex As Integer) As String
        If row Is Nothing OrElse colIndex < 0 OrElse colIndex >= row.Cells.Count Then Return ""

        Dim v = row.Cells(colIndex).Value
        If v Is Nothing OrElse Convert.IsDBNull(v) Then Return ""

        Return v.ToString().Trim()
    End Function


    Private Sub txtUGPN__KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUGPN_.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then


            Dim fromDate As Nullable(Of Date) = Nothing
            Dim toDate As Nullable(Of Date) = Nothing

            ' CHỈ khi CẢ HAI checkbox đều được check mới áp điều kiện DateRevc
            If chkFrom.Checked AndAlso chkTo.Checked Then
                If dtpFrom.Value.Date > dtpTo.Value.Date Then
                    MessageBox.Show("From date must be <= To date.", "Invalid date range",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                fromDate = dtpFrom.Value.Date
                toDate = dtpTo.Value.Date
            End If


            searchFIFO(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim(), fromDate, toDate)
            'searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
        End If
    End Sub

    Private Sub txtUGPN__TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUGPN_.TextChanged

        Dim fromDate As Nullable(Of Date) = Nothing
        Dim toDate As Nullable(Of Date) = Nothing

        ' CHỈ khi CẢ HAI checkbox đều được check mới áp điều kiện DateRevc
        If chkFrom.Checked AndAlso chkTo.Checked Then
            If dtpFrom.Value.Date > dtpTo.Value.Date Then
                MessageBox.Show("From date must be <= To date.", "Invalid date range",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            fromDate = dtpFrom.Value.Date
            toDate = dtpTo.Value.Date
        End If


        searchFIFO(txtComponentID.Text.Trim(), txtUGPN_.Text.Trim(), fromDate, toDate)
        'searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
    End Sub
    Public Function UpdateStorageLoc(componentId As String, ugpn As String, storageLoc As String, userName As String) As Integer
        Dim ToDbNull As Func(Of String, Object) =
        Function(s As String) If(String.IsNullOrWhiteSpace(s), DBNull.Value, CType(s.Trim(), Object))

        Using cn As SqlConnection = Datalayer.GetConnection()
            Using cmd As New SqlCommand("dbo.p_UpdateStorageLoc_ByUGPN_ComponentID", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 60

                cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value = ToDbNull(componentId)
                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 50).Value = ToDbNull(ugpn)
                cmd.Parameters.Add("@StorageLoc", SqlDbType.NVarChar, 100).Value =
                If(String.IsNullOrWhiteSpace(storageLoc), CType(DBNull.Value, Object), storageLoc.Trim())

                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = ToDbNull(userName)

                ' optional
                cmd.Parameters.Add("@Reason", SqlDbType.NVarChar, 200).Value =
                CType("Update StorageLoc by user action", Object)

                cn.Open()
                Dim obj As Object = cmd.ExecuteScalar()
                Return If(obj Is Nothing OrElse obj Is DBNull.Value, 0, Convert.ToInt32(obj))
            End Using
        End Using
    End Function


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Try
            If MessageBox.Show("Bạn có muốn UPDATE không?", "Confirm UPDATE",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Try ' hoặc Exit Sub nếu đang ở trong event handler
            End If

            Dim compId As String = txtComponentID.Text
            Dim ugpn As String = txtUGPN.Text
            Dim loc As String = txtLoc.Text
            Dim user As String = Datalayer.LoginName

            Dim n As Integer = UpdateStorageLoc(compId, ugpn, loc, user)
            MessageBox.Show($"Updated: {n} row(s).", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ClearSearchForm()
        ' 1) Clear input text
        txtComponentID.Clear()
        txtUGPN_.Clear()
        txtDateCode.Clear()
        txtLoc.Clear()
        dtpFrom.Value = Date.Today
        dtpTo.Value = Date.Today
        txtComponent_ID.Clear()
        txtUGPN.Clear()

        If DGRFIFO.DataSource IsNot Nothing Then
            DGRFIFO.DataSource = Nothing
        End If
        DGRFIFO.Rows.Clear()
        DGRFIFO.Refresh()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearSearchForm()
    End Sub
    Private Sub LoadDetailByDateCode(ByVal componentID As String, ByVal ugpn As String, ByVal dateCode As String)
        Dim dt As New DataTable()

        Using cn As SqlConnection = Datalayer.GetConnection,
          cmd As New SqlCommand("p_CheckFIFO_ByDateCode_Detail", cn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 60

            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
            If(String.IsNullOrWhiteSpace(componentID), CType(DBNull.Value, Object), componentID.Trim())

            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
            If(String.IsNullOrWhiteSpace(ugpn), CType(DBNull.Value, Object), ugpn.Trim())

            cmd.Parameters.Add("@DateCode", SqlDbType.NVarChar, 50).Value = dateCode.Trim()

            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DGVDetail.AutoGenerateColumns = True
        DGVDetail.DataSource = dt
    End Sub
    Private Sub DGVSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles DGVSummary.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub
        If Not DGVSummary.Columns.Contains("DateCode") Then Exit Sub

        Dim dc As String = Convert.ToString(DGVSummary.Rows(e.RowIndex).Cells("DateCode").Value)
        If String.IsNullOrWhiteSpace(dc) Then Exit Sub ' dòng TOTAL QUANTITY

        Dim fromDate As Nullable(Of Date) = Nothing
        Dim toDate As Nullable(Of Date) = Nothing

        If chkFrom.Checked AndAlso chkTo.Checked Then
            fromDate = dtpFrom.Value.Date
            toDate = dtpTo.Value.Date
        End If

        RunFIFO(txtComponentID.Text.Trim(),
            txtUGPN_.Text.Trim(),
            fromDate,
            toDate,
            clickType:="DATECODE",
            clickValue:=dc)
    End Sub

    Private Sub DGVSummary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSummary.CellClick
        'If e.RowIndex < 0 Then Return ' click header

        'Dim row As DataGridViewRow = DGVSummary.Rows(e.RowIndex)

        '' Bỏ qua dòng không có DateCode (TOTAL)
        'Dim dateCodeObj As Object = row.Cells("DateCode").Value
        'If dateCodeObj Is Nothing OrElse dateCodeObj Is DBNull.Value Then Return

        'Dim dateCode As String = Convert.ToString(dateCodeObj).Trim()
        'If dateCode = "" Then Return

        '' Highlight dòng được chọn
        'DGVSummary.ClearSelection()
        'row.Selected = True

        '' Lấy điều kiện tìm kiếm hiện tại
        'Dim componentID As String = txtComponentID.Text.Trim()
        'Dim ugpn As String = txtUGPN_.Text.Trim()

        '' Đổ Grid 2
        'LoadDetailByDateCode(componentID, ugpn, dateCode)
    End Sub
    Private Sub ExportToExcel(dataGridView As DataGridView, filePath As String)
        ' Create a DataTable and fill it from DataGridView
        Dim dt As New DataTable()

        ' Add columns
        For Each column As DataGridViewColumn In dataGridView.Columns
            dt.Columns.Add(column.HeaderText)
        Next

        ' Add rows
        For Each row As DataGridViewRow In dataGridView.Rows
            If Not row.IsNewRow Then
                Dim dr As DataRow = dt.NewRow()
                For i As Integer = 0 To dataGridView.Columns.Count - 1
                    Dim cellVal = row.Cells(i).Value
                    dr(i) = If(cellVal IsNot Nothing, cellVal.ToString(), "")
                Next
                dt.Rows.Add(dr)
            End If
        Next

        ' Export to Excel
        Using workbook As New XLWorkbook()
            workbook.Worksheets.Add(dt, "Sheet1")
            workbook.SaveAs(filePath)
        End Using

        MessageBox.Show("Export completed successfully.",
                    "Export to Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using sfd As New SaveFileDialog() With {
       .Filter = "Excel Workbook (*.xlsx)|*.xlsx",
       .FileName = $"File_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
       .DefaultExt = "xlsx",
       .AddExtension = True,
       .RestoreDirectory = True}
            If sfd.ShowDialog() = DialogResult.OK Then
                ExportToExcel(DGRFIFO, sfd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Using sfd As New SaveFileDialog() With {
      .Filter = "Excel Workbook (*.xlsx)|*.xlsx",
      .FileName = $"File_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
      .DefaultExt = "xlsx",
      .AddExtension = True,
      .RestoreDirectory = True}
            If sfd.ShowDialog() = DialogResult.OK Then
                ExportToExcel(DGVDetail, sfd.FileName)
            End If
        End Using
    End Sub

    Private Sub RecalcDateExpire(ByVal componentID As String, ByVal ugpn As String)
        ' ===== 1) Chuẩn hoá input =====
        Dim comp As String = If(String.IsNullOrWhiteSpace(componentID), Nothing, componentID.Trim())
        Dim u As String = If(String.IsNullOrWhiteSpace(ugpn), Nothing, ugpn.Trim())

        If comp Is Nothing AndAlso u Is Nothing Then
            MessageBox.Show("Vui lòng nhập ComponentID hoặc UGPN.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ===== 2) Xác nhận =====
        Dim warnMsg As String =
        "Bạn sắp cập nhật lại DateExpire." & Environment.NewLine &
        "Thao tác này sẽ:" & Environment.NewLine &
        "- Tính lại Ex_DateCode / DateExpire" & Environment.NewLine &
        "- Ghi LOG lịch sử" & Environment.NewLine &
        "- Có transaction (có thể rollback nếu lỗi)" & Environment.NewLine & Environment.NewLine &
        $"ComponentID: {If(comp, "(Không nhập)")}" & Environment.NewLine &
        $"UGPN: {If(u, "(Không nhập)")}" & Environment.NewLine & Environment.NewLine &
        "Bạn có chắc chắn muốn tiếp tục?"

        If MessageBox.Show(warnMsg,
                       "Confirm Update DateExpire",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Exit Sub
        End If

        ' ===== 3) Gọi SP và lấy RowsUpdated =====
        Dim rowsUpdated As Integer = 0

        Try
            Using cn As SqlConnection = Datalayer.GetConnection(),
              cmd As New SqlCommand("p_Recalc_DateExpire_WH", cn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 300

                cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar, 50).Value =
                If(comp Is Nothing, CType(DBNull.Value, Object), comp)

                cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar, 40).Value =
                If(u Is Nothing, CType(DBNull.Value, Object), u)

                ' Audit user: ưu tiên user trong app nếu có
                Dim updateBy As String = Environment.UserName
                ' Nếu anh có lblUser:
                ' updateBy = If(String.IsNullOrWhiteSpace(lblUser.Text), Environment.UserName, lblUser.Text.Trim())

                cmd.Parameters.Add("@UpdateBy", SqlDbType.NVarChar, 50).Value = updateBy

                cmd.Parameters.Add("@Reason", SqlDbType.NVarChar, 200).Value =
                "Recalculate DateExpire by manual request"

                cn.Open()

                ' SP có SELECT RowsUpdated cuối cùng -> dùng ExecuteScalar để lấy đúng số dòng update
                Dim obj As Object = cmd.ExecuteScalar()
                cn.Close()

                rowsUpdated = If(obj Is Nothing OrElse obj Is DBNull.Value, 0, Convert.ToInt32(obj))
            End Using

            MessageBox.Show("Cập nhật DateExpire hoàn tất." & Environment.NewLine &
                        $"Số dòng cập nhật: {rowsUpdated}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            ' ===== 4) (Tuỳ chọn) Refresh lại grid sau khi update =====
            ' Nếu anh muốn tự reload:
            ' btnSearch.PerformClick()

        Catch ex As SqlException
            MessageBox.Show("Lỗi SQL khi cập nhật DateExpire:" & Environment.NewLine & ex.Message,
                        "SQL Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Lỗi hệ thống:" & Environment.NewLine & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateExpiredete_Click(sender As Object, e As EventArgs) Handles btnUpdateExpiredete.Click
        RecalcDateExpire(txtComponentID.Text, txtUGPN_.Text)
    End Sub
End Class