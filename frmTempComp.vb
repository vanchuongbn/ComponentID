Public Class frmTempComp

    Dim mydata As New localdata
    Dim mydataset As DataSet
    Dim btaPP As New BarTender.ApplicationClass
    Dim BTFormat As BarTender.Format
    Dim MSG As BarTender.Message



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Save()
    End Sub

    Private Sub Save()
        If Validation() = True Then

            Try
                Dim TemKey As String = mydata.getMachineName & "." & Date.Now.Ticks.ToString()

                Dim NumBerOfSerlized, NumBerOfLabels As Integer

                NumBerOfLabels = nudCopiesOfLabel.Value
                NumBerOfSerlized = NudSerializedLabel.Value
                Dim YWEEK As String = mydata.getYYYYWW()
                Dim ExistingESN As Integer = mydata.SelectEndSN(YWEEK)
                Dim SSN As Integer = ExistingESN + 1
                Dim ESN As Integer = ExistingESN + NumBerOfSerlized


                Dim MyMaterial As New ComponentGroup(txtPN.Text.Trim, "", CType(txtQtyPackage.Text.Trim, Integer), txtLoc.Text.Trim.ToUpper, txtLotCode.Text.Trim, txtDateCode.Text.Trim, txtMfgPN.Text.Trim, txtCustomer.Text.Trim)
                mydata.InsertNewMaterial(NumBerOfSerlized, SSN, ESN, txtQtyPackage.Text.Trim, txtPO.Text.Trim.ToUpper, txtPN.Text.Trim, txtMfgPN.Text.Trim, txtMfger.Text.Trim, txtLotCode.Text.Trim, txtDateCode.Text.Trim, txtFirmware.Text.Trim, YWEEK, txtUser.Text, txtLoc.Text.Trim.ToUpper, TemKey)


                Dim ControllID As Integer = mydata.GetLastControlID(TemKey)
                Dim CompArray As ArrayList
                CompArray = mydata.GenerateComponentIDs(SSN, ESN, txtQtyPackage.Text.Trim, ControllID)


                Dim ReptCnt As Integer
                Dim Path As String = Application.StartupPath & "\componentID.btw"
                BTFormat = btaPP.Formats.Open(Path)


                For i As Integer = 0 To CompArray.Count - 1
                    For ReptCnt = 0 To NumBerOfLabels - 1
                        Dim ComponentID As String
                        Dim QtyPerPack As String
                        Dim LotCode As String
                        Dim Loc As String
                        Dim PN As String
                        Dim MfgPN As String

                        Dim DateCode As String
                        Dim Cust As String

                        ComponentID = CompArray.Item(i)

                        QtyPerPack = MyMaterial.QtyPerPack
                        PN = MyMaterial.UnigenPN
                        LotCode = MyMaterial.LotCode
                        Loc = MyMaterial.StorageLoc
                        MfgPN = MyMaterial.MfgPN
                        DateCode = MyMaterial.DateCode
                        Cust = MyMaterial.Customer

                        BTFormat.SetNamedSubStringValue("UnigenPN", PN)
                        BTFormat.SetNamedSubStringValue("ComponentID", ComponentID)
                        BTFormat.SetNamedSubStringValue("Description", MfgPN)
                        BTFormat.SetNamedSubStringValue("StorageLoc", Loc)
                        BTFormat.SetNamedSubStringValue("LotCode", LotCode)
                        BTFormat.SetNamedSubStringValue("DateCode", DateCode)
                        BTFormat.SetNamedSubStringValue("Customer", Cust)

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


    Private Sub frmComponent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        btaPP.DBtApplication_Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(btaPP)
        btaPP = Nothing

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
        txtFirmware.Text = ""

        '   txtQtyPackage.Text = ""

        nudCopiesOfLabel.Value = 1
        NudSerializedLabel.Value = 1

    End Sub


    Private Function Validation() As Boolean


        If txtUser.Text = "" Then
            MessageBox.Show("Missing user Name!")

            txtUser.Focus()
            Return False
            Exit Function
        End If


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
                MessageBox.Show("Qty per Package has to be an numeric intrger number!")

                txtQtyPackage.Focus()
                Return False
                Exit Function
            ElseIf CType(txtQtyPackage.Text.Trim, Single) < 0 Then
                MessageBox.Show("Qty per Package has to be a positive numeric intrger!")

                txtQtyPackage.Focus()
                Return False
                Exit Function
            End If
        End If
        Return True
    End Function



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

    Private Sub frmTempComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub
End Class