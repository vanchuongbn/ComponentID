<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrokerExport
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
        Me.lbltotal = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.chkMFGPN = New System.Windows.Forms.CheckBox
        Me.chkUGPN = New System.Windows.Forms.CheckBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.tbnSearch = New System.Windows.Forms.Button
        Me.txtMFG = New System.Windows.Forms.TextBox
        Me.txtUGPN = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkUnauthentic = New System.Windows.Forms.CheckBox
        Me.chkAuthentic = New System.Windows.Forms.CheckBox
        Me.lblsum = New System.Windows.Forms.Label
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(12, 95)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(39, 13)
        Me.lbltotal.TabIndex = 123
        Me.lbltotal.Text = "Label1"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 111)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1817, 718)
        Me.dgv.TabIndex = 122
        '
        'chkMFGPN
        '
        Me.chkMFGPN.AutoSize = True
        Me.chkMFGPN.Location = New System.Drawing.Point(12, 66)
        Me.chkMFGPN.Name = "chkMFGPN"
        Me.chkMFGPN.Size = New System.Drawing.Size(75, 17)
        Me.chkMFGPN.TabIndex = 117
        Me.chkMFGPN.Text = " MFG P/N"
        Me.chkMFGPN.UseVisualStyleBackColor = True
        '
        'chkUGPN
        '
        Me.chkUGPN.AutoSize = True
        Me.chkUGPN.Location = New System.Drawing.Point(12, 40)
        Me.chkUGPN.Name = "chkUGPN"
        Me.chkUGPN.Size = New System.Drawing.Size(83, 17)
        Me.chkUGPN.TabIndex = 118
        Me.chkUGPN.Text = "Unigen P/N"
        Me.chkUGPN.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(753, 43)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 42)
        Me.btnExport.TabIndex = 115
        Me.btnExport.Text = " Export Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnSearch.Location = New System.Drawing.Point(637, 43)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(110, 42)
        Me.tbnSearch.TabIndex = 116
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'txtMFG
        '
        Me.txtMFG.ForeColor = System.Drawing.Color.Blue
        Me.txtMFG.Location = New System.Drawing.Point(101, 64)
        Me.txtMFG.Name = "txtMFG"
        Me.txtMFG.Size = New System.Drawing.Size(325, 20)
        Me.txtMFG.TabIndex = 113
        '
        'txtUGPN
        '
        Me.txtUGPN.ForeColor = System.Drawing.Color.Blue
        Me.txtUGPN.Location = New System.Drawing.Point(101, 38)
        Me.txtUGPN.Name = "txtUGPN"
        Me.txtUGPN.Size = New System.Drawing.Size(325, 20)
        Me.txtUGPN.TabIndex = 114
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkUnauthentic)
        Me.GroupBox1.Controls.Add(Me.chkAuthentic)
        Me.GroupBox1.Location = New System.Drawing.Point(450, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 59)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        '
        'chkUnauthentic
        '
        Me.chkUnauthentic.AutoSize = True
        Me.chkUnauthentic.Location = New System.Drawing.Point(6, 35)
        Me.chkUnauthentic.Name = "chkUnauthentic"
        Me.chkUnauthentic.Size = New System.Drawing.Size(85, 17)
        Me.chkUnauthentic.TabIndex = 0
        Me.chkUnauthentic.Text = "UnAuthentic"
        Me.chkUnauthentic.UseVisualStyleBackColor = True
        '
        'chkAuthentic
        '
        Me.chkAuthentic.AutoSize = True
        Me.chkAuthentic.Location = New System.Drawing.Point(6, 12)
        Me.chkAuthentic.Name = "chkAuthentic"
        Me.chkAuthentic.Size = New System.Drawing.Size(71, 17)
        Me.chkAuthentic.TabIndex = 0
        Me.chkAuthentic.Text = "Authentic"
        Me.chkAuthentic.UseVisualStyleBackColor = True
        '
        'lblsum
        '
        Me.lblsum.AutoSize = True
        Me.lblsum.Location = New System.Drawing.Point(906, 92)
        Me.lblsum.Name = "lblsum"
        Me.lblsum.Size = New System.Drawing.Size(10, 13)
        Me.lblsum.TabIndex = 123
        Me.lblsum.Text = " "
        '
        'frmBrokerExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1829, 841)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblsum)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.chkMFGPN)
        Me.Controls.Add(Me.chkUGPN)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.tbnSearch)
        Me.Controls.Add(Me.txtMFG)
        Me.Controls.Add(Me.txtUGPN)
        Me.Name = "frmBrokerExport"
        Me.Text = "frmBrokerExport"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents chkMFGPN As System.Windows.Forms.CheckBox
    Friend WithEvents chkUGPN As System.Windows.Forms.CheckBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents txtMFG As System.Windows.Forms.TextBox
    Friend WithEvents txtUGPN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUnauthentic As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuthentic As System.Windows.Forms.CheckBox
    Friend WithEvents lblsum As System.Windows.Forms.Label
End Class
