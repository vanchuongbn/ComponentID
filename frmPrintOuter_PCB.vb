
Imports System.Data.SqlClient
Public Class frmPrintOuter_PCB
    Dim mydaya As New Datalayer
    Dim dsComponent As DataSet

    Dim btaPP As New BarTender.ApplicationClass
    Dim BTFormat As BarTender.Format
    Dim Mydata As New Datalayer
    Private Sub txtComponentID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComponentID.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then
            If txtComponentID.Text.Trim = "" Then
                MessageBox.Show("What's ComponentID?", "Missing ComponentID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                txtComponentID.Focus()
                Exit Sub
            Else
                dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)
                DGV.DataSource = dsComponent.Tables(0)
            End If
            '  PrintLabel()
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Me.lblControlID.Text = Me.DGV.CurrentRow.Cells(0).Value.ToString.Trim
            Me.txtComponentID.Text = Me.DGV.CurrentRow.Cells(1).Value.ToString.Trim
            Me.txtDateCode.Text = Me.DGV.CurrentRow.Cells(7).Value.ToString.Trim
            Me.txtLotCode.Text = Me.DGV.CurrentRow.Cells(4).Value.ToString.Trim
            Me.txtQty.Text = Me.DGV.CurrentRow.Cells(2).Value.ToString.Trim
            Me.txtMfgPN.Text = Me.DGV.CurrentRow.Cells(6).Value.ToString.Trim
            Me.txtPO.Text = Me.DGV.CurrentRow.Cells(8).Value.ToString.Trim
            Me.txtPN.Text = Me.DGV.CurrentRow.Cells(3).Value.ToString.Trim
            Me.txtMfger.Text = Me.DGV.CurrentRow.Cells(9).Value.ToString.Trim
            Me.txtLoc.Text = Me.DGV.CurrentRow.Cells(5).Value.ToString.Trim
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPrintOuter_PCB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUser.Text = Datalayer.LoginName
        ChkUnigenPN.Checked = True
        radRCV.Checked = True
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
                DGV.DataSource = dsComponent.Tables(0)

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


                    'If txtCustomer.Text.Trim.ToUpper = "" Then
                    '    Cust = ""
                    'Else
                    '    Cust = txtCustomer.Text.Trim.ToUpper
                    'End If


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


            ' txtCustomer.Text = ""

            txtComponentID.Text = ""
            txtComponentID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Function Validation() As Boolean

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

        If txtQty.Text = "" Then
            MessageBox.Show("Missing Qty per Package!")
            txtQty.Focus()
            Return False
            Exit Function
        End If


        If Not IsNumeric(txtQty.Text.Trim) Then
            MessageBox.Show("Qty per Package has to be an numeric integer number!")
            txtQty.Text = ""
            txtQty.Focus()
            Return False
            Exit Function
        End If

        If (CType(txtQty.Text.Trim, Single) - CType(txtQty.Text.Trim, Integer)) <> 0 Then
            MessageBox.Show("Qty per Package has to be an numeric intrger number!")

            txtQty.Focus()
            Return False
            Exit Function
        ElseIf CType(txtQty.Text.Trim, Single) < 0 Then
            MessageBox.Show("Qty per Package has to be a positive numeric integer!")

            txtQty.Focus()
            Return False
            Exit Function
        End If

        Return True

    End Function
    Private Sub CleanUp()
        If chkLotCode.Checked = False Then
            txtLotCode.Text = ""
        End If

        If chkDateCode.Checked = False Then
            txtDateCode.Text = ""
        End If
        If ChkMfgPN.Checked = False Then
            txtMfgPN.Text = ""
        End If
        If chkpo.Checked = False Then
            txtPO.Text = ""
        End If
        If ChkMfger.Checked = False Then
            txtMfger.Text = ""
        End If
        If chkLoc.Checked = False Then
            txtLoc.Text = ""
        End If
        If ChkUnigenPN.Checked = False Then
            txtPN.Text = ""
        End If
        txtComponentID.Text = ""

        txtQty.Text = ""
        lblControlID.Text = ""

    End Sub


    Private Sub Save()
        If Validation() = True Then

            Dim NumBerOfSerlized, NumBerOfLabels As Integer

            NumBerOfLabels = nudCopiesOfLabel.Value
            ' Dim dsControlID As DataSet

            Try
                'dsControlID = Mydata.updateComponent_j(NumBerOfSerlized, txtPO.Text.Trim, txtMfgPN.Text.Trim, txtPN.Text.Trim, txtMfger.Text.Trim, txtLotCode.Text.Trim, txtDateCode.Text.Trim, txtQty.Text.Trim, txtLoc.Text.Trim, lblUser.Text.Trim.ToUpper.Trim, lblControlID.Text.Trim)


                dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)
                DGV.DataSource = dsComponent.Tables(0)

                Dim ReptCnt As Integer

                Dim Path As String = Application.StartupPath & "\componentID.btw"
                ' BTFormat = btaPP.Formats.Open("C:\Barcode\componentID.btw")
                BTFormat = btaPP.Formats.Open(Path)
                Dim MyRow As DataRow
                For Each MyRow In dsComponent.Tables(0).Rows
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


                        'ComponentID = MyRow.Item("ComponentID")
                        ComponentID = "OuterBOX-PCB"
                        'QtyPerPack = MyRow.Item("QtyPerPackage")
                        QtyPerPack = txtQty.Text
                        PN = MyRow.Item("UGPN")
                        LotCode = MyRow.Item("LotCode")
                        Loc = MyRow.Item("StorageLoc")
                        MfgPN = MyRow.Item("MfgPN")
                        ' MyTier = IIf(MyRow.IsNull("TIER"), "", MyRow.Item("TIER"))

                        DateCode = MyRow.Item("DateCode")

                        'If txtCustomer.Text.Trim.ToUpper = "" Then
                        Cust = ""
                        'Else
                        '    Cust = txtCustomer.Text.Trim.ToUpper
                        'End If

                        SEQ = (ReptCnt + 1).ToString / NumBerOfLabels
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

                        getInforHF_FromWI(PN.Trim(), MfgPN.Trim())
                        BTFormat.SetNamedSubStringValue("HF", HF)

                        'Get the seal for area 
                        If radSPL.Checked = True Then
                            BTFormat.SetNamedSubStringValue("AREA", "SPL")
                        ElseIf radRTN.Checked = True Then
                            BTFormat.SetNamedSubStringValue("AREA", "RTN")
                        ElseIf radRCV.Checked = True Then
                            BTFormat.SetNamedSubStringValue("AREA", "")
                        Else
                            BTFormat.SetNamedSubStringValue("AREA", "")
                        End If
                        BTFormat.PrintOut()
                    Next

                Next
                '   BTFormat.Close(BarTender.BtSaveOptions.btSaveChanges)
                '   BTFormat.PrintOut()
                BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)

                ' BTFormat.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(BTFormat)
                BTFormat = Nothing
                CleanUp()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Dim HF As String = ""
    Dim connection As SqlConnection
    Dim cmd As SqlCommand
    Private Sub getInforHF_FromWI(ByVal PN As String, ByVal MfgPN As String)
        'Jerry add check HF
        Try
            Dim status As String = ""
            connection = New SqlConnection(Datalayer.GetConnection1().ConnectionString)
            cmd = New SqlCommand("spGetMSL_ComponentID", connection)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.Add(New SqlParameter("@UnigenPN", PN.Trim()))
            cmd.Parameters.Add(New SqlParameter("@MfgPN", MfgPN.Trim()))
            Dim dt_ As DataTable = New DataTable()
            dt_.Load(cmd.ExecuteReader())
            connection.Dispose()
            connection.Close()

            If dt_.Rows.Count > 0 Then
                If dt_.Rows(0)("hf").ToString().Trim() = "1" Then
                    HF = "HF"
                Else
                    HF = ""
                End If
            Else
                HF = ""
            End If

        Catch ex As Exception

        End Try
        'end check HF
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Save()
    End Sub

    Private Sub ChkUnigenPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkUnigenPN.CheckedChanged

        If ChkUnigenPN.Checked = True Then
            txtPN.ReadOnly = True
        Else
            txtPN.ReadOnly = False
        End If

    End Sub
End Class