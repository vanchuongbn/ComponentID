<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Re_PrintComponentID
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
        Me.chkDateCode = New System.Windows.Forms.CheckBox()
        Me.chkLotCode = New System.Windows.Forms.CheckBox()
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown()
        Me.txtDateCode = New System.Windows.Forms.TextBox()
        Me.txtLotCode = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtQtyPer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblControlID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox()
        Me.txtMfgPN = New System.Windows.Forms.TextBox()
        Me.chkpo = New System.Windows.Forms.CheckBox()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.ChkMfger = New System.Windows.Forms.CheckBox()
        Me.txtMfger = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkLoc = New System.Windows.Forms.CheckBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtOriginQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkIntem = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radRCV = New System.Windows.Forms.RadioButton()
        Me.radRTN = New System.Windows.Forms.RadioButton()
        Me.radSPL = New System.Windows.Forms.RadioButton()
        Me.chkDEV = New System.Windows.Forms.CheckBox()
        Me.checkbox_ESDS = New System.Windows.Forms.CheckBox()
        Me.Checkbox_noneInspect = New System.Windows.Forms.CheckBox()
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(80, 311)
        Me.chkDateCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(157, 24)
        Me.chkDateCode.TabIndex = 35
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(92, 271)
        Me.chkLotCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(145, 24)
        Me.chkLotCode.TabIndex = 34
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(261, 462)
        Me.nudCopiesOfLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCopiesOfLabel.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(84, 26)
        Me.nudCopiesOfLabel.TabIndex = 4
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(260, 311)
        Me.txtDateCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(238, 26)
        Me.txtDateCode.TabIndex = 3
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(260, 269)
        Me.txtLotCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(238, 26)
        Me.txtLotCode.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(542, 437)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(180, 38)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Save  && Print  (F4)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(45, 462)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 31)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Identical copies of labels"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Component ID:"
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(260, 37)
        Me.txtComponentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(418, 26)
        Me.txtComponentID.TabIndex = 0
        Me.txtComponentID.Text = " "
        '
        'DGV
        '
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(18, 509)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidth = 62
        Me.DGV.Size = New System.Drawing.Size(1604, 418)
        Me.DGV.TabIndex = 7
        '
        'txtQtyPer
        '
        Me.txtQtyPer.Location = New System.Drawing.Point(260, 351)
        Me.txtQtyPer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQtyPer.Name = "txtQtyPer"
        Me.txtQtyPer.Size = New System.Drawing.Size(128, 26)
        Me.txtQtyPer.TabIndex = 1
        Me.txtQtyPer.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 355)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = " Qty /Package"
        '
        'lblControlID
        '
        Me.lblControlID.AutoSize = True
        Me.lblControlID.Location = New System.Drawing.Point(717, 42)
        Me.lblControlID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblControlID.Name = "lblControlID"
        Me.lblControlID.Size = New System.Drawing.Size(17, 20)
        Me.lblControlID.TabIndex = 38
        Me.lblControlID.Text = " ."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 82)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "User:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(312, 82)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.MaximumSize = New System.Drawing.Size(240, 0)
        Me.lblUser.MinimumSize = New System.Drawing.Size(240, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(240, 20)
        Me.lblUser.TabIndex = 44
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(136, 155)
        Me.ChkMfgPN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(105, 24)
        Me.ChkMfgPN.TabIndex = 47
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(260, 155)
        Me.txtMfgPN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(238, 26)
        Me.txtMfgPN.TabIndex = 46
        '
        'chkpo
        '
        Me.chkpo.Location = New System.Drawing.Point(166, 114)
        Me.chkpo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(84, 37)
        Me.chkpo.TabIndex = 49
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(260, 117)
        Me.txtPO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(238, 26)
        Me.txtPO.TabIndex = 48
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(126, 197)
        Me.ChkUnigenPN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(115, 24)
        Me.ChkUnigenPN.TabIndex = 51
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(260, 195)
        Me.txtPN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(238, 26)
        Me.txtPN.TabIndex = 50
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(166, 235)
        Me.ChkMfger.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(76, 24)
        Me.ChkMfger.TabIndex = 53
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(260, 232)
        Me.txtMfger.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(238, 26)
        Me.txtMfger.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "User Name:"
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(80, 420)
        Me.chkLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(157, 24)
        Me.chkLoc.TabIndex = 58
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(260, 420)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(238, 26)
        Me.txtLoc.TabIndex = 57
        '
        'txtOriginQty
        '
        Me.txtOriginQty.Location = New System.Drawing.Point(260, 385)
        Me.txtOriginQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOriginQty.Name = "txtOriginQty"
        Me.txtOriginQty.Size = New System.Drawing.Size(128, 26)
        Me.txtOriginQty.TabIndex = 1
        Me.txtOriginQty.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 389)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = " Qrigin Qty"
        '
        'chkIntem
        '
        Me.chkIntem.AutoSize = True
        Me.chkIntem.Location = New System.Drawing.Point(730, 445)
        Me.chkIntem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkIntem.Name = "chkIntem"
        Me.chkIntem.Size = New System.Drawing.Size(99, 24)
        Me.chkIntem.TabIndex = 59
        Me.chkIntem.Text = "In lai tem"
        Me.chkIntem.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radRCV)
        Me.GroupBox4.Controls.Add(Me.radRTN)
        Me.GroupBox4.Controls.Add(Me.radSPL)
        Me.GroupBox4.Location = New System.Drawing.Point(764, 18)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(297, 62)
        Me.GroupBox4.TabIndex = 158
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " "
        '
        'radRCV
        '
        Me.radRCV.AutoSize = True
        Me.radRCV.Location = New System.Drawing.Point(180, 20)
        Me.radRCV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radRCV.Name = "radRCV"
        Me.radRCV.Size = New System.Drawing.Size(68, 24)
        Me.radRCV.TabIndex = 0
        Me.radRCV.TabStop = True
        Me.radRCV.Text = "RCV"
        Me.radRCV.UseVisualStyleBackColor = True
        '
        'radRTN
        '
        Me.radRTN.AutoSize = True
        Me.radRTN.Location = New System.Drawing.Point(92, 22)
        Me.radRTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radRTN.Name = "radRTN"
        Me.radRTN.Size = New System.Drawing.Size(66, 24)
        Me.radRTN.TabIndex = 0
        Me.radRTN.TabStop = True
        Me.radRTN.Text = "RTN"
        Me.radRTN.UseVisualStyleBackColor = True
        '
        'radSPL
        '
        Me.radSPL.AutoSize = True
        Me.radSPL.Location = New System.Drawing.Point(9, 22)
        Me.radSPL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radSPL.Name = "radSPL"
        Me.radSPL.Size = New System.Drawing.Size(64, 24)
        Me.radSPL.TabIndex = 0
        Me.radSPL.TabStop = True
        Me.radSPL.Text = "SPL"
        Me.radSPL.UseVisualStyleBackColor = True
        '
        'chkDEV
        '
        Me.chkDEV.AutoSize = True
        Me.chkDEV.Location = New System.Drawing.Point(1070, 42)
        Me.chkDEV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDEV.Name = "chkDEV"
        Me.chkDEV.Size = New System.Drawing.Size(208, 24)
        Me.chkDEV.TabIndex = 161
        Me.chkDEV.Text = "Print With DEV Extened "
        Me.chkDEV.UseVisualStyleBackColor = True
        '
        'checkbox_ESDS
        '
        Me.checkbox_ESDS.AutoSize = True
        Me.checkbox_ESDS.Location = New System.Drawing.Point(542, 120)
        Me.checkbox_ESDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkbox_ESDS.Name = "checkbox_ESDS"
        Me.checkbox_ESDS.Size = New System.Drawing.Size(80, 24)
        Me.checkbox_ESDS.TabIndex = 162
        Me.checkbox_ESDS.Text = "ESDS"
        Me.checkbox_ESDS.UseVisualStyleBackColor = True
        '
        'Checkbox_noneInspect
        '
        Me.Checkbox_noneInspect.AutoSize = True
        Me.Checkbox_noneInspect.Location = New System.Drawing.Point(542, 157)
        Me.Checkbox_noneInspect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Checkbox_noneInspect.Name = "Checkbox_noneInspect"
        Me.Checkbox_noneInspect.Size = New System.Drawing.Size(122, 24)
        Me.Checkbox_noneInspect.TabIndex = 163
        Me.Checkbox_noneInspect.Text = "Non-Inspect"
        Me.Checkbox_noneInspect.UseVisualStyleBackColor = True
        '
        'Re_PrintComponentID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 931)
        Me.Controls.Add(Me.Checkbox_noneInspect)
        Me.Controls.Add(Me.checkbox_ESDS)
        Me.Controls.Add(Me.chkDEV)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkIntem)
        Me.Controls.Add(Me.chkLoc)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChkMfger)
        Me.Controls.Add(Me.txtMfger)
        Me.Controls.Add(Me.ChkUnigenPN)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.chkpo)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.ChkMfgPN)
        Me.Controls.Add(Me.txtMfgPN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblControlID)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOriginQty)
        Me.Controls.Add(Me.txtQtyPer)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.chkDateCode)
        Me.Controls.Add(Me.chkLotCode)
        Me.Controls.Add(Me.nudCopiesOfLabel)
        Me.Controls.Add(Me.txtDateCode)
        Me.Controls.Add(Me.txtLotCode)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Re_PrintComponentID"
        Me.Text = "Re_PrintComponentID"
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDateCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotCode As System.Windows.Forms.CheckBox
    Friend WithEvents nudCopiesOfLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDateCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLotCode As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtQtyPer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblControlID As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents ChkMfgPN As System.Windows.Forms.CheckBox
    Friend WithEvents txtMfgPN As System.Windows.Forms.TextBox
    Friend WithEvents chkpo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents ChkUnigenPN As System.Windows.Forms.CheckBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents ChkMfger As System.Windows.Forms.CheckBox
    Friend WithEvents txtMfger As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtOriginQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkIntem As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radRCV As System.Windows.Forms.RadioButton
    Friend WithEvents radRTN As System.Windows.Forms.RadioButton
    Friend WithEvents radSPL As System.Windows.Forms.RadioButton
    Friend WithEvents chkDEV As System.Windows.Forms.CheckBox
    Friend WithEvents checkbox_ESDS As CheckBox
    Friend WithEvents Checkbox_noneInspect As CheckBox
End Class
