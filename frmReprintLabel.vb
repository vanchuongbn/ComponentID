Public Class frmReprintLabel
    Dim mydaya As New Datalayer
    Dim dsComponent As DataSet

    Dim btaPP As New BarTender.ApplicationClass
    Dim BTFormat As BarTender.Format
    Dim Mydata As New Datalayer


    Private Sub txtComponentID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComponentID.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtComponentID.Text.Trim = "" Then
                MessageBox.Show("What's ComponentID?", "Missing ComponentID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                txtComponentID.Focus()
                Exit Sub
            End If

            PrintLabel()
           
        End If
    End Sub

  
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintLabel()
        
    End Sub

    Private Sub PrintLabel()


        If txtComponentID.Text.Trim = "" Then
            MessageBox.Show("What's ComponentID?", "Missing ComponentID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            txtComponentID.Focus()
            Exit Sub
        End If
        Try

            Dim NumBerOfLabels As Integer

            NumBerOfLabels = nudCopiesOfLabel.Value
            Dim ReptCnt As Integer

            Dim Path As String = Application.StartupPath & "\componentID.btw"
            ' BTFormat = btaPP.Formats.Open("C:\Barcode\componentID.btw")
            BTFormat = btaPP.Formats.Open(Path)


            For ReptCnt = 0 To NumBerOfLabels - 1



                dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)
                DataGridView1.DataSource = dsComponent.Tables(0)

                'Dim Path As String = Application.StartupPath & "\componentID.btw"
                '' BTFormat = btaPP.Formats.Open("C:\Barcode\componentID.btw")
                'BTFormat = btaPP.Formats.Open(Path)

                Dim MyRow As DataRow
                For Each MyRow In dsComponent.Tables(0).Rows
                    Dim Cust As String
                    Dim ComponentID As String
                    Dim QtyPerPack As String
                    Dim LotCode, DateCode As String
                    Dim Loc As String
                    Dim PN As String
                    Dim MfgPN As String
                    Dim SEQ As String


                    SEQ = "Reprint"

                    If MyRow.IsNull("ComponentID") = True Then
                        ComponentID = ""
                    Else
                        ComponentID = MyRow.Item("ComponentID")
                    End If

                    If MyRow.IsNull("QtyPerPackage") = True Then
                        QtyPerPack = ""
                    Else
                        QtyPerPack = MyRow.Item("QtyPerPackage")
                    End If


                    If MyRow.IsNull("UGPN") = True Then
                        PN = ""
                    Else
                        PN = MyRow.Item("UGPN")
                    End If


                    If MyRow.IsNull("LotCode") = True Then
                        LotCode = ""
                    Else
                        LotCode = MyRow.Item("LotCode")
                    End If


                    If MyRow.IsNull("StorageLoc") = True Then
                        Loc = ""
                    Else
                        Loc = MyRow.Item("StorageLoc")
                    End If


                    If MyRow.IsNull("MfgPN") = True Then
                        MfgPN = ""
                    Else
                        MfgPN = MyRow.Item("MfgPN")
                    End If



                    If MyRow.IsNull("DateCode") = True Then
                        DateCode = ""
                    Else
                        DateCode = MyRow.Item("DateCode")
                    End If


                    If txtCustomer.Text.Trim.ToUpper = "" Then
                        Cust = ""
                    Else
                        Cust = txtCustomer.Text.Trim.ToUpper
                    End If


                    BTFormat.SetNamedSubStringValue("UnigenPN", PN)
                    BTFormat.SetNamedSubStringValue("ComponentID", ComponentID)
                    BTFormat.SetNamedSubStringValue("Description", MfgPN)
                    BTFormat.SetNamedSubStringValue("StorageLoc", Loc)
                    BTFormat.SetNamedSubStringValue("LotCode", LotCode)
                    BTFormat.SetNamedSubStringValue("DateCode", DateCode)
                    BTFormat.SetNamedSubStringValue("Customer", Cust)
                    BTFormat.SetNamedSubStringValue("SEQ", SEQ)
                    BTFormat.PrintOut()
                Next



            Next
            BTFormat.Close(BarTender.BtSaveOptions.btSaveChanges)

            '   BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)

            ' BTFormat.Close()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(BTFormat)
            BTFormat = Nothing


            txtCustomer.Text = ""

            txtComponentID.Text = ""
            txtComponentID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub frmReprintLabel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' btaPP.Quit(BarTender.BtSaveOptions.btSaveChanges)

        btaPP.DBtApplication_Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(btaPP)
        btaPP = Nothing



    End Sub

    
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case msg.WParam.ToInt32()
            Case CInt(Keys.F2)
                'Save()

                Return True
            Case CInt(Keys.F4)
                PrintLabel()
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


End Class