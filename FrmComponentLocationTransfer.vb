Imports ClosedXML.Excel
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Public Class FrmComponentLocationTransfer
    Private ReadOnly _repository As New ComponentRepository()
    Private ReadOnly _items As New List(Of ComponentItem)()
    Private _ugpnValidated As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtComponentId.Enabled = False
        btnAdd.Enabled = False
        btnImportExcel.Enabled = False
        txtUgpn.Text = "UBL-24A-100123"
        txtNewLocation.Text = "WH-A01-R05-S02"
        txtUgpn.SelectAll()
        txtUgpn.Focus()
    End Sub

    Private Sub btnCheckUgpn_Click(sender As Object, e As EventArgs) Handles btnCheckUgpn.Click
        Dim ugpn As String = txtUgpn.Text.Trim()
        If ugpn = String.Empty Then
            MessageBox.Show("Vui lòng nhập UGPN.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUgpn.Focus()
            Return
        End If

        Try
            _ugpnValidated = _repository.UgpnExists(ugpn)
        Catch ex As Exception
            MessageBox.Show(
                "Không thể kiểm tra UGPN trên database:" & Environment.NewLine & ex.Message,
                "Lỗi kết nối database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return
        End Try
        If Not _ugpnValidated Then
            txtUgpn.BackColor = Color.MistyRose
            MessageBox.Show("UGPN không tồn tại trong database.", "UGPN không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        txtUgpn.BackColor = Color.Honeydew
        txtUgpn.ReadOnly = True
        btnCheckUgpn.Enabled = False
        txtComponentId.Enabled = True
        btnAdd.Enabled = True
        btnImportExcel.Enabled = True
        txtComponentId.Focus()
        UpdateSummary()
    End Sub

    Private Sub txtUgpn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUgpn.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnCheckUgpn.PerformClick()
        End If
    End Sub

    Private Sub txtComponentId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComponentId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ProcessComponentInput()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ProcessComponentInput()
    End Sub

    ''' <summary>
    ''' Xử lý một Component ID hoặc danh sách được copy từ Excel/Notepad.
    ''' Mỗi dòng, tab, dấu phẩy hoặc dấu chấm phẩy được hiểu là một mã riêng.
    ''' </summary>
    Private Sub ProcessComponentInput()
        Dim rawInput As String = txtComponentId.Text

        If String.IsNullOrWhiteSpace(rawInput) Then
            txtComponentId.Focus()
            Return
        End If

        Dim componentIds As String() = rawInput.Split(
            New Char() {
                ControlChars.Cr,
                ControlChars.Lf,
                ControlChars.Tab,
                " "c,
                ","c,
                ";"c
            },
            StringSplitOptions.RemoveEmptyEntries)

        For Each componentId As String In componentIds
            Dim normalizedId As String = componentId.Trim()
            If normalizedId <> String.Empty Then
                AddComponent(normalizedId)
            End If
        Next

        txtComponentId.Clear()
        txtComponentId.Focus()
    End Sub

    Private Sub AddComponent(rawComponentId As String)
        Dim componentId As String = rawComponentId.Trim().ToUpperInvariant()
        If componentId = String.Empty Then Return

        Dim duplicate As ComponentItem = _items.FirstOrDefault(
            Function(x) x.ComponentId.Equals(componentId, StringComparison.OrdinalIgnoreCase))
        If duplicate IsNot Nothing Then
            AddResult(New ComponentItem With {
                .ComponentId = componentId,
                .Ugpn = duplicate.Ugpn,
                .CurrentLocation = duplicate.CurrentLocation,
                .Quantity = duplicate.Quantity,
                .Status = ComponentCheckStatus.Duplicate,
                .StatusText = "Trùng lặp",
                .Detail = "Component ID đã có trong danh sách"
            })
            Return
        End If

        Dim item As ComponentItem
        Try
            item = _repository.FindByComponentId(componentId)
        Catch ex As Exception
            MessageBox.Show(
                "Không thể lấy thông tin Component ID từ database:" & Environment.NewLine & ex.Message,
                "Lỗi kết nối database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return
        End Try
        If item Is Nothing Then
            item = New ComponentItem With {
                .ComponentId = componentId,
                .Ugpn = "N/A",
                .CurrentLocation = "N/A",
                .Quantity = 0D,
                .Status = ComponentCheckStatus.NotFound,
                .StatusText = "Không tìm thấy",
                .Detail = "Component ID không tồn tại trong DB"
            }
        ElseIf item.Quantity <= 0D Then
            item.Status = ComponentCheckStatus.InvalidQuantity
            item.StatusText = "Qty không hợp lệ"
            item.Detail = "Qty phải lớn hơn 0"
        ElseIf Not item.Ugpn.Equals(txtUgpn.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
            item.Status = ComponentCheckStatus.WrongUgpn
            item.StatusText = "Sai UGPN"
            item.Detail = $"UGPN khai báo: {txtUgpn.Text.Trim()}"
        Else
            item.Status = ComponentCheckStatus.Valid
            item.StatusText = "Hợp lệ"
            item.Detail = "Dữ liệu khớp"
        End If

        AddResult(item)
    End Sub

    Private Sub AddResult(item As ComponentItem)
        item.Sequence = _items.Count + 1
        _items.Add(item)
        Dim index As Integer = dgvComponents.Rows.Add(
            item.Sequence,
            item.ComponentId,
            item.Ugpn,
            item.CurrentLocation,
            item.Quantity.ToString("N0"),
            item.StatusText,
            item.Detail)
        ApplyRowStyle(dgvComponents.Rows(index), item.Status)
        dgvComponents.FirstDisplayedScrollingRowIndex = index
        UpdateSummary()
    End Sub

    Private Shared Sub ApplyRowStyle(row As DataGridViewRow, status As ComponentCheckStatus)
        Select Case status
            Case ComponentCheckStatus.Valid
                row.DefaultCellStyle.BackColor = Color.FromArgb(238, 249, 234)
                row.Cells("colStatus").Style.ForeColor = Color.Green
            Case ComponentCheckStatus.WrongUgpn
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 218)
                row.Cells("colStatus").Style.ForeColor = Color.FromArgb(220, 100, 0)
            Case ComponentCheckStatus.NotFound, ComponentCheckStatus.InvalidQuantity
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 232, 232)
                row.Cells("colStatus").Style.ForeColor = Color.Red
            Case ComponentCheckStatus.Duplicate
                row.DefaultCellStyle.BackColor = Color.FromArgb(244, 235, 250)
                row.Cells("colStatus").Style.ForeColor = Color.Purple
        End Select
        row.Cells("colStatus").Style.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
    End Sub

    Private Sub UpdateSummary()
        Dim validCount As Integer = _items.Where(
            Function(x) x.Status = ComponentCheckStatus.Valid).Count()
        Dim invalidCount As Integer = _items.Count - validCount
        Dim totalQty As Decimal = _items.Where(Function(x) x.Status = ComponentCheckStatus.Valid).Sum(Function(x) x.Quantity)

        lblTotalComponents.Text = $"Tổng Component:  {_items.Count:N0}"
        lblValid.Text = $"Hợp lệ:  {validCount:N0}"
        lblInvalid.Text = $"Lỗi:  {invalidCount:N0}"
        lblTotalQty.Text = $"Tổng Qty hợp lệ:  {totalQty:N0}"

        Dim ready As Boolean = _ugpnValidated AndAlso _items.Count > 0 AndAlso invalidCount = 0 AndAlso txtNewLocation.Text.Trim() <> String.Empty
        btnTransfer.Enabled = ready
        If _items.Count = 0 Then
            lblQtyStatus.Text = "CHƯA CÓ DỮ LIỆU"
            lblQtyStatus.ForeColor = Color.Red
            lblQtyStatus.BackColor = Color.FromArgb(255, 235, 235)
        ElseIf invalidCount > 0 Then
            lblQtyStatus.Text = "DANH SÁCH CÓ LỖI"
            lblQtyStatus.ForeColor = Color.Red
            lblQtyStatus.BackColor = Color.FromArgb(255, 235, 235)
        Else
            lblQtyStatus.Text = "SẴN SÀNG CHUYỂN"
            lblQtyStatus.ForeColor = Color.Green
            lblQtyStatus.BackColor = Color.FromArgb(232, 250, 232)
        End If
    End Sub

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        Dim indexes As List(Of Integer) = dgvComponents.SelectedRows.
            Cast(Of DataGridViewRow)().
            Select(Function(row) row.Index).
            OrderByDescending(Function(index) index).
            ToList()

        For Each index As Integer In indexes
            _items.RemoveAt(index)
            dgvComponents.Rows.RemoveAt(index)
        Next
        RebuildSequence()
        UpdateSummary()
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        If _items.Count = 0 Then Return
        If MessageBox.Show("Xóa toàn bộ danh sách Component ID?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        _items.Clear()
        dgvComponents.Rows.Clear()
        UpdateSummary()
        txtComponentId.Focus()
    End Sub

    Private Sub RebuildSequence()
        For i As Integer = 0 To _items.Count - 1
            _items(i).Sequence = i + 1
            dgvComponents.Rows(i).Cells("colStt").Value = i + 1
        Next
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Using dialog As New OpenFileDialog With {
            .Title = "Chọn file danh sách Component ID",
            .Filter = "Excel Workbook (*.xlsx)|*.xlsx"
        }
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            Try
                Using workbook As New XLWorkbook(dialog.FileName)
                    Dim sheet As IXLWorksheet = workbook.Worksheets.First()
                    Dim headerCell As IXLCell = sheet.CellsUsed().FirstOrDefault(
                        Function(cell) NormalizeHeader(cell.GetString()) = "COMPONENTID")

                    If headerCell Is Nothing Then
                        Throw New InvalidDataException(
                            "Không tìm thấy cột ComponentID. Vui lòng sử dụng file mẫu của chương trình.")
                    End If

                    Dim lastRow As IXLRow = sheet.LastRowUsed()
                    If lastRow Is Nothing Then Return

                    For rowNumber As Integer = headerCell.Address.RowNumber + 1 To lastRow.RowNumber()
                        Dim value As String = sheet.Cell(rowNumber, headerCell.Address.ColumnNumber).GetString().Trim()
                        If value <> String.Empty Then
                            AddComponent(value)
                        End If
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Không thể đọc file Excel:" & Environment.NewLine & ex.Message, "Import thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        txtComponentId.Focus()
    End Sub

    Private Shared Function NormalizeHeader(value As String) As String
        Return value.Trim().Replace(" ", String.Empty).Replace("_", String.Empty).ToUpperInvariant()
    End Function

    Private Sub btnDownloadTemplate_Click(sender As Object, e As EventArgs) Handles btnDownloadTemplate.Click
        Using dialog As New SaveFileDialog With {
            .Title = "Lưu file mẫu Import Component ID",
            .Filter = "Excel Workbook (*.xlsx)|*.xlsx",
            .FileName = "ComponentID_Import_Template.xlsx",
            .AddExtension = True,
            .DefaultExt = "xlsx",
            .OverwritePrompt = True
        }
            If dialog.ShowDialog() <> DialogResult.OK Then Return

            Try
                Dim templatePath As String = Path.Combine(
                    AppContext.BaseDirectory,
                    "Templates",
                    "ComponentID_Import_Template.xlsx")

                If Not File.Exists(templatePath) Then
                    Throw New FileNotFoundException(
                        "Không tìm thấy file mẫu được đóng gói cùng chương trình.",
                        templatePath)
                End If

                File.Copy(templatePath, dialog.FileName, True)
                MessageBox.Show(
                    "Đã tạo file mẫu thành công:" & Environment.NewLine & dialog.FileName,
                    "Tải file mẫu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(
                    "Không thể tạo file mẫu:" & Environment.NewLine & ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub txtNewLocation_TextChanged(sender As Object, e As EventArgs) Handles txtNewLocation.TextChanged
        UpdateSummary()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        'Không chỉ dựa vào trạng thái Enabled của button. Luôn kiểm tra lại
        'dữ liệu ngay trước khi gọi stored procedure.
        If Not ValidateBeforeTransfer() Then Return

        If MessageBox.Show($"Chuyển {_items.Count:N0} Component ID sang location {txtNewLocation.Text.Trim()}?", "Xác nhận chuyển Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            Dim result As TransferResult = _repository.SaveHistoryAndTransfer(
                _items,
                txtUgpn.Text.Trim(),
                txtNewLocation.Text.Trim(),
                Environment.UserName)

            MessageBox.Show(
                $"Đã lưu lịch sử và chuyển Location thành công.{Environment.NewLine}" &
                $"Transaction ID: {result.TransactionId}{Environment.NewLine}" &
                $"Số Component: {result.TransferredCount:N0}{Environment.NewLine}" &
                $"Tổng OriginQty: {result.TotalQuantity:N0}{Environment.NewLine}" &
                $"Location mới: {result.NewLocation}",
                "Hoàn tất",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            ResetFormAfterTransfer()
        Catch ex As Exception
            MessageBox.Show("Giao dịch thất bại. Dữ liệu đã được rollback." & Environment.NewLine & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateBeforeTransfer() As Boolean
        If Not _ugpnValidated Then
            MessageBox.Show(
                "UGPN chưa được kiểm tra hoặc không hợp lệ.",
                "Không thể chuyển Location",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            txtUgpn.Focus()
            Return False
        End If

        If txtNewLocation.Text.Trim() = String.Empty Then
            MessageBox.Show(
                "Vui lòng nhập Location mới.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            txtNewLocation.Focus()
            Return False
        End If

        If _items.Count = 0 Then
            MessageBox.Show(
                "Danh sách Component ID đang trống.",
                "Không có dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            txtComponentId.Focus()
            Return False
        End If

        Dim invalidItems As List(Of ComponentItem) = _items.Where(
            Function(item) item.Status <> ComponentCheckStatus.Valid).ToList()

        If invalidItems.Count > 0 Then
            Dim firstInvalidIndex As Integer = _items.IndexOf(invalidItems(0))

            If firstInvalidIndex >= 0 AndAlso firstInvalidIndex < dgvComponents.Rows.Count Then
                dgvComponents.ClearSelection()
                dgvComponents.Rows(firstInvalidIndex).Selected = True
                dgvComponents.CurrentCell = dgvComponents.Rows(firstInvalidIndex).Cells("colComponentId")
                dgvComponents.FirstDisplayedScrollingRowIndex = firstInvalidIndex
            End If

            MessageBox.Show(
                $"Danh sách đang có {invalidItems.Count:N0} dòng lỗi." &
                Environment.NewLine &
                "Vui lòng xóa hoặc xử lý toàn bộ dòng sai UGPN, không tìm thấy, Qty không hợp lệ hoặc trùng lặp trước khi chuyển Location.",
                "DANH SÁCH CÓ LỖI",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub ResetFormAfterTransfer()
        _items.Clear()
        dgvComponents.Rows.Clear()
        _ugpnValidated = False
        txtUgpn.ReadOnly = False
        txtUgpn.Clear()
        txtUgpn.BackColor = Color.White
        txtNewLocation.Clear()
        txtComponentId.Clear()
        txtComponentId.Enabled = False
        txtComponentId.BackColor = Color.White
        btnAdd.Enabled = False
        btnImportExcel.Enabled = False
        btnCheckUgpn.Enabled = True
        dgvComponents.ClearSelection()
        UpdateSummary()
        txtUgpn.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
