Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComponentLocationTransfer
    Inherits Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblUgpn As Label
    Friend WithEvents txtUgpn As TextBox
    Friend WithEvents btnCheckUgpn As Button
    Friend WithEvents lblNewLocation As Label
    Friend WithEvents txtNewLocation As TextBox
    Friend WithEvents grpScan As GroupBox
    Friend WithEvents lblScan As Label
    Friend WithEvents txtComponentId As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents btnDownloadTemplate As Button
    Friend WithEvents dgvComponents As DataGridView
    Friend WithEvents colStt As DataGridViewTextBoxColumn
    Friend WithEvents colComponentId As DataGridViewTextBoxColumn
    Friend WithEvents colUgpn As DataGridViewTextBoxColumn
    Friend WithEvents colLocation As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDetail As DataGridViewTextBoxColumn
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblTotalComponents As Label
    Friend WithEvents lblValid As Label
    Friend WithEvents lblInvalid As Label
    Friend WithEvents lblTotalQty As Label
    Friend WithEvents lblQtyStatus As Label
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnDeleteRow As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnClose As Button

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim headerStyle As New DataGridViewCellStyle()
        Dim cellStyle As New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        grpInfo = New GroupBox()
        lblUgpn = New Label()
        txtUgpn = New TextBox()
        btnCheckUgpn = New Button()
        lblNewLocation = New Label()
        txtNewLocation = New TextBox()
        grpScan = New GroupBox()
        lblScan = New Label()
        txtComponentId = New TextBox()
        btnAdd = New Button()
        btnImportExcel = New Button()
        btnDownloadTemplate = New Button()
        dgvComponents = New DataGridView()
        colStt = New DataGridViewTextBoxColumn()
        colComponentId = New DataGridViewTextBoxColumn()
        colUgpn = New DataGridViewTextBoxColumn()
        colLocation = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colDetail = New DataGridViewTextBoxColumn()
        pnlSummary = New Panel()
        lblTotalComponents = New Label()
        lblValid = New Label()
        lblInvalid = New Label()
        lblTotalQty = New Label()
        lblQtyStatus = New Label()
        pnlActions = New Panel()
        btnDeleteRow = New Button()
        btnClearAll = New Button()
        btnTransfer = New Button()
        btnClose = New Button()

        pnlHeader.SuspendLayout()
        grpInfo.SuspendLayout()
        grpScan.SuspendLayout()
        CType(dgvComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlSummary.SuspendLayout()
        pnlActions.SuspendLayout()
        SuspendLayout()

        pnlHeader.BackColor = Color.FromArgb(7, 48, 93)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 72
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI", 21.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Text = "COMPONENT LOCATION TRANSFER"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        grpInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        grpInfo.Controls.AddRange(New Control() {lblUgpn, txtUgpn, btnCheckUgpn, lblNewLocation, txtNewLocation})
        grpInfo.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grpInfo.ForeColor = Color.FromArgb(7, 48, 93)
        grpInfo.Location = New Point(18, 86)
        grpInfo.Size = New Size(625, 190)
        grpInfo.Text = "  BƯỚC 1: NHẬP THÔNG TIN  "
        lblUgpn.AutoSize = True
        lblUgpn.ForeColor = Color.Black
        lblUgpn.Location = New Point(25, 38)
        lblUgpn.Text = "UGPN khai báo"
        txtUgpn.CharacterCasing = CharacterCasing.Upper
        txtUgpn.Font = New Font("Segoe UI", 13.0F)
        txtUgpn.Location = New Point(25, 66)
        txtUgpn.Size = New Size(410, 31)
        btnCheckUgpn.BackColor = Color.FromArgb(0, 102, 204)
        btnCheckUgpn.FlatStyle = FlatStyle.Flat
        btnCheckUgpn.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnCheckUgpn.ForeColor = Color.White
        btnCheckUgpn.Location = New Point(450, 64)
        btnCheckUgpn.Size = New Size(145, 38)
        btnCheckUgpn.Text = "Kiểm tra"
        lblNewLocation.AutoSize = True
        lblNewLocation.ForeColor = Color.Black
        lblNewLocation.Location = New Point(25, 112)
        lblNewLocation.Text = "Location mới"
        txtNewLocation.CharacterCasing = CharacterCasing.Upper
        txtNewLocation.Font = New Font("Segoe UI", 13.0F)
        txtNewLocation.Location = New Point(25, 140)
        txtNewLocation.Size = New Size(410, 31)

        grpScan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpScan.Controls.AddRange(New Control() {lblScan, txtComponentId, btnAdd, btnImportExcel, btnDownloadTemplate})
        grpScan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grpScan.ForeColor = Color.FromArgb(7, 48, 93)
        grpScan.Location = New Point(658, 86)
        grpScan.Size = New Size(764, 190)
        grpScan.Text = "  BƯỚC 2: QUÉT / IMPORT COMPONENT ID  "
        lblScan.AutoSize = True
        lblScan.ForeColor = Color.Black
        lblScan.Location = New Point(25, 38)
        lblScan.Text = "Quét Component ID"
        txtComponentId.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtComponentId.BackColor = Color.FromArgb(255, 252, 220)
        txtComponentId.CharacterCasing = CharacterCasing.Upper
        txtComponentId.Font = New Font("Consolas", 16.0F, FontStyle.Bold)
        txtComponentId.Location = New Point(25, 66)
        txtComponentId.Multiline = True
        txtComponentId.Size = New Size(525, 95)
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BackColor = Color.FromArgb(40, 145, 50)
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(568, 58)
        btnAdd.Size = New Size(170, 34)
        btnAdd.Text = "Thêm"
        btnImportExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnImportExcel.BackColor = Color.FromArgb(240, 120, 0)
        btnImportExcel.FlatStyle = FlatStyle.Flat
        btnImportExcel.ForeColor = Color.White
        btnImportExcel.Location = New Point(568, 101)
        btnImportExcel.Size = New Size(170, 34)
        btnImportExcel.Text = "Import Excel"

        btnDownloadTemplate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDownloadTemplate.BackColor = Color.FromArgb(91, 155, 213)
        btnDownloadTemplate.FlatStyle = FlatStyle.Flat
        btnDownloadTemplate.ForeColor = Color.White
        btnDownloadTemplate.Location = New Point(568, 144)
        btnDownloadTemplate.Size = New Size(170, 34)
        btnDownloadTemplate.Text = "Tải file mẫu"
        btnDownloadTemplate.UseVisualStyleBackColor = False

        dgvComponents.AllowUserToAddRows = False
        dgvComponents.AllowUserToDeleteRows = False
        dgvComponents.AllowUserToResizeRows = False
        dgvComponents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvComponents.BackgroundColor = Color.White
        dgvComponents.BorderStyle = BorderStyle.Fixed3D
        dgvComponents.ColumnHeadersHeight = 42
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        headerStyle.BackColor = Color.FromArgb(245, 245, 245)
        headerStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        headerStyle.ForeColor = Color.Black
        dgvComponents.ColumnHeadersDefaultCellStyle = headerStyle
        dgvComponents.EnableHeadersVisualStyles = False
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        cellStyle.Font = New Font("Segoe UI", 10.0F)
        dgvComponents.DefaultCellStyle = cellStyle
        dgvComponents.Location = New Point(18, 290)
        dgvComponents.MultiSelect = True
        dgvComponents.ReadOnly = True
        dgvComponents.RowHeadersVisible = False
        dgvComponents.RowTemplate.Height = 33
        dgvComponents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComponents.Size = New Size(1404, 430)
        colStt.HeaderText = "STT"
        colStt.Name = "colStt"
        colStt.ReadOnly = True
        colStt.Width = 60
        colComponentId.HeaderText = "Component ID"
        colComponentId.Name = "colComponentId"
        colComponentId.ReadOnly = True
        colComponentId.Width = 250
        colUgpn.HeaderText = "UGPN từ DB"
        colUgpn.Name = "colUgpn"
        colUgpn.ReadOnly = True
        colUgpn.Width = 220
        colLocation.HeaderText = "Location hiện tại"
        colLocation.Name = "colLocation"
        colLocation.ReadOnly = True
        colLocation.Width = 220
        colQty.HeaderText = "Qty"
        colQty.Name = "colQty"
        colQty.ReadOnly = True
        colQty.Width = 130
        colStatus.HeaderText = "Trạng thái"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 190
        colDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDetail.HeaderText = "Chi tiết"
        colDetail.Name = "colDetail"
        colDetail.ReadOnly = True
        dgvComponents.Columns.AddRange(New DataGridViewColumn() {
            colStt,
            colComponentId,
            colUgpn,
            colLocation,
            colQty,
            colStatus,
            colDetail})

        pnlSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.White
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.AddRange(New Control() {lblTotalComponents, lblValid, lblInvalid, lblTotalQty, lblQtyStatus})
        pnlSummary.Location = New Point(18, 732)
        pnlSummary.Size = New Size(1404, 64)
        lblTotalComponents.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTotalComponents.ForeColor = Color.FromArgb(0, 85, 190)
        lblTotalComponents.Location = New Point(20, 15)
        lblTotalComponents.Size = New Size(220, 34)
        lblTotalComponents.Text = "Tổng Component:  0"
        lblTotalComponents.TextAlign = ContentAlignment.MiddleLeft
        lblValid.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblValid.ForeColor = Color.Green
        lblValid.Location = New Point(275, 15)
        lblValid.Size = New Size(170, 34)
        lblValid.Text = "Hợp lệ:  0"
        lblValid.TextAlign = ContentAlignment.MiddleLeft
        lblInvalid.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblInvalid.ForeColor = Color.Red
        lblInvalid.Location = New Point(480, 15)
        lblInvalid.Size = New Size(150, 34)
        lblInvalid.Text = "Lỗi:  0"
        lblInvalid.TextAlign = ContentAlignment.MiddleLeft
        lblTotalQty.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTotalQty.ForeColor = Color.FromArgb(0, 85, 190)
        lblTotalQty.Location = New Point(675, 15)
        lblTotalQty.Size = New Size(310, 34)
        lblTotalQty.Text = "Tổng Qty hợp lệ:  0"
        lblTotalQty.TextAlign = ContentAlignment.MiddleLeft
        lblQtyStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblQtyStatus.BackColor = Color.FromArgb(255, 235, 235)
        lblQtyStatus.BorderStyle = BorderStyle.FixedSingle
        lblQtyStatus.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblQtyStatus.ForeColor = Color.Red
        lblQtyStatus.Location = New Point(1080, 10)
        lblQtyStatus.Size = New Size(305, 42)
        lblQtyStatus.Text = "CHƯA CÓ DỮ LIỆU"
        lblQtyStatus.TextAlign = ContentAlignment.MiddleCenter

        pnlActions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlActions.Controls.AddRange(New Control() {btnDeleteRow, btnClearAll, btnTransfer, btnClose})
        pnlActions.Location = New Point(18, 806)
        pnlActions.Size = New Size(1404, 65)
        btnDeleteRow.BackColor = Color.White
        btnDeleteRow.FlatStyle = FlatStyle.Flat
        btnDeleteRow.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDeleteRow.ForeColor = Color.Black
        btnDeleteRow.Location = New Point(0, 0)
        btnDeleteRow.Size = New Size(190, 55)
        btnDeleteRow.Text = "Xóa dòng"
        btnDeleteRow.UseVisualStyleBackColor = False
        btnClearAll.BackColor = Color.White
        btnClearAll.FlatStyle = FlatStyle.Flat
        btnClearAll.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnClearAll.ForeColor = Color.Black
        btnClearAll.Location = New Point(205, 0)
        btnClearAll.Size = New Size(190, 55)
        btnClearAll.Text = "Xóa tất cả"
        btnClearAll.UseVisualStyleBackColor = False
        btnTransfer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTransfer.BackColor = Color.FromArgb(0, 102, 204)
        btnTransfer.FlatStyle = FlatStyle.Flat
        btnTransfer.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnTransfer.ForeColor = Color.White
        btnTransfer.Location = New Point(565, 0)
        btnTransfer.Size = New Size(570, 55)
        btnTransfer.Text = "LƯU LỊCH SỬ & CHUYỂN LOCATION"
        btnTransfer.UseVisualStyleBackColor = False
        btnTransfer.Enabled = False
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.White
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(1150, 0)
        btnClose.Size = New Size(254, 55)
        btnClose.Text = "Đóng"
        btnClose.UseVisualStyleBackColor = False

        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(248, 249, 251)
        ClientSize = New Size(1440, 890)
        Controls.AddRange(New Control() {pnlActions, pnlSummary, dgvComponents, grpScan, grpInfo, pnlHeader})
        Font = New Font("Segoe UI", 9.0F)
        MinimumSize = New Size(1180, 760)
        Name = "FrmComponentLocationTransfer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Component Location Transfer"
        WindowState = FormWindowState.Maximized

        pnlHeader.ResumeLayout(False)
        grpInfo.ResumeLayout(False)
        grpInfo.PerformLayout()
        grpScan.ResumeLayout(False)
        grpScan.PerformLayout()
        CType(dgvComponents, System.ComponentModel.ISupportInitialize).EndInit()
        pnlSummary.ResumeLayout(False)
        pnlActions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

End Class
