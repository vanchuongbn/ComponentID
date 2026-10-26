<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteComponetID
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
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnSearch = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.controlID = New System.Windows.Forms.Label()
        Me.controlID_WH = New System.Windows.Forms.Label()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(12, 108)
        Me.txtComponentID.Multiline = True
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComponentID.Size = New System.Drawing.Size(317, 532)
        Me.txtComponentID.TabIndex = 61
        Me.txtComponentID.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Component ID"
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbnSearch.Location = New System.Drawing.Point(117, 50)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 60
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(335, 108)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1460, 532)
        Me.DataGridView2.TabIndex = 63
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(335, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 77)
        Me.btnDelete.TabIndex = 64
        Me.btnDelete.Text = "Delete ComponnetID"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'controlID
        '
        Me.controlID.AutoSize = True
        Me.controlID.BackColor = System.Drawing.Color.White
        Me.controlID.Location = New System.Drawing.Point(1716, 21)
        Me.controlID.Name = "controlID"
        Me.controlID.Size = New System.Drawing.Size(54, 13)
        Me.controlID.TabIndex = 65
        Me.controlID.Text = " ControlID"
        '
        'controlID_WH
        '
        Me.controlID_WH.AutoSize = True
        Me.controlID_WH.BackColor = System.Drawing.Color.White
        Me.controlID_WH.Location = New System.Drawing.Point(1716, 41)
        Me.controlID_WH.Name = "controlID_WH"
        Me.controlID_WH.Size = New System.Drawing.Size(79, 13)
        Me.controlID_WH.TabIndex = 65
        Me.controlID_WH.Text = " ControlID_WH"
        '
        'btnImportExcel
        '
        Me.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnImportExcel.Location = New System.Drawing.Point(15, 50)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(96, 23)
        Me.btnImportExcel.TabIndex = 60
        Me.btnImportExcel.Text = "Import file excel "
        Me.btnImportExcel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(198, 50)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 60
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(103, 87)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.lbltotal.TabIndex = 62
        Me.lbltotal.Text = "Total"
        '
        'frmDeleteComponetID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1807, 652)
        Me.Controls.Add(Me.controlID_WH)
        Me.Controls.Add(Me.controlID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbnSearch)
        Me.Name = "frmDeleteComponetID"
        Me.Text = "frmDeleteComponetID"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents controlID As System.Windows.Forms.Label
    Friend WithEvents controlID_WH As System.Windows.Forms.Label
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lbltotal As Label
End Class
