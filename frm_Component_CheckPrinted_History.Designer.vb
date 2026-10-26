<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Component_CheckPrinted_History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltotalOriginBy = New System.Windows.Forms.Label()
        Me.DGVDetail = New System.Windows.Forms.DataGridView()
        Me.DGVSummary = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.DGVUser = New System.Windows.Forms.DataGridView()
        Me.DGVArea = New System.Windows.Forms.DataGridView()
        Me.DGRFIFO = New System.Windows.Forms.DataGridView()
        Me.btnUpdateExpiredete = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkTo = New System.Windows.Forms.CheckBox()
        Me.chkFrom = New System.Windows.Forms.CheckBox()
        Me.txtComponent_ID = New System.Windows.Forms.TextBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lbltotalOriginQty = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLoc = New System.Windows.Forms.CheckBox()
        Me.chkLotCode = New System.Windows.Forms.CheckBox()
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox()
        Me.txtDateCode = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtUGPN = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnSearch = New System.Windows.Forms.Button()
        Me.txtUGPN_ = New System.Windows.Forms.TextBox()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        CType(Me.DGVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRFIFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltotalOriginBy
        '
        Me.lbltotalOriginBy.AutoSize = True
        Me.lbltotalOriginBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalOriginBy.Location = New System.Drawing.Point(1401, 331)
        Me.lbltotalOriginBy.Name = "lbltotalOriginBy"
        Me.lbltotalOriginBy.Size = New System.Drawing.Size(23, 25)
        Me.lbltotalOriginBy.TabIndex = 132
        Me.lbltotalOriginBy.Text = "0"
        '
        'DGVDetail
        '
        Me.DGVDetail.AllowUserToAddRows = False
        Me.DGVDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetail.Location = New System.Drawing.Point(385, 359)
        Me.DGVDetail.Name = "DGVDetail"
        Me.DGVDetail.Size = New System.Drawing.Size(1397, 203)
        Me.DGVDetail.TabIndex = 130
        '
        'DGVSummary
        '
        Me.DGVSummary.AllowUserToAddRows = False
        Me.DGVSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSummary.Location = New System.Drawing.Point(657, 22)
        Me.DGVSummary.Name = "DGVSummary"
        Me.DGVSummary.Size = New System.Drawing.Size(383, 284)
        Me.DGVSummary.TabIndex = 129
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(14, 549)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.lbltotal.TabIndex = 128
        Me.lbltotal.Text = "Total"
        '
        'DGVUser
        '
        Me.DGVUser.AllowUserToAddRows = False
        Me.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUser.Location = New System.Drawing.Point(1046, 22)
        Me.DGVUser.Name = "DGVUser"
        Me.DGVUser.Size = New System.Drawing.Size(364, 284)
        Me.DGVUser.TabIndex = 126
        '
        'DGVArea
        '
        Me.DGVArea.AllowUserToAddRows = False
        Me.DGVArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArea.Location = New System.Drawing.Point(1423, 22)
        Me.DGVArea.Name = "DGVArea"
        Me.DGVArea.Size = New System.Drawing.Size(352, 284)
        Me.DGVArea.TabIndex = 125
        '
        'DGRFIFO
        '
        Me.DGRFIFO.AllowUserToAddRows = False
        Me.DGRFIFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRFIFO.Location = New System.Drawing.Point(14, 568)
        Me.DGRFIFO.Name = "DGRFIFO"
        Me.DGRFIFO.Size = New System.Drawing.Size(1768, 356)
        Me.DGRFIFO.TabIndex = 127
        '
        'btnUpdateExpiredete
        '
        Me.btnUpdateExpiredete.BackColor = System.Drawing.Color.Red
        Me.btnUpdateExpiredete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateExpiredete.Location = New System.Drawing.Point(475, 321)
        Me.btnUpdateExpiredete.Name = "btnUpdateExpiredete"
        Me.btnUpdateExpiredete.Size = New System.Drawing.Size(179, 29)
        Me.btnUpdateExpiredete.TabIndex = 120
        Me.btnUpdateExpiredete.Text = "Update DateExpire"
        Me.btnUpdateExpiredete.UseVisualStyleBackColor = False
        Me.btnUpdateExpiredete.Visible = False
        '
        'btnExp
        '
        Me.btnExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExp.Location = New System.Drawing.Point(1687, 331)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(88, 25)
        Me.btnExp.TabIndex = 119
        Me.btnExp.Text = "Export Excel"
        Me.btnExp.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(359, 321)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 29)
        Me.btnExport.TabIndex = 121
        Me.btnExport.Text = "Export Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(243, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 29)
        Me.btnClear.TabIndex = 118
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(127, 321)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 29)
        Me.btnUpdate.TabIndex = 117
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Component ID"
        '
        'chkTo
        '
        Me.chkTo.AutoSize = True
        Me.chkTo.Location = New System.Drawing.Point(74, 46)
        Me.chkTo.Name = "chkTo"
        Me.chkTo.Size = New System.Drawing.Size(42, 17)
        Me.chkTo.TabIndex = 112
        Me.chkTo.Text = "To:"
        Me.chkTo.UseVisualStyleBackColor = True
        '
        'chkFrom
        '
        Me.chkFrom.AutoSize = True
        Me.chkFrom.Location = New System.Drawing.Point(13, 21)
        Me.chkFrom.Name = "chkFrom"
        Me.chkFrom.Size = New System.Drawing.Size(52, 17)
        Me.chkFrom.TabIndex = 112
        Me.chkFrom.Text = "From:"
        Me.chkFrom.UseVisualStyleBackColor = True
        '
        'txtComponent_ID
        '
        Me.txtComponent_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComponent_ID.Location = New System.Drawing.Point(194, 16)
        Me.txtComponent_ID.Name = "txtComponent_ID"
        Me.txtComponent_ID.Size = New System.Drawing.Size(282, 26)
        Me.txtComponent_ID.TabIndex = 107
        Me.txtComponent_ID.Text = " "
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(122, 45)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpTo.TabIndex = 111
        '
        'lbltotalOriginQty
        '
        Me.lbltotalOriginQty.AutoSize = True
        Me.lbltotalOriginQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalOriginQty.Location = New System.Drawing.Point(18, 421)
        Me.lbltotalOriginQty.Name = "lbltotalOriginQty"
        Me.lbltotalOriginQty.Size = New System.Drawing.Size(138, 31)
        Me.lbltotalOriginQty.TabIndex = 131
        Me.lbltotalOriginQty.Text = "Total QTY"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTo)
        Me.GroupBox2.Controls.Add(Me.chkFrom)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 86)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(71, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(103, 20)
        Me.dtpFrom.TabIndex = 111
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtComponent_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkLoc)
        Me.GroupBox1.Controls.Add(Me.chkLotCode)
        Me.GroupBox1.Controls.Add(Me.ChkUnigenPN)
        Me.GroupBox1.Controls.Add(Me.txtDateCode)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.txtUGPN)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 242)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Infor ComponentID Must Out"
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLoc.Location = New System.Drawing.Point(18, 120)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(166, 24)
        Me.chkLoc.TabIndex = 106
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLotCode.ForeColor = System.Drawing.Color.Red
        Me.chkLotCode.Location = New System.Drawing.Point(18, 84)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(109, 24)
        Me.chkLotCode.TabIndex = 104
        Me.chkLotCode.Text = "DateCode"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUnigenPN.Location = New System.Drawing.Point(18, 51)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(118, 24)
        Me.ChkUnigenPN.TabIndex = 101
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'txtDateCode
        '
        Me.txtDateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateCode.ForeColor = System.Drawing.Color.Red
        Me.txtDateCode.Location = New System.Drawing.Point(194, 84)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 29)
        Me.txtDateCode.TabIndex = 1
        Me.txtDateCode.Text = " "
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.Blue
        Me.txtLoc.Location = New System.Drawing.Point(194, 120)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(138, 26)
        Me.txtLoc.TabIndex = 2
        '
        'txtUGPN
        '
        Me.txtUGPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUGPN.ForeColor = System.Drawing.Color.Blue
        Me.txtUGPN.Location = New System.Drawing.Point(194, 51)
        Me.txtUGPN.Name = "txtUGPN"
        Me.txtUGPN.Size = New System.Drawing.Size(219, 26)
        Me.txtUGPN.TabIndex = 0
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(18, 51)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox2.TabIndex = 123
        Me.CheckBox2.Text = "Unigen P/N"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Component ID"
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.Blue
        Me.tbnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnSearch.ForeColor = System.Drawing.Color.Yellow
        Me.tbnSearch.Location = New System.Drawing.Point(11, 321)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(110, 29)
        Me.tbnSearch.TabIndex = 116
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'txtUGPN_
        '
        Me.txtUGPN_.ForeColor = System.Drawing.Color.Blue
        Me.txtUGPN_.Location = New System.Drawing.Point(107, 48)
        Me.txtUGPN_.Name = "txtUGPN_"
        Me.txtUGPN_.Size = New System.Drawing.Size(325, 20)
        Me.txtUGPN_.TabIndex = 115
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(107, 22)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(325, 20)
        Me.txtComponentID.TabIndex = 114
        Me.txtComponentID.Text = " "
        '
        'frm_Component_CheckPrinted_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1792, 946)
        Me.Controls.Add(Me.lbltotalOriginBy)
        Me.Controls.Add(Me.DGVDetail)
        Me.Controls.Add(Me.DGVSummary)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.DGVUser)
        Me.Controls.Add(Me.DGVArea)
        Me.Controls.Add(Me.DGRFIFO)
        Me.Controls.Add(Me.btnUpdateExpiredete)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbltotalOriginQty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnSearch)
        Me.Controls.Add(Me.txtUGPN_)
        Me.Controls.Add(Me.txtComponentID)
        Me.Name = "frm_Component_CheckPrinted_History"
        Me.Text = "frm_Component_CheckPrinted_History"
        CType(Me.DGVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRFIFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotalOriginBy As Label
    Friend WithEvents DGVDetail As DataGridView
    Friend WithEvents DGVSummary As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents DGVUser As DataGridView
    Friend WithEvents DGVArea As DataGridView
    Friend WithEvents DGRFIFO As DataGridView
    Friend WithEvents btnUpdateExpiredete As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents chkTo As CheckBox
    Friend WithEvents chkFrom As CheckBox
    Friend WithEvents txtComponent_ID As TextBox
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lbltotalOriginQty As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkLoc As CheckBox
    Friend WithEvents chkLotCode As CheckBox
    Friend WithEvents ChkUnigenPN As CheckBox
    Friend WithEvents txtDateCode As TextBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents txtUGPN As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbnSearch As Button
    Friend WithEvents txtUGPN_ As TextBox
    Friend WithEvents txtComponentID As TextBox
End Class
