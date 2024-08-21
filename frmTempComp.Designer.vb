<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTempComp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTempComp))
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.ChkCustomer = New System.Windows.Forms.CheckBox
        Me.chkDateCode = New System.Windows.Forms.CheckBox
        Me.chkLotCode = New System.Windows.Forms.CheckBox
        Me.ChkMfger = New System.Windows.Forms.CheckBox
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox
        Me.txtQtyPackage = New System.Windows.Forms.TextBox
        Me.ChkQty = New System.Windows.Forms.CheckBox
        Me.chkFirmware = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.NudSerializedLabel = New System.Windows.Forms.NumericUpDown
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkpo = New System.Windows.Forms.CheckBox
        Me.txtFirmware = New System.Windows.Forms.TextBox
        Me.txtDateCode = New System.Windows.Forms.TextBox
        Me.txtLotCode = New System.Windows.Forms.TextBox
        Me.txtMfger = New System.Windows.Forms.TextBox
        Me.txtMfgPN = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(64, 295)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(107, 17)
        Me.chkLoc.TabIndex = 24
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(185, 50)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(159, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'ChkCustomer
        '
        Me.ChkCustomer.AutoSize = True
        Me.ChkCustomer.Location = New System.Drawing.Point(75, 52)
        Me.ChkCustomer.Name = "ChkCustomer"
        Me.ChkCustomer.Size = New System.Drawing.Size(101, 17)
        Me.ChkCustomer.TabIndex = 15
        Me.ChkCustomer.Text = "Customer Name"
        Me.ChkCustomer.UseVisualStyleBackColor = True
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(65, 214)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(107, 17)
        Me.chkDateCode.TabIndex = 21
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(73, 186)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(99, 17)
        Me.chkLotCode.TabIndex = 20
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(119, 162)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(53, 17)
        Me.ChkMfger.TabIndex = 19
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(89, 133)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(83, 17)
        Me.ChkUnigenPN.TabIndex = 18
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(96, 106)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(76, 17)
        Me.ChkMfgPN.TabIndex = 17
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'txtQtyPackage
        '
        Me.txtQtyPackage.Location = New System.Drawing.Point(184, 266)
        Me.txtQtyPackage.Name = "txtQtyPackage"
        Me.txtQtyPackage.Size = New System.Drawing.Size(160, 20)
        Me.txtQtyPackage.TabIndex = 9
        '
        'ChkQty
        '
        Me.ChkQty.AutoSize = True
        Me.ChkQty.Checked = True
        Me.ChkQty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkQty.Location = New System.Drawing.Point(76, 266)
        Me.ChkQty.Name = "ChkQty"
        Me.ChkQty.Size = New System.Drawing.Size(96, 17)
        Me.ChkQty.TabIndex = 23
        Me.ChkQty.Text = "Qty /Packager"
        Me.ChkQty.UseVisualStyleBackColor = True
        '
        'chkFirmware
        '
        Me.chkFirmware.AutoSize = True
        Me.chkFirmware.Checked = True
        Me.chkFirmware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFirmware.Location = New System.Drawing.Point(43, 240)
        Me.chkFirmware.Name = "chkFirmware"
        Me.chkFirmware.Size = New System.Drawing.Size(129, 17)
        Me.chkFirmware.TabIndex = 22
        Me.chkFirmware.Text = "Firmware && Rev (Opt.)"
        Me.chkFirmware.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(139, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "User:"
        '
        'NudSerializedLabel
        '
        Me.NudSerializedLabel.Location = New System.Drawing.Point(185, 360)
        Me.NudSerializedLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudSerializedLabel.Name = "NudSerializedLabel"
        Me.NudSerializedLabel.Size = New System.Drawing.Size(56, 20)
        Me.NudSerializedLabel.TabIndex = 12
        Me.NudSerializedLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(184, 329)
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel.TabIndex = 11
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(27, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Number of serialized labels"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkpo
        '
        Me.chkpo.Checked = True
        Me.chkpo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpo.Location = New System.Drawing.Point(116, 77)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(56, 24)
        Me.chkpo.TabIndex = 16
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirmware
        '
        Me.txtFirmware.Location = New System.Drawing.Point(184, 239)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(160, 20)
        Me.txtFirmware.TabIndex = 8
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(184, 212)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCode.TabIndex = 7
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(184, 185)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(160, 20)
        Me.txtLotCode.TabIndex = 6
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(184, 158)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(160, 20)
        Me.txtMfger.TabIndex = 5
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(184, 104)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(160, 20)
        Me.txtMfgPN.TabIndex = 3
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(184, 77)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(181, 397)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 25)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print  (F4)"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(184, 293)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(160, 20)
        Me.txtLoc.TabIndex = 10
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(184, 131)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(160, 20)
        Me.txtPN.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(27, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Identical copies of labels"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(184, 24)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(159, 20)
        Me.txtUser.TabIndex = 0
        '
        'frmTempComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 443)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.chkLoc)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.ChkCustomer)
        Me.Controls.Add(Me.chkDateCode)
        Me.Controls.Add(Me.chkLotCode)
        Me.Controls.Add(Me.ChkMfger)
        Me.Controls.Add(Me.ChkUnigenPN)
        Me.Controls.Add(Me.ChkMfgPN)
        Me.Controls.Add(Me.txtQtyPackage)
        Me.Controls.Add(Me.ChkQty)
        Me.Controls.Add(Me.chkFirmware)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NudSerializedLabel)
        Me.Controls.Add(Me.nudCopiesOfLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkpo)
        Me.Controls.Add(Me.txtFirmware)
        Me.Controls.Add(Me.txtDateCode)
        Me.Controls.Add(Me.txtLotCode)
        Me.Controls.Add(Me.txtMfger)
        Me.Controls.Add(Me.txtMfgPN)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTempComp"
        Me.Text = "Generate ComponentID (emergency use/Local Version)"
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents ChkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkDateCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotCode As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMfger As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnigenPN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMfgPN As System.Windows.Forms.CheckBox
    Friend WithEvents txtQtyPackage As System.Windows.Forms.TextBox
    Friend WithEvents ChkQty As System.Windows.Forms.CheckBox
    Friend WithEvents chkFirmware As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NudSerializedLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCopiesOfLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkpo As System.Windows.Forms.CheckBox
    Friend WithEvents txtFirmware As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLotCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMfger As System.Windows.Forms.TextBox
    Friend WithEvents txtMfgPN As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
End Class
