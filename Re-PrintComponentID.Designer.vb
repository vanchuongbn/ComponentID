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
        Me.chkDateCode = New System.Windows.Forms.CheckBox
        Me.chkLotCode = New System.Windows.Forms.CheckBox
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown
        Me.txtDateCode = New System.Windows.Forms.TextBox
        Me.txtLotCode = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtComponentID = New System.Windows.Forms.TextBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.txtQtyPer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblControlID = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox
        Me.txtMfgPN = New System.Windows.Forms.TextBox
        Me.chkpo = New System.Windows.Forms.CheckBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.ChkMfger = New System.Windows.Forms.CheckBox
        Me.txtMfger = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.txtOriginQty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkIntem = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.radRCV = New System.Windows.Forms.RadioButton
        Me.radRTN = New System.Windows.Forms.RadioButton
        Me.radSPL = New System.Windows.Forms.RadioButton
        Me.chkDEV = New System.Windows.Forms.CheckBox
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(53, 202)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(107, 17)
        Me.chkDateCode.TabIndex = 35
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(61, 176)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(99, 17)
        Me.chkLotCode.TabIndex = 34
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(174, 300)
        Me.nudCopiesOfLabel.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel.TabIndex = 4
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(173, 202)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCode.TabIndex = 3
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(173, 175)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(160, 20)
        Me.txtLotCode.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(361, 284)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 25)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Save  && Print  (F4)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(30, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Identical copies of labels"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Component ID:"
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(173, 24)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(280, 20)
        Me.txtComponentID.TabIndex = 0
        Me.txtComponentID.Text = " "
        '
        'DGV
        '
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 331)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1069, 272)
        Me.DGV.TabIndex = 7
        '
        'txtQtyPer
        '
        Me.txtQtyPer.Location = New System.Drawing.Point(173, 228)
        Me.txtQtyPer.Name = "txtQtyPer"
        Me.txtQtyPer.Size = New System.Drawing.Size(87, 20)
        Me.txtQtyPer.TabIndex = 1
        Me.txtQtyPer.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = " Qty /Package"
        '
        'lblControlID
        '
        Me.lblControlID.AutoSize = True
        Me.lblControlID.Location = New System.Drawing.Point(478, 27)
        Me.lblControlID.Name = "lblControlID"
        Me.lblControlID.Size = New System.Drawing.Size(13, 13)
        Me.lblControlID.TabIndex = 38
        Me.lblControlID.Text = " ."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(170, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "User:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(208, 53)
        Me.lblUser.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.MinimumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(160, 13)
        Me.lblUser.TabIndex = 44
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(91, 101)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(76, 17)
        Me.ChkMfgPN.TabIndex = 47
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(173, 101)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(160, 20)
        Me.txtMfgPN.TabIndex = 46
        '
        'chkpo
        '
        Me.chkpo.Location = New System.Drawing.Point(111, 74)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(56, 24)
        Me.chkpo.TabIndex = 49
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(173, 76)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.TabIndex = 48
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(84, 128)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(83, 17)
        Me.ChkUnigenPN.TabIndex = 51
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(173, 127)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(160, 20)
        Me.txtPN.TabIndex = 50
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(111, 153)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(53, 17)
        Me.ChkMfger.TabIndex = 53
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(173, 151)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(160, 20)
        Me.txtMfger.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "User Name:"
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(53, 273)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(107, 17)
        Me.chkLoc.TabIndex = 58
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(173, 273)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(160, 20)
        Me.txtLoc.TabIndex = 57
        '
        'txtOriginQty
        '
        Me.txtOriginQty.Location = New System.Drawing.Point(173, 250)
        Me.txtOriginQty.Name = "txtOriginQty"
        Me.txtOriginQty.Size = New System.Drawing.Size(87, 20)
        Me.txtOriginQty.TabIndex = 1
        Me.txtOriginQty.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = " Qrigin Qty"
        '
        'chkIntem
        '
        Me.chkIntem.AutoSize = True
        Me.chkIntem.Location = New System.Drawing.Point(487, 289)
        Me.chkIntem.Name = "chkIntem"
        Me.chkIntem.Size = New System.Drawing.Size(68, 17)
        Me.chkIntem.TabIndex = 59
        Me.chkIntem.Text = "In lai tem"
        Me.chkIntem.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radRCV)
        Me.GroupBox4.Controls.Add(Me.radRTN)
        Me.GroupBox4.Controls.Add(Me.radSPL)
        Me.GroupBox4.Location = New System.Drawing.Point(509, 12)
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
        'chkDEV
        '
        Me.chkDEV.AutoSize = True
        Me.chkDEV.Location = New System.Drawing.Point(713, 27)
        Me.chkDEV.Name = "chkDEV"
        Me.chkDEV.Size = New System.Drawing.Size(142, 17)
        Me.chkDEV.TabIndex = 161
        Me.chkDEV.Text = "Print With DEV Extened "
        Me.chkDEV.UseVisualStyleBackColor = True
        '
        'Re_PrintComponentID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 605)
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
End Class
