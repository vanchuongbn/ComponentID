<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMRB
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbnSearch = New System.Windows.Forms.Button()
        Me.rdInMRB = New System.Windows.Forms.RadioButton()
        Me.rdOutMRB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.controlID_WH = New System.Windows.Forms.Label()
        Me.controlID = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Red
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(558, 36)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(219, 50)
        Me.btnUpdate.TabIndex = 72
        Me.btnUpdate.Text = "Update ComponnetID MRB"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(338, 94)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1460, 746)
        Me.DataGridView2.TabIndex = 71
        '
        'txtComponentID
        '
        Me.txtComponentID.Location = New System.Drawing.Point(15, 94)
        Me.txtComponentID.Multiline = True
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComponentID.Size = New System.Drawing.Size(317, 746)
        Me.txtComponentID.TabIndex = 68
        Me.txtComponentID.Text = " "
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltotal.Location = New System.Drawing.Point(106, 73)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.lbltotal.TabIndex = 69
        Me.lbltotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Component ID"
        '
        'btnImportExcel
        '
        Me.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnImportExcel.Location = New System.Drawing.Point(18, 36)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(96, 23)
        Me.btnImportExcel.TabIndex = 65
        Me.btnImportExcel.Text = "Import file excel "
        Me.btnImportExcel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(201, 36)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 66
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'tbnSearch
        '
        Me.tbnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbnSearch.Location = New System.Drawing.Point(120, 36)
        Me.tbnSearch.Name = "tbnSearch"
        Me.tbnSearch.Size = New System.Drawing.Size(75, 23)
        Me.tbnSearch.TabIndex = 67
        Me.tbnSearch.Text = "Search"
        Me.tbnSearch.UseVisualStyleBackColor = False
        '
        'rdInMRB
        '
        Me.rdInMRB.AutoSize = True
        Me.rdInMRB.ForeColor = System.Drawing.Color.White
        Me.rdInMRB.Location = New System.Drawing.Point(21, 20)
        Me.rdInMRB.Name = "rdInMRB"
        Me.rdInMRB.Size = New System.Drawing.Size(63, 17)
        Me.rdInMRB.TabIndex = 73
        Me.rdInMRB.TabStop = True
        Me.rdInMRB.Text = "IN MRB"
        Me.rdInMRB.UseVisualStyleBackColor = True
        '
        'rdOutMRB
        '
        Me.rdOutMRB.AutoSize = True
        Me.rdOutMRB.ForeColor = System.Drawing.Color.White
        Me.rdOutMRB.Location = New System.Drawing.Point(90, 19)
        Me.rdOutMRB.Name = "rdOutMRB"
        Me.rdOutMRB.Size = New System.Drawing.Size(75, 17)
        Me.rdOutMRB.TabIndex = 73
        Me.rdOutMRB.TabStop = True
        Me.rdOutMRB.Text = "OUT MRB"
        Me.rdOutMRB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdOutMRB)
        Me.GroupBox1.Controls.Add(Me.rdInMRB)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(338, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 47)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MRB Type"
        '
        'controlID_WH
        '
        Me.controlID_WH.AutoSize = True
        Me.controlID_WH.BackColor = System.Drawing.Color.White
        Me.controlID_WH.Location = New System.Drawing.Point(1674, 43)
        Me.controlID_WH.Name = "controlID_WH"
        Me.controlID_WH.Size = New System.Drawing.Size(79, 13)
        Me.controlID_WH.TabIndex = 75
        Me.controlID_WH.Text = " ControlID_WH"
        '
        'controlID
        '
        Me.controlID.AutoSize = True
        Me.controlID.BackColor = System.Drawing.Color.White
        Me.controlID.Location = New System.Drawing.Point(1674, 23)
        Me.controlID.Name = "controlID"
        Me.controlID.Size = New System.Drawing.Size(54, 13)
        Me.controlID.TabIndex = 76
        Me.controlID.Text = " ControlID"
        '
        'frmUpdateMRB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1791, 852)
        Me.Controls.Add(Me.controlID_WH)
        Me.Controls.Add(Me.controlID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtComponentID)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbnSearch)
        Me.Name = "frmUpdateMRB"
        Me.Text = "frmUpdateMRB"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtComponentID As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents tbnSearch As Button
    Friend WithEvents rdInMRB As RadioButton
    Friend WithEvents rdOutMRB As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents controlID_WH As Label
    Friend WithEvents controlID As Label
End Class
