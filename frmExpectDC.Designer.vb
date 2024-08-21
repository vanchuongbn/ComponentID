<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpectDC
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
        Me.txtComponentID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbnSearch = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtday = New System.Windows.Forms.TextBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMinus = New System.Windows.Forms.TextBox
        Me.btnUpdate1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.btnreplate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnS = New System.Windows.Forms.Button
        Me.dapExpireDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dapExDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDC = New System.Windows.Forms.TextBox
        Me.txtUGPN = New System.Windows.Forms.TextBox
        Me.btnUpdateAll = New System.Windows.Forms.Button
        Me.lblEXChangeDate = New System.Windows.Forms.Label
        Me.lblEXpireDate = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(106, 12)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(288, 20)
        Me.txtComponentID.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Component ID"
        '
        'tbnSearch
        '
        Me.tbnSearch.Location = New System.Drawing.Point(410, 9)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 60
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 154)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1830, 320)
        Me.DGV.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(17, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Add Days: (eg: 0...1000)"
        '
        'txtday
        '
        Me.txtday.Location = New System.Drawing.Point(146, 78)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(100, 20)
        Me.txtday.TabIndex = 65
        Me.txtday.Text = " "
        '
        'btnUpdate
        '
        Me.btnUpdate.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdate.Location = New System.Drawing.Point(252, 76)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 66
        Me.btnUpdate.Text = "Update +"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 138)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 67
        Me.lblID.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Minus Days:(eg:0...1000)"
        '
        'txtMinus
        '
        Me.txtMinus.Location = New System.Drawing.Point(146, 107)
        Me.txtMinus.Name = "txtMinus"
        Me.txtMinus.Size = New System.Drawing.Size(100, 20)
        Me.txtMinus.TabIndex = 65
        Me.txtMinus.Text = " "
        '
        'btnUpdate1
        '
        Me.btnUpdate1.ForeColor = System.Drawing.Color.Red
        Me.btnUpdate1.Location = New System.Drawing.Point(252, 105)
        Me.btnUpdate1.Name = "btnUpdate1"
        Me.btnUpdate1.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate1.TabIndex = 66
        Me.btnUpdate1.Text = "Update -"
        Me.btnUpdate1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Effective date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 69
        '
        'btnreplate
        '
        Me.btnreplate.Location = New System.Drawing.Point(252, 38)
        Me.btnreplate.Name = "btnreplate"
        Me.btnreplate.Size = New System.Drawing.Size(153, 28)
        Me.btnreplate.TabIndex = 60
        Me.btnreplate.Text = "Replated Effective Date"
        Me.btnreplate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblEXpireDate)
        Me.GroupBox1.Controls.Add(Me.lblEXChangeDate)
        Me.GroupBox1.Controls.Add(Me.btnS)
        Me.GroupBox1.Controls.Add(Me.dapExpireDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dapExDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDC)
        Me.GroupBox1.Controls.Add(Me.txtUGPN)
        Me.GroupBox1.Controls.Add(Me.btnUpdateAll)
        Me.GroupBox1.Location = New System.Drawing.Point(804, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 130)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update DateExprire By UnigenPN & Datecode"
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(402, 19)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(75, 23)
        Me.btnS.TabIndex = 60
        Me.btnS.Text = "Search"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'dapExpireDate
        '
        Me.dapExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dapExpireDate.Location = New System.Drawing.Point(98, 102)
        Me.dapExpireDate.Name = "dapExpireDate"
        Me.dapExpireDate.Size = New System.Drawing.Size(100, 20)
        Me.dapExpireDate.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = " Date Expire:"
        '
        'dapExDate
        '
        Me.dapExDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dapExDate.Location = New System.Drawing.Point(98, 75)
        Me.dapExDate.Name = "dapExDate"
        Me.dapExDate.Size = New System.Drawing.Size(100, 20)
        Me.dapExDate.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Ex DateCode:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = " DateCode:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = " Unigen PN:"
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(98, 48)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(67, 20)
        Me.txtDC.TabIndex = 61
        '
        'txtUGPN
        '
        Me.txtUGPN.Location = New System.Drawing.Point(98, 22)
        Me.txtUGPN.Name = "txtUGPN"
        Me.txtUGPN.Size = New System.Drawing.Size(288, 20)
        Me.txtUGPN.TabIndex = 61
        '
        'btnUpdateAll
        '
        Me.btnUpdateAll.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateAll.Location = New System.Drawing.Point(568, 73)
        Me.btnUpdateAll.Name = "btnUpdateAll"
        Me.btnUpdateAll.Size = New System.Drawing.Size(139, 28)
        Me.btnUpdateAll.TabIndex = 60
        Me.btnUpdateAll.Text = "Update "
        Me.btnUpdateAll.UseVisualStyleBackColor = False
        '
        'lblEXChangeDate
        '
        Me.lblEXChangeDate.AutoSize = True
        Me.lblEXChangeDate.Location = New System.Drawing.Point(221, 81)
        Me.lblEXChangeDate.Name = "lblEXChangeDate"
        Me.lblEXChangeDate.Size = New System.Drawing.Size(81, 13)
        Me.lblEXChangeDate.TabIndex = 70
        Me.lblEXChangeDate.Text = "EXChangeDate"
        '
        'lblEXpireDate
        '
        Me.lblEXpireDate.AutoSize = True
        Me.lblEXpireDate.Location = New System.Drawing.Point(221, 102)
        Me.lblEXpireDate.Name = "lblEXpireDate"
        Me.lblEXpireDate.Size = New System.Drawing.Size(64, 13)
        Me.lblEXpireDate.TabIndex = 71
        Me.lblEXpireDate.Text = "EXpireDate "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(438, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "yyyy-mm-dd"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(438, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "yyyy-mm-dd"
        '
        'frmExpectDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1845, 486)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnUpdate1)
        Me.Controls.Add(Me.txtMinus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtday)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreplate)
        Me.Controls.Add(Me.tbnSearch)
        Me.Name = "frmExpectDC"
        Me.Text = "frmExpectDC"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtday As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMinus As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnreplate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents txtUGPN As System.Windows.Forms.TextBox
    Friend WithEvents dapExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dapExDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateAll As System.Windows.Forms.Button
    Friend WithEvents lblEXpireDate As System.Windows.Forms.Label
    Friend WithEvents lblEXChangeDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
