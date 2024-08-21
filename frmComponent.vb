Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmComponent
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents txtMfgPN As System.Windows.Forms.TextBox
    Friend WithEvents txtMfger As System.Windows.Forms.TextBox
    Friend WithEvents txtLotCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFirmware As System.Windows.Forms.TextBox
    Friend WithEvents chkpo As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudCopiesOfLabel As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkFirmware As System.Windows.Forms.CheckBox
    Friend WithEvents ChkQty As System.Windows.Forms.CheckBox
    Friend WithEvents txtQtyPackage As System.Windows.Forms.TextBox
    Friend WithEvents ChkMfgPN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnigenPN As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMfger As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkDateCode As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents chkLoc As System.Windows.Forms.CheckBox
    Friend WithEvents txtCOO As System.Windows.Forms.TextBox
    Friend WithEvents ChkCOO As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTier As System.Windows.Forms.CheckBox
    Friend WithEvents txtTier As System.Windows.Forms.TextBox
    Friend WithEvents lblVendor As System.Windows.Forms.Label
    Friend WithEvents lblDesctiption As System.Windows.Forms.Label
    Friend WithEvents txtvendor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMSL As System.Windows.Forms.TextBox
    Friend WithEvents NudSerializedLabel As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComponent))
        Me.btnPrint = New System.Windows.Forms.Button
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.txtPN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.txtMfgPN = New System.Windows.Forms.TextBox
        Me.txtMfger = New System.Windows.Forms.TextBox
        Me.txtLotCode = New System.Windows.Forms.TextBox
        Me.txtDateCode = New System.Windows.Forms.TextBox
        Me.txtFirmware = New System.Windows.Forms.TextBox
        Me.chkpo = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.nudCopiesOfLabel = New System.Windows.Forms.NumericUpDown
        Me.NudSerializedLabel = New System.Windows.Forms.NumericUpDown
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkFirmware = New System.Windows.Forms.CheckBox
        Me.ChkQty = New System.Windows.Forms.CheckBox
        Me.txtQtyPackage = New System.Windows.Forms.TextBox
        Me.ChkMfgPN = New System.Windows.Forms.CheckBox
        Me.ChkUnigenPN = New System.Windows.Forms.CheckBox
        Me.ChkMfger = New System.Windows.Forms.CheckBox
        Me.chkLotCode = New System.Windows.Forms.CheckBox
        Me.chkDateCode = New System.Windows.Forms.CheckBox
        Me.ChkCustomer = New System.Windows.Forms.CheckBox
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.chkLoc = New System.Windows.Forms.CheckBox
        Me.txtCOO = New System.Windows.Forms.TextBox
        Me.ChkCOO = New System.Windows.Forms.CheckBox
        Me.ChkTier = New System.Windows.Forms.CheckBox
        Me.txtTier = New System.Windows.Forms.TextBox
        Me.lblVendor = New System.Windows.Forms.Label
        Me.lblDesctiption = New System.Windows.Forms.Label
        Me.txtvendor = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMSL = New System.Windows.Forms.TextBox
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(176, 526)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 25)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print  (F4)"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(173, 302)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(160, 20)
        Me.txtLoc.TabIndex = 8
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(173, 140)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(160, 20)
        Me.txtPN.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Identical copies of labels"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(173, 86)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(160, 20)
        Me.txtPO.TabIndex = 0
        '
        'txtMfgPN
        '
        Me.txtMfgPN.Location = New System.Drawing.Point(173, 113)
        Me.txtMfgPN.Name = "txtMfgPN"
        Me.txtMfgPN.Size = New System.Drawing.Size(160, 20)
        Me.txtMfgPN.TabIndex = 1
        '
        'txtMfger
        '
        Me.txtMfger.Location = New System.Drawing.Point(173, 167)
        Me.txtMfger.Name = "txtMfger"
        Me.txtMfger.Size = New System.Drawing.Size(160, 20)
        Me.txtMfger.TabIndex = 3
        '
        'txtLotCode
        '
        Me.txtLotCode.Location = New System.Drawing.Point(173, 194)
        Me.txtLotCode.Name = "txtLotCode"
        Me.txtLotCode.Size = New System.Drawing.Size(160, 20)
        Me.txtLotCode.TabIndex = 4
        '
        'txtDateCode
        '
        Me.txtDateCode.Location = New System.Drawing.Point(173, 221)
        Me.txtDateCode.Name = "txtDateCode"
        Me.txtDateCode.Size = New System.Drawing.Size(160, 20)
        Me.txtDateCode.TabIndex = 5
        '
        'txtFirmware
        '
        Me.txtFirmware.Location = New System.Drawing.Point(173, 248)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(160, 20)
        Me.txtFirmware.TabIndex = 6
        '
        'chkpo
        '
        Me.chkpo.Checked = True
        Me.chkpo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpo.Location = New System.Drawing.Point(105, 86)
        Me.chkpo.Name = "chkpo"
        Me.chkpo.Size = New System.Drawing.Size(56, 24)
        Me.chkpo.TabIndex = 14
        Me.chkpo.Text = "PO#"
        Me.chkpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Number of serialized labels"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCopiesOfLabel
        '
        Me.nudCopiesOfLabel.Location = New System.Drawing.Point(176, 469)
        Me.nudCopiesOfLabel.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudCopiesOfLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopiesOfLabel.Name = "nudCopiesOfLabel"
        Me.nudCopiesOfLabel.Size = New System.Drawing.Size(56, 20)
        Me.nudCopiesOfLabel.TabIndex = 9
        Me.nudCopiesOfLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudSerializedLabel
        '
        Me.NudSerializedLabel.Location = New System.Drawing.Point(177, 500)
        Me.NudSerializedLabel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudSerializedLabel.Name = "NudSerializedLabel"
        Me.NudSerializedLabel.Size = New System.Drawing.Size(56, 20)
        Me.NudSerializedLabel.TabIndex = 10
        Me.NudSerializedLabel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(173, 36)
        Me.lblUser.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.MinimumSize = New System.Drawing.Size(160, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(160, 13)
        Me.lblUser.TabIndex = 12
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(128, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "User:"
        '
        'chkFirmware
        '
        Me.chkFirmware.AutoSize = True
        Me.chkFirmware.Checked = True
        Me.chkFirmware.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFirmware.Location = New System.Drawing.Point(32, 249)
        Me.chkFirmware.Name = "chkFirmware"
        Me.chkFirmware.Size = New System.Drawing.Size(129, 17)
        Me.chkFirmware.TabIndex = 20
        Me.chkFirmware.Text = "Firmware && Rev (Opt.)"
        Me.chkFirmware.UseVisualStyleBackColor = True
        '
        'ChkQty
        '
        Me.ChkQty.AutoSize = True
        Me.ChkQty.Checked = True
        Me.ChkQty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkQty.Location = New System.Drawing.Point(65, 275)
        Me.ChkQty.Name = "ChkQty"
        Me.ChkQty.Size = New System.Drawing.Size(93, 17)
        Me.ChkQty.TabIndex = 21
        Me.ChkQty.Text = "Qty /Package"
        Me.ChkQty.UseVisualStyleBackColor = True
        '
        'txtQtyPackage
        '
        Me.txtQtyPackage.Location = New System.Drawing.Point(173, 275)
        Me.txtQtyPackage.Name = "txtQtyPackage"
        Me.txtQtyPackage.Size = New System.Drawing.Size(160, 20)
        Me.txtQtyPackage.TabIndex = 7
        '
        'ChkMfgPN
        '
        Me.ChkMfgPN.AutoSize = True
        Me.ChkMfgPN.Location = New System.Drawing.Point(85, 115)
        Me.ChkMfgPN.Name = "ChkMfgPN"
        Me.ChkMfgPN.Size = New System.Drawing.Size(76, 17)
        Me.ChkMfgPN.TabIndex = 15
        Me.ChkMfgPN.Text = "Mfger P/N"
        Me.ChkMfgPN.UseVisualStyleBackColor = True
        '
        'ChkUnigenPN
        '
        Me.ChkUnigenPN.AutoSize = True
        Me.ChkUnigenPN.Location = New System.Drawing.Point(78, 142)
        Me.ChkUnigenPN.Name = "ChkUnigenPN"
        Me.ChkUnigenPN.Size = New System.Drawing.Size(83, 17)
        Me.ChkUnigenPN.TabIndex = 16
        Me.ChkUnigenPN.Text = "Unigen P/N"
        Me.ChkUnigenPN.UseVisualStyleBackColor = True
        '
        'ChkMfger
        '
        Me.ChkMfger.AutoSize = True
        Me.ChkMfger.Location = New System.Drawing.Point(108, 171)
        Me.ChkMfger.Name = "ChkMfger"
        Me.ChkMfger.Size = New System.Drawing.Size(53, 17)
        Me.ChkMfger.TabIndex = 17
        Me.ChkMfger.Text = "Mfger"
        Me.ChkMfger.UseVisualStyleBackColor = True
        '
        'chkLotCode
        '
        Me.chkLotCode.AutoSize = True
        Me.chkLotCode.Location = New System.Drawing.Point(62, 195)
        Me.chkLotCode.Name = "chkLotCode"
        Me.chkLotCode.Size = New System.Drawing.Size(99, 17)
        Me.chkLotCode.TabIndex = 25
        Me.chkLotCode.Text = "Mfger Lot Code"
        Me.chkLotCode.UseVisualStyleBackColor = True
        '
        'chkDateCode
        '
        Me.chkDateCode.AutoSize = True
        Me.chkDateCode.Location = New System.Drawing.Point(54, 223)
        Me.chkDateCode.Name = "chkDateCode"
        Me.chkDateCode.Size = New System.Drawing.Size(107, 17)
        Me.chkDateCode.TabIndex = 26
        Me.chkDateCode.Text = "Mfger Date Code"
        Me.chkDateCode.UseVisualStyleBackColor = True
        '
        'ChkCustomer
        '
        Me.ChkCustomer.AutoSize = True
        Me.ChkCustomer.Location = New System.Drawing.Point(64, 61)
        Me.ChkCustomer.Name = "ChkCustomer"
        Me.ChkCustomer.Size = New System.Drawing.Size(101, 17)
        Me.ChkCustomer.TabIndex = 27
        Me.ChkCustomer.Text = "Customer Name"
        Me.ChkCustomer.UseVisualStyleBackColor = True
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(174, 59)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(159, 20)
        Me.txtCustomer.TabIndex = 28
        '
        'chkLoc
        '
        Me.chkLoc.AutoSize = True
        Me.chkLoc.Location = New System.Drawing.Point(53, 304)
        Me.chkLoc.Name = "chkLoc"
        Me.chkLoc.Size = New System.Drawing.Size(107, 17)
        Me.chkLoc.TabIndex = 29
        Me.chkLoc.Text = "Storage Location"
        Me.chkLoc.UseVisualStyleBackColor = True
        '
        'txtCOO
        '
        Me.txtCOO.Location = New System.Drawing.Point(173, 328)
        Me.txtCOO.Name = "txtCOO"
        Me.txtCOO.Size = New System.Drawing.Size(160, 20)
        Me.txtCOO.TabIndex = 30
        Me.txtCOO.Text = "N/A"
        '
        'ChkCOO
        '
        Me.ChkCOO.AutoSize = True
        Me.ChkCOO.Location = New System.Drawing.Point(46, 331)
        Me.ChkCOO.Name = "ChkCOO"
        Me.ChkCOO.Size = New System.Drawing.Size(112, 17)
        Me.ChkCOO.TabIndex = 32
        Me.ChkCOO.Text = "Country of Original"
        Me.ChkCOO.UseVisualStyleBackColor = True
        '
        'ChkTier
        '
        Me.ChkTier.AutoSize = True
        Me.ChkTier.Location = New System.Drawing.Point(111, 357)
        Me.ChkTier.Name = "ChkTier"
        Me.ChkTier.Size = New System.Drawing.Size(44, 17)
        Me.ChkTier.TabIndex = 36
        Me.ChkTier.Text = "Tier"
        Me.ChkTier.UseVisualStyleBackColor = True
        '
        'txtTier
        '
        Me.txtTier.Location = New System.Drawing.Point(173, 354)
        Me.txtTier.Name = "txtTier"
        Me.txtTier.Size = New System.Drawing.Size(120, 20)
        Me.txtTier.TabIndex = 35
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(114, 433)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(41, 13)
        Me.lblVendor.TabIndex = 93
        Me.lblVendor.Text = "Vendor"
        '
        'lblDesctiption
        '
        Me.lblDesctiption.AutoSize = True
        Me.lblDesctiption.Location = New System.Drawing.Point(98, 406)
        Me.lblDesctiption.Name = "lblDesctiption"
        Me.lblDesctiption.Size = New System.Drawing.Size(60, 13)
        Me.lblDesctiption.TabIndex = 92
        Me.lblDesctiption.Text = "Description"
        '
        'txtvendor
        '
        Me.txtvendor.Location = New System.Drawing.Point(173, 430)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(259, 20)
        Me.txtvendor.TabIndex = 91
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(173, 406)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(259, 20)
        Me.txtDescription.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "MSL"
        '
        'txtMSL
        '
        Me.txtMSL.Location = New System.Drawing.Point(173, 380)
        Me.txtMSL.Name = "txtMSL"
        Me.txtMSL.Size = New System.Drawing.Size(219, 20)
        Me.txtMSL.TabIndex = 88
        '
        'frmComponent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(460, 589)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.lblDesctiption)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMSL)
        Me.Controls.Add(Me.ChkTier)
        Me.Controls.Add(Me.txtTier)
        Me.Controls.Add(Me.ChkCOO)
        Me.Controls.Add(Me.txtCOO)
        Me.Controls.Add(Me.chkLoc)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.ChkCustomer)
        Me.Controls.Add(Me.chkDateCode)
        Me.Controls.Add(Me.chkLotCode)
        Me.Controls.Add(Me.ChkMfger)
        Me.Controls.Add(Me.ChkUnigenPN)
        Me.Controls.Add(Me.ChkMfgPN)
        Me.Controls.Add(Me.txtQtyPackage)
        Me.Controls.Add(Me.ChkQty)
        Me.Controls.Add(Me.chkFirmware)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.NudSerializedLabel)
        Me.Controls.Add(Me.nudCopiesOfLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkpo)
        Me.Controls.Add(Me.txtFirmware)
        Me.Controls.Add(Me.txtDateCode)
        Me.Controls.Add(Me.txtLotCode)
        Me.Controls.Add(Me.txtMfger)
        Me.Controls.Add(Me.txtMfgPN)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComponent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate ComponentID"
        CType(Me.nudCopiesOfLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudSerializedLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim btaPP As New BarTender.ApplicationClass
    Dim BTFormat As BarTender.Format
    Dim MSG As BarTender.Message
    Dim Mydata As New Datalayer

    Private Sub frmComponent_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            btaPP.DBtApplication_Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(btaPP)
            btaPP = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUser.Text = Datalayer.LoginName
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case msg.WParam.ToInt32()
            Case CInt(Keys.F2)
                'Save()

                Return True
            Case CInt(Keys.F4)
                Save()
                Return True

            Case CInt(Keys.F6)

                '  btnNextBoard.Focus()
                ' MessageBox.Show("Pressed " & Keys.F6)
                'SendKeys.Send("{Enter}")

                Return True
            Case CInt(Keys.F8)
                Return True
            Case CInt(Keys.Escape)
                Me.Close()
                Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function 'ProcessCmdKey 



    Private Function Validation() As Boolean

        If txtPO.Text.Trim = "" Then
            MessageBox.Show("Missing PO#!")

            txtPO.Focus()
            Return False
            Exit Function
        End If




        If txtMfgPN.Text.Trim = "" Then
            MessageBox.Show("Missing Manufacturer's Part Number!")

            txtMfgPN.Focus()
            Return False
            Exit Function
        End If
        If txtPN.Text.Trim = "" Then
            MessageBox.Show("Missing Unigen Part Number!")

            txtPN.Focus()
            Return False
            Exit Function
        End If
        If txtMfger.Text.Trim = "" Then
            MessageBox.Show("Missing Manufacturer Name!")

            txtMfger.Focus()
            Return False
            Exit Function
        End If
        If txtLotCode.Text.Trim = "" Then
            MessageBox.Show("Missing Manufacturer Lot Code!")

            txtLotCode.Focus()
            Return False
            Exit Function
        End If
        If txtDateCode.Text.Trim = "" Then
            MessageBox.Show("Missing Manufacturer Date Code!")

            txtDateCode.Focus()
            Return False
            Exit Function
        End If

        If txtFirmware.Text = "" Then

        End If


        '     If ChkQty.Checked = False Then
        If txtQtyPackage.Text = "" Then
            MessageBox.Show("Missing Qty per Package!")
            txtQtyPackage.Focus()
            Return False
            Exit Function
        End If

        If ChkQty.Checked = False Then


            If Not IsNumeric(txtQtyPackage.Text.Trim) Then
                MessageBox.Show("Qty per Package has to be an numeric integer number!")
                txtQtyPackage.Text = ""
                txtQtyPackage.Focus()
                Return False
                Exit Function
            End If

            If (CType(txtQtyPackage.Text.Trim, Single) - CType(txtQtyPackage.Text.Trim, Integer)) <> 0 Then
                MessageBox.Show("Qty per Package has to be an numeric integer number!")

                txtQtyPackage.Focus()
                Return False
                Exit Function
            ElseIf CType(txtQtyPackage.Text.Trim, Single) < 0 Then
                MessageBox.Show("Qty per Package has to be a positive numeric integer!")

                txtQtyPackage.Focus()
                Return False
                Exit Function
            End If
        End If
        Return True
    End Function

    Private Sub Save()
        If Validation() = True Then

            Dim NumBerOfSerlized, NumBerOfLabels As Integer

            NumBerOfLabels = nudCopiesOfLabel.Value
            NumBerOfSerlized = NudSerializedLabel.Value
            Dim dsControlID As DataSet
            Dim MSL As String = ""
            Try



                Dim MYCurrentMSL As String = ""

                Try
                    MYCurrentMSL = Mydata.GetMSLfromCloud(txtPN.Text.Trim)
                Catch ex As Exception

                End Try



                If MYCurrentMSL.Length > 0 Then


                    Select Case MYCurrentMSL.Trim.Substring(0, 2)


                        Case "2A"
                            MSL = "MSL 2a"

                        Case MSL.Trim.Contains("5A")
                            MSL = "MSL 5a"
                        Case Else
                            Select Case MYCurrentMSL.Trim.Substring(0, 1)
                                Case "1"
                                    MSL = "MSL 1"
                                Case "2"
                                    MSL = "MSL 2"

                                Case "3"
                                    MSL = "MSL 3"

                                Case "4"
                                    MSL = "MSL 4"

                                Case "5"
                                    MSL = "MSL 5"

                                Case "6"
                                    MSL = "MSL 6"
                                Case Else


                                    If MYCurrentMSL.Trim.ToUpper.Contains("MANDATORY") Then
                                        MSL = "MSL 6"
                                    Else
                                        MSL = MYCurrentMSL
                                    End If



                            End Select
                    End Select
                End If
            Catch ex As Exception


            End Try

            If MSL = "" Then
                txtMSL.Text = MSL
            End If


            Try
                dsControlID = Mydata.InsertNewComponent(NumBerOfSerlized, txtQtyPackage.Text.Trim, txtPO.Text.Trim.ToUpper, txtPN.Text.Trim, txtMfgPN.Text.Trim, txtMfger.Text.Trim, txtLotCode.Text.Trim, txtDateCode.Text.Trim, txtFirmware.Text.Trim, lblUser.Text.Trim.ToUpper.Trim, txtLoc.Text.Trim.ToUpper, "", txtCOO.Text.Trim, txtMSL.Text, txtDescription.Text, txtvendor.Text)


                Dim ReptCnt As Integer

                Dim Path As String = Application.StartupPath & "\componentID.btw"
                ' BTFormat = btaPP.Formats.Open("C:\Barcode\componentID.btw")
                BTFormat = btaPP.Formats.Open(Path)


                Dim MyRow As DataRow
                For Each MyRow In dsControlID.Tables(0).Rows
                    For ReptCnt = 0 To NumBerOfLabels - 1


                        Dim ComponentID As String
                        Dim QtyPerPack As String
                        Dim LotCode As String
                        Dim Loc As String
                        Dim PN As String
                        Dim MfgPN As String

                        Dim DateCode As String
                        Dim Cust As String
                        Dim SEQ As String
                        Dim MyTier As String = ""

                        Dim MYMSL As String = ""



                        ComponentID = MyRow.Item("ComponentID")

                        QtyPerPack = MyRow.Item("QtyPerPackage")
                        PN = MyRow.Item("UGPN")
                        LotCode = MyRow.Item("LotCode")
                        Loc = MyRow.Item("StorageLoc")
                        MfgPN = MyRow.Item("MfgPN")

                        DateCode = MyRow.Item("DateCode")
                        MyTier = IIf(MyRow.IsNull("TIER"), "", MyRow.Item("TIER"))
                        MYMSL = IIf(MyRow.IsNull("MSL"), "", MyRow.Item("MSL"))




                        If txtCustomer.Text.Trim.ToUpper = "" Then
                            Cust = ""
                        Else
                            Cust = txtCustomer.Text.Trim.ToUpper
                        End If
                        SEQ = (ReptCnt + 1).ToString + "/" + NumBerOfLabels.ToString

                        '' MessageBox.Show(ComponentID)

                        BTFormat.SetNamedSubStringValue("UnigenPN", PN)
                        BTFormat.SetNamedSubStringValue("ComponentID", ComponentID)
                        BTFormat.SetNamedSubStringValue("Description", MfgPN)
                        BTFormat.SetNamedSubStringValue("StorageLoc", Loc)
                        BTFormat.SetNamedSubStringValue("QtyPerPack", QtyPerPack)

                        BTFormat.SetNamedSubStringValue("LotCode", LotCode)
                        BTFormat.SetNamedSubStringValue("DateCode", DateCode)
                        BTFormat.SetNamedSubStringValue("Customer", Cust)
                        BTFormat.SetNamedSubStringValue("SEQ", SEQ)
                        BTFormat.SetNamedSubStringValue("MSL", MYMSL)

                        BTFormat.SetNamedSubStringValue("TIER", MyTier)
                        BTFormat.PrintOut()
                    Next

                Next
                BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(BTFormat)
                BTFormat = Nothing
                CleanUp()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Save()


    End Sub


    Private Sub CleanUp()

        If chkpo.Checked = False Then
            txtPO.Text = ""
        End If

        If ChkMfgPN.Checked = False Then
            txtMfgPN.Text = ""
        End If

        If ChkUnigenPN.Checked = False Then
            txtPN.Text = ""
        End If

        If ChkMfger.Checked = False Then
            txtMfger.Text = ""
        End If
        If chkLotCode.Checked = False Then
            txtLotCode.Text = ""
        End If

        If chkDateCode.Checked = False Then
            txtDateCode.Text = ""
        End If

        If ChkCustomer.Checked = False Then
            txtCustomer.Text = ""
        End If


        If chkLoc.Checked = False Then
            txtLoc.Text = ""
        End If


        If ChkCOO.Checked = False Then
            txtCOO.Text = ""
        End If


        If ChkTier.Checked = False Then
            txtTier.Text = ""
        End If



        txtDescription.Text = ""
        txtvendor.Text = ""
        txtMSL.Text = ""
        txtFirmware.Text = ""
        nudCopiesOfLabel.Value = 1
        NudSerializedLabel.Value = 1

    End Sub



    Private Sub txtPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPO.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtPO.Text.Trim = "" Then


                MessageBox.Show("Missing PO#!")
                txtPO.Focus()
                Exit Sub
            Else
                txtMfgPN.Focus()
            End If
        End If

    End Sub

    Private Sub txtMfgPN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMfgPN.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtMfgPN.Text.Trim = "" Then
                MessageBox.Show("Missing Manufacturer's Part Number!")
                txtMfgPN.Focus()
                Exit Sub
            Else
                txtPN.Focus()
            End If
        End If
    End Sub

    Private Sub txtPN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPN.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtPN.Text.Trim = "" Then
                MessageBox.Show("Missing Unigen Part Number!")
                txtPN.Focus()
                Exit Sub
            Else
                txtMfger.Focus()

            End If
        End If
    End Sub

    Private Sub txtMfger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMfger.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtMfger.Text.Trim = "" Then
                MessageBox.Show("Missing Manufacturer Name!")

                txtMfger.Focus()

                Exit Sub
            Else
                txtLotCode.Focus()

            End If
        End If
    End Sub

    Private Sub txtLotCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotCode.KeyPress

        If (Asc(e.KeyChar)) = Keys.Enter Then


            If txtLotCode.Text.Trim = "" Then


                MessageBox.Show("Missing Manufacturer Lot Code!")

                txtLotCode.Focus()

                Exit Sub
            Else
                txtDateCode.Focus()

            End If
        End If
    End Sub

    Private Sub txtDateCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDateCode.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then


            If txtDateCode.Text.Trim = "" Then
                MessageBox.Show("Missing Manufacturer Date Code!")

                txtDateCode.Focus()

                Exit Sub
            Else


                If chkFirmware.Checked = False Then
                    txtFirmware.Focus()
                Else
                    txtLoc.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub txtFirmware_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirmware.KeyPress

        If (Asc(e.KeyChar)) = Keys.Enter Then



            If txtFirmware.Text.Trim = "" Then
                MessageBox.Show("Missing Fireware info!")

                txtFirmware.Focus()

                Exit Sub
            Else
                txtLoc.Focus()

            End If
        End If
    End Sub

    Private Sub txtQtyPackage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) = Keys.Enter Then


            If txtQtyPackage.Text = "" Then
                MessageBox.Show("Missing Qty per Package!")

                txtQtyPackage.Focus()

                Exit Sub
            Else
                txtLoc.Focus()
            End If
        End If
    End Sub

    Private Sub txtLoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoc.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then


            If txtLoc.Text.Trim = "" Then
                MessageBox.Show("Missing Storage Location!")
                txtLoc.Focus()
                Exit Sub
            End If
        End If
    End Sub


    Private Sub txtDateCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateCode.TextChanged

    End Sub

    Private Sub ChkQty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkQty.CheckedChanged
        If ChkQty.Checked = True Then
            txtQtyPackage.Text = 2000
            txtQtyPackage.Enabled = False
        Else
            txtQtyPackage.Enabled = True
            txtQtyPackage.Text = ""

        End If
    End Sub

    Private Sub chkFirmware_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFirmware.CheckedChanged
        If chkFirmware.Checked = True Then

            txtFirmware.Text = "N/A"
            txtFirmware.Enabled = False
        Else
            txtFirmware.Text = ""
            txtFirmware.Enabled = True
        End If



    End Sub

   

    Private Sub txtTier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTier.KeyPress

        If (Asc(e.KeyChar)) = Keys.Enter Then


            If txtTier.Text.Trim = "" Then
                MessageBox.Show("Missing Tier info!")
                txtTier.Focus()
                Exit Sub
            End If

        End If

    End Sub

End Class
