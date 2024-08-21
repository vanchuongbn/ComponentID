<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtComponentID = New System.Windows.Forms.TextBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.btnComSearch = New System.Windows.Forms.Button
        Me.btnPnSearch = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnPOSearch = New System.Windows.Forms.Button
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ComponentID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unigen Part Number"
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(193, 13)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(212, 20)
        Me.txtComponentID.TabIndex = 2
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(193, 47)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(212, 20)
        Me.txtPN.TabIndex = 3
        '
        'btnComSearch
        '
        Me.btnComSearch.Location = New System.Drawing.Point(426, 12)
        Me.btnComSearch.Name = "btnComSearch"
        Me.btnComSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnComSearch.TabIndex = 4
        Me.btnComSearch.Text = "Search"
        Me.btnComSearch.UseVisualStyleBackColor = True
        '
        'btnPnSearch
        '
        Me.btnPnSearch.Location = New System.Drawing.Point(426, 47)
        Me.btnPnSearch.Name = "btnPnSearch"
        Me.btnPnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnPnSearch.TabIndex = 5
        Me.btnPnSearch.Text = "Search"
        Me.btnPnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(927, 440)
        Me.DataGridView1.TabIndex = 6
        '
        'btnPOSearch
        '
        Me.btnPOSearch.Location = New System.Drawing.Point(426, 84)
        Me.btnPOSearch.Name = "btnPOSearch"
        Me.btnPOSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnPOSearch.TabIndex = 9
        Me.btnPOSearch.Text = "Search"
        Me.btnPOSearch.UseVisualStyleBackColor = True
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(193, 81)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(212, 20)
        Me.txtPO.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PO"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 566)
        Me.Controls.Add(Me.btnPOSearch)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPnSearch)
        Me.Controls.Add(Me.btnComSearch)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSearch"
        Me.Text = "Search Component Info"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComponentID As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents btnComSearch As System.Windows.Forms.Button
    Friend WithEvents btnPnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPOSearch As System.Windows.Forms.Button
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
