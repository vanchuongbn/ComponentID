<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOverdateCode
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
        Me.chkUGPN = New System.Windows.Forms.CheckBox
        Me.tbnSearch = New System.Windows.Forms.Button
        Me.txtUGPN = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.chkdate = New System.Windows.Forms.CheckBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.chkMSL = New System.Windows.Forms.CheckBox
        Me.txtMFG = New System.Windows.Forms.TextBox
        Me.chkMFGPN = New System.Windows.Forms.CheckBox
        Me.lbltotal = New System.Windows.Forms.Label
        Me.cmbMsl = New System.Windows.Forms.ComboBox
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkUGPN
        '
        Me.chkUGPN.AutoSize = True
        Me.chkUGPN.Location = New System.Drawing.Point(19, 58)
        Me.chkUGPN.Name = "chkUGPN"
        Me.chkUGPN.Size = New System.Drawing.Size(83, 17)
        Me.chkUGPN.TabIndex = 106
        Me.chkUGPN.Text = "Unigen P/N"
        Me.chkUGPN.UseVisualStyleBackColor = True
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnSearch.Location = New System.Drawing.Point(449, 34)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(110, 42)
        Me.tbnSearch.TabIndex = 104
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'txtUGPN
        '
        Me.txtUGPN.ForeColor = System.Drawing.Color.Blue
        Me.txtUGPN.Location = New System.Drawing.Point(108, 56)
        Me.txtUGPN.Name = "txtUGPN"
        Me.txtUGPN.Size = New System.Drawing.Size(325, 20)
        Me.txtUGPN.TabIndex = 103
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 107
        '
        'chkdate
        '
        Me.chkdate.AutoSize = True
        Me.chkdate.Location = New System.Drawing.Point(19, 30)
        Me.chkdate.Name = "chkdate"
        Me.chkdate.Size = New System.Drawing.Size(52, 17)
        Me.chkdate.TabIndex = 106
        Me.chkdate.Text = " Date"
        Me.chkdate.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(565, 34)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 42)
        Me.btnExport.TabIndex = 104
        Me.btnExport.Text = " Export Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(14, 158)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1817, 654)
        Me.dgv.TabIndex = 108
        '
        'chkMSL
        '
        Me.chkMSL.AutoSize = True
        Me.chkMSL.Location = New System.Drawing.Point(19, 114)
        Me.chkMSL.Name = "chkMSL"
        Me.chkMSL.Size = New System.Drawing.Size(77, 17)
        Me.chkMSL.TabIndex = 106
        Me.chkMSL.Text = "MSL Level"
        Me.chkMSL.UseVisualStyleBackColor = True
        '
        'txtMFG
        '
        Me.txtMFG.ForeColor = System.Drawing.Color.Blue
        Me.txtMFG.Location = New System.Drawing.Point(108, 82)
        Me.txtMFG.Name = "txtMFG"
        Me.txtMFG.Size = New System.Drawing.Size(325, 20)
        Me.txtMFG.TabIndex = 103
        Me.txtMFG.Text = "  "
        '
        'chkMFGPN
        '
        Me.chkMFGPN.AutoSize = True
        Me.chkMFGPN.Location = New System.Drawing.Point(19, 84)
        Me.chkMFGPN.Name = "chkMFGPN"
        Me.chkMFGPN.Size = New System.Drawing.Size(75, 17)
        Me.chkMFGPN.TabIndex = 106
        Me.chkMFGPN.Text = " MFG P/N"
        Me.chkMFGPN.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(16, 142)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(39, 13)
        Me.lbltotal.TabIndex = 111
        Me.lbltotal.Text = "Label1"
        '
        'cmbMsl
        '
        Me.cmbMsl.FormattingEnabled = True
        Me.cmbMsl.Location = New System.Drawing.Point(108, 108)
        Me.cmbMsl.Name = "cmbMsl"
        Me.cmbMsl.Size = New System.Drawing.Size(121, 21)
        Me.cmbMsl.TabIndex = 112
        '
        'frmCheckOverdateCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1835, 824)
        Me.Controls.Add(Me.cmbMsl)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.chkdate)
        Me.Controls.Add(Me.chkMSL)
        Me.Controls.Add(Me.chkMFGPN)
        Me.Controls.Add(Me.chkUGPN)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.tbnSearch)
        Me.Controls.Add(Me.txtMFG)
        Me.Controls.Add(Me.txtUGPN)
        Me.Name = "frmCheckOverdateCode"
        Me.Text = "frmCheckOverdateCode"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkUGPN As System.Windows.Forms.CheckBox
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents txtUGPN As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkdate As System.Windows.Forms.CheckBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents chkMSL As System.Windows.Forms.CheckBox
    Friend WithEvents txtMFG As System.Windows.Forms.TextBox
    Friend WithEvents chkMFGPN As System.Windows.Forms.CheckBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents cmbMsl As System.Windows.Forms.ComboBox
End Class
