<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckFIFO
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
        Me.txtUGPN_ = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.txtUGPN = New System.Windows.Forms.TextBox
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.txtDateCode = New System.Windows.Forms.TextBox
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox
        Me.chkLotCode = New System.Windows.Forms.CheckBox
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtComponent_ID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DGRFIFO = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGRFIFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(100, 27)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(325, 20)
        Me.txtComponentID.TabIndex = 0
        Me.txtComponentID.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Component ID"
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnSearch.Location = New System.Drawing.Point(494, 15)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(110, 42)
        Me.tbnSearch.TabIndex = 2
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'txtUGPN_
        '
        Me.txtUGPN_.ForeColor = System.Drawing.Color.Blue
        Me.txtUGPN_.Location = New System.Drawing.Point(100, 53)
        Me.txtUGPN_.Name = "txtUGPN_"
        Me.txtUGPN_.Size = New System.Drawing.Size(325, 20)
        Me.txtUGPN_.TabIndex = 1
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox2.TabIndex = 101
        Me.CheckBox2.Text = "Unigen P/N"
        Me.CheckBox2.UseVisualStyleBackColor = True
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
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.Blue
        Me.txtLoc.Location = New System.Drawing.Point(194, 120)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(138, 26)
        Me.txtLoc.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtComponent_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkLoc)
        Me.GroupBox1.Controls.Add(Me.chkLotCode)
        Me.GroupBox1.Controls.Add(Me.ChkUnigenPN)
        Me.GroupBox1.Controls.Add(Me.txtDateCode)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.txtUGPN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 157)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Infor ComponentID Must Out"
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
        'DGRFIFO
        '
        Me.DGRFIFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRFIFO.Location = New System.Drawing.Point(3, 276)
        Me.DGRFIFO.Name = "DGRFIFO"
        Me.DGRFIFO.Size = New System.Drawing.Size(1610, 579)
        Me.DGRFIFO.TabIndex = 110
        '
        'frmCheckFIFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1625, 856)
        Me.Controls.Add(Me.DGRFIFO)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnSearch)
        Me.Controls.Add(Me.txtUGPN_)
        Me.Name = "frmCheckFIFO"
        Me.Text = "frmCheckFIFO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGRFIFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents txtUGPN_ As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtUGPN As System.Windows.Forms.TextBox
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCode As System.Windows.Forms.TextBox
    Friend WithEvents ChkUnigenPN As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGRFIFO As System.Windows.Forms.DataGridView
    Friend WithEvents txtComponent_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
