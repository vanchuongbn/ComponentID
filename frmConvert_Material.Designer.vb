<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConvert_Material
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTier = New System.Windows.Forms.TextBox()
        Me.ChkCOO = New System.Windows.Forms.CheckBox()
        Me.txtCOO = New System.Windows.Forms.TextBox()
        Me.NudSerializedLabel = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.ChkCustomer = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDEV = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radRCV = New System.Windows.Forms.RadioButton()
        Me.radRTN = New System.Windows.Forms.RadioButton()
        Me.radSPL = New System.Windows.Forms.RadioButton()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radpcb = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnSearch = New System.Windows.Forms.Button()
        Me.chkLoc = New System.Windows.Forms.CheckBox()
        Me.chkDateCode = New System.Windows.Forms.CheckBox()
        Me.chkLotCode = New System.Windows.Forms.CheckBox()
        Me.ChkMfger = New System.Windows.Forms.CheckBox()
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox()
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox()
        Me.txtOriginQty = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtQtyPackage = New System.Windows.Forms.TextBox()
        Me.ChkQty = New System.Windows.Forms.CheckBox()
        Me.chkFirmware = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.chkpo = New System.Windows.Forms.CheckBox()
        Me.txtFirmware = New System.Windows.Forms.TextBox()
        Me.txtDateCode = New System.Windows.Forms.TextBox()
        Me.txtLotCode = New System.Windows.Forms.TextBox()
        Me.txtMfger = New System.Windows.Forms.TextBox()
        Me.txtMfgPN = New System.Windows.Forms.TextBox()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.lblDesctiption = New System.Windows.Forms.Label()
        Me.txtvendor = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMSL = New System.Windows.Forms.TextBox()
        Me.chkRemainExposure = New System.Windows.Forms.CheckBox()
        Me.txtRemainingExposure = New System.Windows.Forms.TextBox()
        Me.txtReceipt_num = New System.Windows.Forms.TextBox()
        Me.chkReceipt_num = New System.Windows.Forms.CheckBox()
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTier
        '
        Me.txtTier.Location = New System.Drawing.Point(123, 634)
        Me.txtTier.Name = "txtTier"
        Me.txtTier.ReadOnly = True
        Me.txtTier.Size = New System.Drawing.Size(71, 20)
        Me.txtTier.TabIndex = 138
        Me.txtTier.Visible = False
        '
        'ChkCOO
        '
        Me.ChkCOO.AutoSize = True
        Me.ChkCOO.Location = New System.Drawing.Point(92, 432)
        Me.ChkCOO.Name = "ChkCOO"
        Me.ChkCOO.Size = New System.Drawing.Size(112, 17)
        Me.ChkCOO.TabIndex = 137
        Me.ChkCOO.Text = "Country of Original"
        Me.ChkCOO.UseVisualStyleBackColor = True
        '
        'txtCOO
        '
        Me.txtCOO.Location = New System.Drawing.Point(217, 430)
        Me.txtCOO.Name = "txtCOO"
        Me.txtCOO.Size = New System.Drawing.Size(160, 20)
        Me.txtCOO.TabIndex = 136
        Me.txtCOO.Text = "N/A"
        '
        'NudSerializedLabel
        '
        Me.NudSerializedLabel.Location = New System.Drawing.Point(211, 596)
        Me.NudSerializedLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudSerializedLabel.Name = "NudSerializedLabel"
        Me.NudSerializedLabel.Size = New System.Drawing.Size(56, 20)
        Me.NudSerializedLabel.TabIndex = 134
        Me.NudSerializedLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(55, 597)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Number of serialized labels"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(212, 569)
        Me.nudCopiesOfLabel.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel.TabIndex = 132
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(55, 569)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Identical copies of labels"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(218, 376)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(159, 20)
        Me.txtCustomer.TabIndex = 131
        '
        'ChkCustomer
        '
        Me.ChkCustomer.AutoSize = True
        Me.ChkCustomer.Location = New System.Drawing.Point(104, 378)
        Me.ChkCustomer.Name = "ChkCustomer"
        Me.ChkCustomer.Size = New System.Drawing.Size(101, 17)
        Me.ChkCustomer.TabIndex = 130
        Me.ChkCustomer.Text = "Customer Name"
        Me.ChkCustomer.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(211, 631)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(162, 27)
        Me.btnPrint.TabIndex = 129
        Me.btnPrint.Text = "Assign New ID  && Print  (F4)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkDEV)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtComponentID)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 74)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        '
        'chkDEV
        '
        Me.chkDEV.AutoSize = True
        Me.chkDEV.Location = New System.Drawing.Point(736, 30)
        Me.chkDEV.Name = "chkDEV"
        Me.chkDEV.Size = New System.Drawing.Size(142, 17)
        Me.chkDEV.TabIndex = 161
        Me.chkDEV.Text = "Print With DEV Extened "
        Me.chkDEV.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radRCV)
        Me.GroupBox4.Controls.Add(Me.radRTN)
        Me.GroupBox4.Controls.Add(Me.radSPL)
        Me.GroupBox4.Location = New System.Drawing.Point(532, 17)
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
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(91, 19)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(189, 20)
        Me.txtComponentID.TabIndex = 58
        Me.txtComponentID.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radOther)
        Me.GroupBox2.Controls.Add(Me.radpcb)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 46)
        Me.GroupBox2.TabIndex = 147
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(61, 16)
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
        Me.radpcb.Location = New System.Drawing.Point(6, 15)
        Me.radpcb.Name = "radpcb"
        Me.radpcb.Size = New System.Drawing.Size(39, 17)
        Me.radpcb.TabIndex = 0
        Me.radpcb.TabStop = True
        Me.radpcb.Text = "WI"
        Me.radpcb.UseVisualStyleBackColor = True
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
        'tbnSearch
        '
        Me.tbnSearch.Location = New System.Drawing.Point(286, 17)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 57
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = True
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(103, 351)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(107, 17)
        Me.chkLoc.TabIndex = 127
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(98, 248)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(107, 17)
        Me.chkDateCode.TabIndex = 126
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(106, 221)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(99, 17)
        Me.chkLotCode.TabIndex = 125
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(152, 194)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(53, 17)
        Me.ChkMfger.TabIndex = 121
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(122, 167)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(83, 17)
        Me.ChkUnigenPN.TabIndex = 120
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(129, 140)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(76, 17)
        Me.ChkMfgPN.TabIndex = 119
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'txtOriginQty
        '
        Me.txtOriginQty.Location = New System.Drawing.Point(217, 321)
        Me.txtOriginQty.Name = "txtOriginQty"
        Me.txtOriginQty.ReadOnly = True
        Me.txtOriginQty.Size = New System.Drawing.Size(160, 20)
        Me.txtOriginQty.TabIndex = 113
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
        Me.CheckBox1.TabIndex = 124
        Me.CheckBox1.Text = "Origin Qty"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtQtyPackage
        '
        Me.txtQtyPackage.Location = New System.Drawing.Point(218, 295)
        Me.txtQtyPackage.Name = "txtQtyPackage"
        Me.txtQtyPackage.Size = New System.Drawing.Size(160, 20)
        Me.txtQtyPackage.TabIndex = 114
        '
        'ChkQty
        '
        Me.ChkQty.AutoSize = True
        Me.ChkQty.Checked = True
        Me.ChkQty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkQty.Location = New System.Drawing.Point(112, 297)
        Me.ChkQty.Name = "ChkQty"
        Me.ChkQty.Size = New System.Drawing.Size(93, 17)
        Me.ChkQty.TabIndex = 123
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
        Me.chkFirmware.TabIndex = 122
        Me.chkFirmware.Text = "Firmware && Rev (Opt.)"
        Me.chkFirmware.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 117
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
        Me.lblUser.TabIndex = 116
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkpo
        '
        Me.chkpo.Checked = True
        Me.chkpo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpo.Location = New System.Drawing.Point(149, 106)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(56, 24)
        Me.chkpo.TabIndex = 118
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirmware
        '
        Me.txtFirmware.Location = New System.Drawing.Point(218, 268)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(160, 20)
        Me.txtFirmware.TabIndex = 112
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(218, 241)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCode.TabIndex = 111
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(218, 214)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(160, 20)
        Me.txtLotCode.TabIndex = 110
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(218, 187)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(160, 20)
        Me.txtMfger.TabIndex = 109
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(218, 133)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(160, 20)
        Me.txtMfgPN.TabIndex = 107
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(218, 106)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.TabIndex = 106
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(218, 349)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(160, 20)
        Me.txtLoc.TabIndex = 115
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(218, 160)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(160, 20)
        Me.txtPN.TabIndex = 108
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(150, 510)
        Me.lblVendor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(41, 13)
        Me.lblVendor.TabIndex = 144
        Me.lblVendor.Text = "Vendor"
        '
        'lblDesctiption
        '
        Me.lblDesctiption.AutoSize = True
        Me.lblDesctiption.Location = New System.Drawing.Point(129, 483)
        Me.lblDesctiption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesctiption.Name = "lblDesctiption"
        Me.lblDesctiption.Size = New System.Drawing.Size(60, 13)
        Me.lblDesctiption.TabIndex = 143
        Me.lblDesctiption.Text = "Description"
        '
        'txtvendor
        '
        Me.txtvendor.Location = New System.Drawing.Point(216, 510)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.ReadOnly = True
        Me.txtvendor.Size = New System.Drawing.Size(469, 20)
        Me.txtvendor.TabIndex = 142
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(216, 483)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(469, 20)
        Me.txtDescription.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 457)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "MSL"
        '
        'txtMSL
        '
        Me.txtMSL.Location = New System.Drawing.Point(216, 457)
        Me.txtMSL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMSL.Name = "txtMSL"
        Me.txtMSL.Size = New System.Drawing.Size(213, 20)
        Me.txtMSL.TabIndex = 139
        '
        'chkRemainExposure
        '
        Me.chkRemainExposure.AutoSize = True
        Me.chkRemainExposure.Location = New System.Drawing.Point(85, 542)
        Me.chkRemainExposure.Name = "chkRemainExposure"
        Me.chkRemainExposure.Size = New System.Drawing.Size(123, 17)
        Me.chkRemainExposure.TabIndex = 146
        Me.chkRemainExposure.Text = " RemainingExposure"
        Me.chkRemainExposure.UseVisualStyleBackColor = True
        '
        'txtRemainingExposure
        '
        Me.txtRemainingExposure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemainingExposure.ForeColor = System.Drawing.Color.Red
        Me.txtRemainingExposure.Location = New System.Drawing.Point(217, 538)
        Me.txtRemainingExposure.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemainingExposure.Name = "txtRemainingExposure"
        Me.txtRemainingExposure.ReadOnly = True
        Me.txtRemainingExposure.Size = New System.Drawing.Size(215, 23)
        Me.txtRemainingExposure.TabIndex = 145
        Me.txtRemainingExposure.Text = " "
        '
        'txtReceipt_num
        '
        Me.txtReceipt_num.Location = New System.Drawing.Point(217, 402)
        Me.txtReceipt_num.Name = "txtReceipt_num"
        Me.txtReceipt_num.Size = New System.Drawing.Size(159, 20)
        Me.txtReceipt_num.TabIndex = 148
        '
        'chkReceipt_num
        '
        Me.chkReceipt_num.AutoSize = True
        Me.chkReceipt_num.Location = New System.Drawing.Point(103, 404)
        Me.chkReceipt_num.Name = "chkReceipt_num"
        Me.chkReceipt_num.Size = New System.Drawing.Size(89, 17)
        Me.chkReceipt_num.TabIndex = 147
        Me.chkReceipt_num.Text = "Receipt_num"
        Me.chkReceipt_num.UseVisualStyleBackColor = True
        '
        'frmConvert_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 683)
        Me.Controls.Add(Me.txtReceipt_num)
        Me.Controls.Add(Me.chkReceipt_num)
        Me.Controls.Add(Me.chkRemainExposure)
        Me.Controls.Add(Me.txtRemainingExposure)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.lblDesctiption)
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
        Me.Name = "frmConvert_Material"
        Me.Text = "frmConvert_Material"
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTier As System.Windows.Forms.TextBox
    Friend WithEvents ChkCOO As System.Windows.Forms.CheckBox
    Friend WithEvents txtCOO As System.Windows.Forms.TextBox
    Friend WithEvents NudSerializedLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudCopiesOfLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents ChkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
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
    Friend WithEvents chkRemainExposure As System.Windows.Forms.CheckBox
    Friend WithEvents txtRemainingExposure As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radpcb As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radRCV As System.Windows.Forms.RadioButton
    Friend WithEvents radRTN As System.Windows.Forms.RadioButton
    Friend WithEvents radSPL As System.Windows.Forms.RadioButton
    Friend WithEvents chkDEV As System.Windows.Forms.CheckBox
    Friend WithEvents txtReceipt_num As TextBox
    Friend WithEvents chkReceipt_num As CheckBox
End Class
