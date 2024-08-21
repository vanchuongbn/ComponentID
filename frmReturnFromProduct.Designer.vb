<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnFromProduct
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
        Me.txtTier = New System.Windows.Forms.TextBox
        Me.txtComponentID = New System.Windows.Forms.TextBox
        Me.ChkCOO = New System.Windows.Forms.CheckBox
        Me.tbnSearch = New System.Windows.Forms.Button
        Me.txtCOO = New System.Windows.Forms.TextBox
        Me.NudSerializedLabel = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkCustomer = New System.Windows.Forms.CheckBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkDEV = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.radRCV = New System.Windows.Forms.RadioButton
        Me.radRTN = New System.Windows.Forms.RadioButton
        Me.radSPL = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radOther = New System.Windows.Forms.RadioButton
        Me.radpcb = New System.Windows.Forms.RadioButton
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.chkDateCode = New System.Windows.Forms.CheckBox
        Me.chkLotCode = New System.Windows.Forms.CheckBox
        Me.ChkMfger = New System.Windows.Forms.CheckBox
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox
        Me.txtOriginQty = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtQtyPackage = New System.Windows.Forms.TextBox
        Me.ChkQty = New System.Windows.Forms.CheckBox
        Me.chkFirmware = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.chkpo = New System.Windows.Forms.CheckBox
        Me.txtFirmware = New System.Windows.Forms.TextBox
        Me.txtDateCode = New System.Windows.Forms.TextBox
        Me.txtLotCode = New System.Windows.Forms.TextBox
        Me.txtMfger = New System.Windows.Forms.TextBox
        Me.txtMfgPN = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.lblVendor = New System.Windows.Forms.Label
        Me.lblDesctiption = New System.Windows.Forms.Label
        Me.txtvendor = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMSL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRemainingExposure = New System.Windows.Forms.TextBox
        Me.chkRemainExposure = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMSL_ = New System.Windows.Forms.TextBox
        Me.txtopentime = New System.Windows.Forms.TextBox
        Me.txtclosetime = New System.Windows.Forms.TextBox
        Me.txtRemainTime = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.btnPrintRemainTime = New System.Windows.Forms.Button
        Me.nudCopiesOfLabel1 = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudCopiesOfLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTier
        '
        Me.txtTier.Location = New System.Drawing.Point(120, 647)
        Me.txtTier.Name = "txtTier"
        Me.txtTier.ReadOnly = True
        Me.txtTier.Size = New System.Drawing.Size(71, 20)
        Me.txtTier.TabIndex = 105
        Me.txtTier.Visible = False
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(91, 19)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(157, 20)
        Me.txtComponentID.TabIndex = 58
        Me.txtComponentID.Text = " "
        '
        'ChkCOO
        '
        Me.ChkCOO.AutoSize = True
        Me.ChkCOO.Location = New System.Drawing.Point(93, 405)
        Me.ChkCOO.Name = "ChkCOO"
        Me.ChkCOO.Size = New System.Drawing.Size(112, 17)
        Me.ChkCOO.TabIndex = 104
        Me.ChkCOO.Text = "Country of Original"
        Me.ChkCOO.UseVisualStyleBackColor = True
        '
        'tbnSearch
        '
        Me.tbnSearch.Location = New System.Drawing.Point(264, 19)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 57
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = True
        '
        'txtCOO
        '
        Me.txtCOO.Location = New System.Drawing.Point(218, 403)
        Me.txtCOO.Name = "txtCOO"
        Me.txtCOO.Size = New System.Drawing.Size(160, 20)
        Me.txtCOO.TabIndex = 103
        Me.txtCOO.Text = "N/A"
        '
        'NudSerializedLabel
        '
        Me.NudSerializedLabel.Location = New System.Drawing.Point(217, 457)
        Me.NudSerializedLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudSerializedLabel.Name = "NudSerializedLabel"
        Me.NudSerializedLabel.ReadOnly = True
        Me.NudSerializedLabel.Size = New System.Drawing.Size(56, 20)
        Me.NudSerializedLabel.TabIndex = 101
        Me.NudSerializedLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudSerializedLabel.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(61, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Number of serialized labels"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(218, 430)
        Me.nudCopiesOfLabel.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel.TabIndex = 99
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(61, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Identical copies of labels"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(218, 376)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(159, 20)
        Me.txtCustomer.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Component ID"
        '
        'ChkCustomer
        '
        Me.ChkCustomer.AutoSize = True
        Me.ChkCustomer.Location = New System.Drawing.Point(104, 378)
        Me.ChkCustomer.Name = "ChkCustomer"
        Me.ChkCustomer.Size = New System.Drawing.Size(101, 17)
        Me.ChkCustomer.TabIndex = 97
        Me.ChkCustomer.Text = "Customer Name"
        Me.ChkCustomer.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(221, 643)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(162, 27)
        Me.btnPrint.TabIndex = 96
        Me.btnPrint.Text = "Assign New ID  && Print  (F4)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkDEV)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtComponentID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1198, 48)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'chkDEV
        '
        Me.chkDEV.AutoSize = True
        Me.chkDEV.Location = New System.Drawing.Point(731, 21)
        Me.chkDEV.Name = "chkDEV"
        Me.chkDEV.Size = New System.Drawing.Size(142, 17)
        Me.chkDEV.TabIndex = 160
        Me.chkDEV.Text = "Print With DEV Extened "
        Me.chkDEV.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radRCV)
        Me.GroupBox4.Controls.Add(Me.radRTN)
        Me.GroupBox4.Controls.Add(Me.radSPL)
        Me.GroupBox4.Location = New System.Drawing.Point(527, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(198, 40)
        Me.GroupBox4.TabIndex = 158
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " "
        '
        'radRCV
        '
        Me.radRCV.AutoSize = True
        Me.radRCV.Location = New System.Drawing.Point(120, 13)
        Me.radRCV.Name = "radRCV"
        Me.radRCV.Size = New System.Drawing.Size(47, 17)
        Me.radRCV.TabIndex = 0
        Me.radRCV.TabStop = True
        Me.radRCV.Text = "RCV"
        Me.radRCV.UseVisualStyleBackColor = True
        '
        'radRTN
        '
        Me.radRTN.AutoSize = True
        Me.radRTN.Location = New System.Drawing.Point(61, 14)
        Me.radRTN.Name = "radRTN"
        Me.radRTN.Size = New System.Drawing.Size(48, 17)
        Me.radRTN.TabIndex = 0
        Me.radRTN.TabStop = True
        Me.radRTN.Text = "RTN"
        Me.radRTN.UseVisualStyleBackColor = True
        '
        'radSPL
        '
        Me.radSPL.AutoSize = True
        Me.radSPL.Location = New System.Drawing.Point(6, 14)
        Me.radSPL.Name = "radSPL"
        Me.radSPL.Size = New System.Drawing.Size(45, 17)
        Me.radSPL.TabIndex = 0
        Me.radSPL.TabStop = True
        Me.radSPL.Text = "SPL"
        Me.radSPL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radOther)
        Me.GroupBox2.Controls.Add(Me.radpcb)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 40)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(61, 14)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(54, 17)
        Me.radOther.TabIndex = 0
        Me.radOther.TabStop = True
        Me.radOther.Text = " Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radpcb
        '
        Me.radpcb.AutoSize = True
        Me.radpcb.Location = New System.Drawing.Point(6, 14)
        Me.radpcb.Name = "radpcb"
        Me.radpcb.Size = New System.Drawing.Size(39, 17)
        Me.radpcb.TabIndex = 0
        Me.radpcb.TabStop = True
        Me.radpcb.Text = "WI"
        Me.radpcb.UseVisualStyleBackColor = True
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(103, 351)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(107, 17)
        Me.chkLoc.TabIndex = 94
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(98, 248)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(107, 17)
        Me.chkDateCode.TabIndex = 93
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(106, 221)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(99, 17)
        Me.chkLotCode.TabIndex = 92
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(152, 194)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(53, 17)
        Me.ChkMfger.TabIndex = 88
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(122, 167)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(83, 17)
        Me.ChkUnigenPN.TabIndex = 87
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(129, 140)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(76, 17)
        Me.ChkMfgPN.TabIndex = 86
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'txtOriginQty
        '
        Me.txtOriginQty.Location = New System.Drawing.Point(217, 321)
        Me.txtOriginQty.Name = "txtOriginQty"
        Me.txtOriginQty.ReadOnly = True
        Me.txtOriginQty.Size = New System.Drawing.Size(160, 20)
        Me.txtOriginQty.TabIndex = 80
        Me.txtOriginQty.Text = " "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(111, 323)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1.TabIndex = 91
        Me.CheckBox1.Text = "Origin Qty"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtQtyPackage
        '
        Me.txtQtyPackage.Location = New System.Drawing.Point(218, 295)
        Me.txtQtyPackage.Name = "txtQtyPackage"
        Me.txtQtyPackage.Size = New System.Drawing.Size(160, 20)
        Me.txtQtyPackage.TabIndex = 81
        '
        'ChkQty
        '
        Me.ChkQty.AutoSize = True
        Me.ChkQty.Checked = True
        Me.ChkQty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkQty.Location = New System.Drawing.Point(112, 297)
        Me.ChkQty.Name = "ChkQty"
        Me.ChkQty.Size = New System.Drawing.Size(93, 17)
        Me.ChkQty.TabIndex = 90
        Me.ChkQty.Text = "Qty /Package"
        Me.ChkQty.UseVisualStyleBackColor = True
        '
        'chkFirmware
        '
        Me.chkFirmware.AutoSize = True
        Me.chkFirmware.Checked = True
        Me.chkFirmware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFirmware.Location = New System.Drawing.Point(76, 270)
        Me.chkFirmware.Name = "chkFirmware"
        Me.chkFirmware.Size = New System.Drawing.Size(129, 17)
        Me.chkFirmware.TabIndex = 89
        Me.chkFirmware.Text = "Firmware && Rev (Opt.)"
        Me.chkFirmware.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "User:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(218, 77)
        Me.lblUser.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.MinimumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(160, 13)
        Me.lblUser.TabIndex = 83
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkpo
        '
        Me.chkpo.Checked = True
        Me.chkpo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpo.Location = New System.Drawing.Point(149, 106)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(56, 24)
        Me.chkpo.TabIndex = 85
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirmware
        '
        Me.txtFirmware.Location = New System.Drawing.Point(218, 268)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(160, 20)
        Me.txtFirmware.TabIndex = 79
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(218, 241)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCode.TabIndex = 78
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(218, 214)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(160, 20)
        Me.txtLotCode.TabIndex = 77
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(218, 187)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(160, 20)
        Me.txtMfger.TabIndex = 76
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(218, 133)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(160, 20)
        Me.txtMfgPN.TabIndex = 74
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(218, 106)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.TabIndex = 73
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(218, 349)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(160, 20)
        Me.txtLoc.TabIndex = 82
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(218, 160)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(160, 20)
        Me.txtPN.TabIndex = 75
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(150, 541)
        Me.lblVendor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(41, 13)
        Me.lblVendor.TabIndex = 111
        Me.lblVendor.Text = "Vendor"
        '
        'lblDesctiption
        '
        Me.lblDesctiption.AutoSize = True
        Me.lblDesctiption.Location = New System.Drawing.Point(129, 514)
        Me.lblDesctiption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesctiption.Name = "lblDesctiption"
        Me.lblDesctiption.Size = New System.Drawing.Size(60, 13)
        Me.lblDesctiption.TabIndex = 110
        Me.lblDesctiption.Text = "Description"
        '
        'txtvendor
        '
        Me.txtvendor.Location = New System.Drawing.Point(215, 541)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.ReadOnly = True
        Me.txtvendor.Size = New System.Drawing.Size(415, 20)
        Me.txtvendor.TabIndex = 109
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(216, 514)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(413, 20)
        Me.txtDescription.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 488)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "MSL"
        '
        'txtMSL
        '
        Me.txtMSL.Location = New System.Drawing.Point(216, 488)
        Me.txtMSL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMSL.Name = "txtMSL"
        Me.txtMSL.Size = New System.Drawing.Size(213, 20)
        Me.txtMSL.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = " "
        '
        'txtRemainingExposure
        '
        Me.txtRemainingExposure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemainingExposure.ForeColor = System.Drawing.Color.Red
        Me.txtRemainingExposure.Location = New System.Drawing.Point(214, 575)
        Me.txtRemainingExposure.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemainingExposure.Name = "txtRemainingExposure"
        Me.txtRemainingExposure.ReadOnly = True
        Me.txtRemainingExposure.Size = New System.Drawing.Size(215, 23)
        Me.txtRemainingExposure.TabIndex = 109
        Me.txtRemainingExposure.Text = " "
        '
        'chkRemainExposure
        '
        Me.chkRemainExposure.AutoSize = True
        Me.chkRemainExposure.Location = New System.Drawing.Point(82, 579)
        Me.chkRemainExposure.Name = "chkRemainExposure"
        Me.chkRemainExposure.Size = New System.Drawing.Size(123, 17)
        Me.chkRemainExposure.TabIndex = 113
        Me.chkRemainExposure.Text = " RemainingExposure"
        Me.chkRemainExposure.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtMSL_)
        Me.GroupBox3.Controls.Add(Me.txtopentime)
        Me.GroupBox3.Controls.Add(Me.txtclosetime)
        Me.GroupBox3.Controls.Add(Me.txtRemainTime)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.btnPrintRemainTime)
        Me.GroupBox3.Controls.Add(Me.nudCopiesOfLabel1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(514, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 260)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Print Remaining Exposure"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "  Close Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "MSL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = " Open Time:"
        '
        'txtMSL_
        '
        Me.txtMSL_.Location = New System.Drawing.Point(111, 52)
        Me.txtMSL_.Name = "txtMSL_"
        Me.txtMSL_.ReadOnly = True
        Me.txtMSL_.Size = New System.Drawing.Size(220, 20)
        Me.txtMSL_.TabIndex = 67
        Me.txtMSL_.Text = " "
        '
        'txtopentime
        '
        Me.txtopentime.Location = New System.Drawing.Point(111, 78)
        Me.txtopentime.Name = "txtopentime"
        Me.txtopentime.ReadOnly = True
        Me.txtopentime.Size = New System.Drawing.Size(220, 20)
        Me.txtopentime.TabIndex = 67
        Me.txtopentime.Text = " "
        '
        'txtclosetime
        '
        Me.txtclosetime.Location = New System.Drawing.Point(111, 105)
        Me.txtclosetime.Name = "txtclosetime"
        Me.txtclosetime.ReadOnly = True
        Me.txtclosetime.Size = New System.Drawing.Size(220, 20)
        Me.txtclosetime.TabIndex = 67
        Me.txtclosetime.Text = " "
        '
        'txtRemainTime
        '
        Me.txtRemainTime.Location = New System.Drawing.Point(111, 131)
        Me.txtRemainTime.Name = "txtRemainTime"
        Me.txtRemainTime.ReadOnly = True
        Me.txtRemainTime.Size = New System.Drawing.Size(220, 20)
        Me.txtRemainTime.TabIndex = 67
        Me.txtRemainTime.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Remain Time:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 63
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(14, 24)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox2.TabIndex = 62
        Me.CheckBox2.Text = "ComponentID"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnPrintRemainTime
        '
        Me.btnPrintRemainTime.Location = New System.Drawing.Point(127, 203)
        Me.btnPrintRemainTime.Name = "btnPrintRemainTime"
        Me.btnPrintRemainTime.Size = New System.Drawing.Size(128, 27)
        Me.btnPrintRemainTime.TabIndex = 61
        Me.btnPrintRemainTime.Text = " Print"
        '
        'nudCopiesOfLabel1
        '
        Me.nudCopiesOfLabel1.Location = New System.Drawing.Point(169, 168)
        Me.nudCopiesOfLabel1.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel1.Name = "nudCopiesOfLabel1"
        Me.nudCopiesOfLabel1.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel1.TabIndex = 64
        Me.nudCopiesOfLabel1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(19, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Identical copies of labels"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReturnFromProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 729)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkRemainExposure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.lblDesctiption)
        Me.Controls.Add(Me.txtRemainingExposure)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMSL)
        Me.Controls.Add(Me.txtTier)
        Me.Controls.Add(Me.ChkCOO)
        Me.Controls.Add(Me.txtCOO)
        Me.Controls.Add(Me.NudSerializedLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudCopiesOfLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.ChkCustomer)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkLoc)
        Me.Controls.Add(Me.chkDateCode)
        Me.Controls.Add(Me.chkLotCode)
        Me.Controls.Add(Me.ChkMfger)
        Me.Controls.Add(Me.ChkUnigenPN)
        Me.Controls.Add(Me.ChkMfgPN)
        Me.Controls.Add(Me.txtOriginQty)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtQtyPackage)
        Me.Controls.Add(Me.ChkQty)
        Me.Controls.Add(Me.chkFirmware)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.chkpo)
        Me.Controls.Add(Me.txtFirmware)
        Me.Controls.Add(Me.txtDateCode)
        Me.Controls.Add(Me.txtLotCode)
        Me.Controls.Add(Me.txtMfger)
        Me.Controls.Add(Me.txtMfgPN)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtPN)
        Me.Name = "frmReturnFromProduct"
        Me.Text = "frmReturnFromProduct"
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudCopiesOfLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTier As System.Windows.Forms.TextBox
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents ChkCOO As System.Windows.Forms.CheckBox
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCOO As System.Windows.Forms.TextBox
    Friend WithEvents NudSerializedLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudCopiesOfLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkDateCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotCode As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMfger As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnigenPN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMfgPN As System.Windows.Forms.CheckBox
    Friend WithEvents txtOriginQty As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtQtyPackage As System.Windows.Forms.TextBox
    Friend WithEvents ChkQty As System.Windows.Forms.CheckBox
    Friend WithEvents chkFirmware As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents chkpo As System.Windows.Forms.CheckBox
    Friend WithEvents txtFirmware As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLotCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMfger As System.Windows.Forms.TextBox
    Friend WithEvents txtMfgPN As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents lblVendor As System.Windows.Forms.Label
    Friend WithEvents lblDesctiption As System.Windows.Forms.Label
    Friend WithEvents txtvendor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMSL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radpcb As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemainingExposure As System.Windows.Forms.TextBox
    Friend WithEvents chkRemainExposure As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMSL_ As System.Windows.Forms.TextBox
    Friend WithEvents txtopentime As System.Windows.Forms.TextBox
    Friend WithEvents txtclosetime As System.Windows.Forms.TextBox
    Friend WithEvents txtRemainTime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrintRemainTime As System.Windows.Forms.Button
    Friend WithEvents nudCopiesOfLabel1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radRCV As System.Windows.Forms.RadioButton
    Friend WithEvents radRTN As System.Windows.Forms.RadioButton
    Friend WithEvents radSPL As System.Windows.Forms.RadioButton
    Friend WithEvents chkDEV As System.Windows.Forms.CheckBox
End Class
