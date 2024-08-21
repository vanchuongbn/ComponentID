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
        Me.txtComponentID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbnSearch = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btnDelete = New System.Windows.Forms.Button
        Me.controlID = New System.Windows.Forms.Label
        Me.controlID_WH = New System.Windows.Forms.Label
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(90, 33)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(248, 20)
        Me.txtComponentID.TabIndex = 61
        Me.txtComponentID.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Component ID"
        '
        'tbnSearch
        '
        Me.tbnSearch.Location = New System.Drawing.Point(344, 33)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 60
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1043, 163)
        Me.DataGridView2.TabIndex = 63
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(519, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 77)
        Me.btnDelete.TabIndex = 64
        Me.btnDelete.Text = "Delete ComponnetID"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'controlID
        '
        Me.controlID.AutoSize = True
        Me.controlID.Location = New System.Drawing.Point(773, 23)
        Me.controlID.Name = "controlID"
        Me.controlID.Size = New System.Drawing.Size(54, 13)
        Me.controlID.TabIndex = 65
        Me.controlID.Text = " ControlID"
        '
        'controlID_WH
        '
        Me.controlID_WH.AutoSize = True
        Me.controlID_WH.Location = New System.Drawing.Point(773, 43)
        Me.controlID_WH.Name = "controlID_WH"
        Me.controlID_WH.Size = New System.Drawing.Size(79, 13)
        Me.controlID_WH.TabIndex = 65
        Me.controlID_WH.Text = " ControlID_WH"
        '
        'frmDeleteComponetID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 292)
        Me.Controls.Add(Me.controlID_WH)
        Me.Controls.Add(Me.controlID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.Label1)
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
End Class
