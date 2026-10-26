
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
            If e.RowIndex < 0 Then Exit Sub
            If DGV.CurrentRow Is Nothing Then Exit Sub

            Dim row As DataGridViewRow = DGV.Rows(e.RowIndex)

            lblControlID.Text = GetCellStr(row, "ControlID")
            txtComponentID.Text = GetCellStr(row, "ComponentID")
            txtQty.Text = GetCellStr(row, "QtyPerPackage")
            txtPN.Text = GetCellStr(row, "UGPN")
            txtLotCode.Text = GetCellStr(row, "LotCode")
            txtLoc.Text = GetCellStr(row, "StorageLoc")
            txtMfgPN.Text = GetCellStr(row, "MfgPN")
            txtDateCode.Text = GetCellStr(row, "DateCode")
            txtPO.Text = GetCellStr(row, "PO")
            txtMfger.Text = GetCellStr(row, "Mfger")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetCellStr(r As DataGridViewRow, colName As String) As String
        If r Is Nothing OrElse r.DataGridView Is Nothing Then Return ""

        ' Nếu grid dùng AutoGenerateColumns hoặc đã set DataPropertyName đúng
        Dim cell As DataGridViewCell = Nothing
        If r.DataGridView.Columns.Contains(colName) Then
            cell = r.Cells(colName)
        Else
            ' fallback: tìm theo DataPropertyName
            For Each c As DataGridViewColumn In r.DataGridView.Columns
                If String.Equals(c.DataPropertyName, colName, StringComparison.OrdinalIgnoreCase) Then
                    cell = r.Cells(c.Index)
                    Exit For
                End If
            Next
        End If

        If cell Is Nothing OrElse cell.Value Is Nothing OrElse cell.Value Is DBNull.Value Then Return ""
        Return Convert.ToString(cell.Value).Trim()
    End Function




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
        If Not Validation() Then Exit Sub

        Dim areaValue As String =
        If(radSPL.Checked, "SPL",
           If(radRTN.Checked, "RTN",
              If(radRCV.Checked, "RCV", "")))

        Dim numberOfLabels As Integer = CInt(nudCopiesOfLabel.Value)
        If numberOfLabels <= 0 Then Exit Sub

        Dim templateFile As String = System.IO.Path.Combine(Application.StartupPath, "componentID.btw")
        Dim seqPattern As String = "1/" & numberOfLabels.ToString()
        Dim TwoD As String = ""
        Try
            ' 1) Get data once
            dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)

            If dsComponent Is Nothing OrElse dsComponent.Tables.Count = 0 OrElse dsComponent.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu để in (GetdsReprintLabel trả về rỗng).")
                Exit Sub
            End If

            DGV.DataSource = dsComponent.Tables(0)

            ' 2) Open template once
            BTFormat = btaPP.Formats.Open(templateFile)

            ' Qty per pack dùng từ textbox như logic anh đang làm
            Dim qtyPerPackText As String = SafeTrim(txtQty.Text)
            Dim qtyPerPackInt As Integer? = Nothing
            Dim tmp As Integer
            If Integer.TryParse(qtyPerPackText, tmp) Then qtyPerPackInt = tmp

            ' 3) Print
            For Each myRow As DataRow In dsComponent.Tables(0).Rows

                Dim controlIdStr As String = GetRowStr(myRow, "ControlID")
                Dim controlIdVal As Integer? = Nothing
                Dim cid As Integer
                If Integer.TryParse(controlIdStr, cid) Then controlIdVal = cid

                Dim pn As String = GetRowStr(myRow, "UGPN")
                Dim lotCode As String = GetRowStr(myRow, "LotCode")
                Dim loc As String = GetRowStr(myRow, "StorageLoc")
                Dim mfgpn As String = GetRowStr(myRow, "MfgPN")
                Dim dateCode As String = GetRowStr(myRow, "DateCode")

                ' tem outer theo yêu cầu hiện tại của anh
                Dim componentIDPrint As String = "OuterBOX-PCB"
                Dim cust As String = ""
                TwoD = componentIDPrint & "P" & pn & "Q" & qtyPerPackText.ToString()
                If String.IsNullOrWhiteSpace(pn) OrElse String.IsNullOrWhiteSpace(mfgpn) Then
                    MessageBox.Show("Dữ liệu thiếu UGPN/MfgPN nên không thể in tem. Vui lòng kiểm tra lại dữ liệu.")
                    Exit Sub
                End If

                ' HF
                getInforHF_FromWI(pn.Trim(), mfgpn.Trim())
                Dim hfVal As String = SafeTrim(HF)

                For reptCnt As Integer = 0 To numberOfLabels - 1
                    Dim seq As String = (reptCnt + 1).ToString() & "/" & numberOfLabels.ToString()

                    BTFormat.SetNamedSubStringValue("UnigenPN", pn)
                    BTFormat.SetNamedSubStringValue("ComponentID", componentIDPrint)
                    BTFormat.SetNamedSubStringValue("Description", mfgpn)
                    BTFormat.SetNamedSubStringValue("StorageLoc", loc)
                    BTFormat.SetNamedSubStringValue("QtyPerPack", qtyPerPackText)

                    BTFormat.SetNamedSubStringValue("LotCode", lotCode)
                    BTFormat.SetNamedSubStringValue("DateCode", dateCode)
                    BTFormat.SetNamedSubStringValue("Customer", cust)
                    BTFormat.SetNamedSubStringValue("SEQ", seq)
                    BTFormat.SetNamedSubStringValue("HF", hfVal)

                    ' AREA: dùng chung biến (đã có RCV)
                    BTFormat.SetNamedSubStringValue("AREA", areaValue)
                    BTFormat.SetNamedSubStringValue("2D", TwoD)
                    BTFormat.PrintOut()
                Next

                ' 4) Log history (SUCCESS) - ghi 1 dòng cho 1 lần bấm in / 1 record dữ liệu
                Mydata.InsertPrintHistory_OuterPCB(
                PrintedBy:=SafeTrim(lblUser.Text).ToUpperInvariant(),
                ControlID:=controlIdVal,
                ComponentID:=SafeTrim(txtComponentID.Text),
                UGPN:=pn,
                MfgPN:=mfgpn,
                LotCode:=lotCode,
                DateCode:=dateCode,
                StorageLoc:=loc,
                QtyPerPackage:=qtyPerPackInt,
                Copies:=numberOfLabels,
                Area:=areaValue,
                HF:=hfVal,
                TemplateFile:=templateFile,
                SeqPattern:=seqPattern,
                Status:="SUCCESS"
            )
            Next

        Catch ex As Exception
            ' Log history FAILED (cố gắng ghi)
            Try
                Mydata.InsertPrintHistory_OuterPCB(
                PrintedBy:=SafeTrim(lblUser.Text).ToUpperInvariant(),
                ControlID:=Nothing,
                ComponentID:=SafeTrim(txtComponentID.Text),
                UGPN:=SafeTrim(txtPN.Text),
                MfgPN:=SafeTrim(txtMfgPN.Text),
                LotCode:=SafeTrim(txtLotCode.Text),
                DateCode:=SafeTrim(txtDateCode.Text),
                StorageLoc:=SafeTrim(txtLoc.Text),
                QtyPerPackage:=Nothing,
                Copies:=numberOfLabels,
                Area:=areaValue,
                HF:=SafeTrim(HF),
                TemplateFile:=templateFile,
                SeqPattern:=seqPattern,
                Status:="FAILED",
                ErrorMessage:=ex.Message
            )
            Catch
            End Try

            MessageBox.Show(ex.Message)

        Finally
            ' Close & release COM chắc chắn
            Try
                If BTFormat IsNot Nothing Then
                    BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(BTFormat)
                    BTFormat = Nothing
                End If
            Catch
            End Try

            CleanUp()
        End Try
    End Sub

    'Private Sub Save()
    '    If Validation() <> True Then Exit Sub
    '    Dim areaValue As String =
    '    If(radSPL.Checked, "SPL",
    '       If(radRTN.Checked, "RTN",
    '          If(radRCV.Checked, "RCV", "")))
    '    Dim numberOfLabels As Integer = CInt(nudCopiesOfLabel.Value)
    '    If numberOfLabels <= 0 Then Exit Sub

    '    Try
    '        '========================
    '        ' 1) Lấy dữ liệu reprint & bind grid
    '        '========================
    '        dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)

    '        If dsComponent Is Nothing OrElse dsComponent.Tables.Count = 0 OrElse dsComponent.Tables(0).Rows.Count = 0 Then
    '            MessageBox.Show("Không có dữ liệu để in (GetdsReprintLabel trả về rỗng).")
    '            Exit Sub
    '        End If

    '        DGV.DataSource = dsComponent.Tables(0)

    '        '========================
    '        ' 2) Mở template BarTender
    '        '========================
    '        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "componentID.btw")
    '        BTFormat = btaPP.Formats.Open(path)

    '        ' QtyPerPack: anh đang lấy từ txtQty.Text (không lấy từ MyRow)
    '        Dim qtyPerPack As String = SafeTrim(txtQty.Text)

    '        '========================
    '        ' 3) In tem
    '        '========================
    '        For Each myRow As DataRow In dsComponent.Tables(0).Rows


    '            Dim pn As String = GetRowStr(myRow, "UGPN")
    '            Dim lotCode As String = GetRowStr(myRow, "LotCode")
    '            Dim loc As String = GetRowStr(myRow, "StorageLoc")
    '            Dim mfgpn As String = GetRowStr(myRow, "MfgPN")
    '            Dim dateCode As String = GetRowStr(myRow, "DateCode")
    '            Dim componentID As String = "OuterBOX-PCB"
    '            Dim cust As String = ""
    '            If String.IsNullOrWhiteSpace(pn) OrElse String.IsNullOrWhiteSpace(mfgpn) Then
    '                MessageBox.Show("Dữ liệu thiếu UGPN/MfgPN nên không thể in tem. Vui lòng kiểm tra lại dữ liệu.")
    '                Exit Sub
    '            End If

    '            ' HF: giữ đúng flow cũ
    '            getInforHF_FromWI(pn.Trim(), mfgpn.Trim())

    '            For reptCnt As Integer = 0 To numberOfLabels - 1

    '                Dim seq As String = (reptCnt + 1).ToString() & "/" & numberOfLabels.ToString()

    '                BTFormat.SetNamedSubStringValue("UnigenPN", pn)
    '                BTFormat.SetNamedSubStringValue("ComponentID", componentID)
    '                BTFormat.SetNamedSubStringValue("Description", mfgpn)
    '                BTFormat.SetNamedSubStringValue("StorageLoc", loc)
    '                BTFormat.SetNamedSubStringValue("QtyPerPack", qtyPerPack)

    '                BTFormat.SetNamedSubStringValue("LotCode", lotCode)
    '                BTFormat.SetNamedSubStringValue("DateCode", dateCode)
    '                BTFormat.SetNamedSubStringValue("Customer", cust)
    '                BTFormat.SetNamedSubStringValue("SEQ", seq)

    '                BTFormat.SetNamedSubStringValue("HF", SafeTrim(HF))

    '                ' AREA
    '                If radSPL.Checked Then
    '                    BTFormat.SetNamedSubStringValue("AREA", "SPL")
    '                ElseIf radRTN.Checked Then
    '                    BTFormat.SetNamedSubStringValue("AREA", "RTN")
    '                Else
    '                    BTFormat.SetNamedSubStringValue("AREA", "")
    '                End If

    '                BTFormat.PrintOut()
    '            Next
    '        Next

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)

    '    Finally
    '        '========================
    '        ' 4) Đóng & giải phóng COM chắc chắn
    '        '========================
    '        Try
    '            If BTFormat IsNot Nothing Then
    '                BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)
    '                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(BTFormat)
    '                BTFormat = Nothing
    '            End If
    '        Catch
    '            ' tránh treo UI nếu COM lỗi
    '        End Try

    '        CleanUp()
    '    End Try
    'End Sub

    '========================
    ' Helpers an toàn DBNull/empty
    '========================
    Private Function GetRowStr(r As DataRow, col As String) As String
        If r Is Nothing OrElse r.Table Is Nothing Then Return ""
        If Not r.Table.Columns.Contains(col) Then Return ""
        If r.IsNull(col) Then Return ""
        Return Convert.ToString(r(col)).Trim()
    End Function

    Private Function SafeTrim(s As String) As String
        Return If(s, "").Trim()
    End Function


    'Private Sub Save()
    '    If Validation() = True Then

    '        Dim NumBerOfSerlized, NumBerOfLabels As Integer

    '        NumBerOfLabels = nudCopiesOfLabel.Value
    '        ' Dim dsControlID As DataSet

    '        Try
    '            'dsControlID = Mydata.updateComponent_j(NumBerOfSerlized, txtPO.Text.Trim, txtMfgPN.Text.Trim, txtPN.Text.Trim, txtMfger.Text.Trim, txtLotCode.Text.Trim, txtDateCode.Text.Trim, txtQty.Text.Trim, txtLoc.Text.Trim, lblUser.Text.Trim.ToUpper.Trim, lblControlID.Text.Trim)


    '            dsComponent = mydaya.GetdsReprintLabel(txtComponentID.Text.Trim)
    '            DGV.DataSource = dsComponent.Tables(0)

    '            Dim ReptCnt As Integer

    '            Dim Path As String = Application.StartupPath & "\componentID.btw"
    '            ' BTFormat = btaPP.Formats.Open("C:\Barcode\componentID.btw")
    '            BTFormat = btaPP.Formats.Open(Path)
    '            Dim MyRow As DataRow
    '            For Each MyRow In dsComponent.Tables(0).Rows
    '                For ReptCnt = 0 To NumBerOfLabels - 1


    '                    Dim ComponentID As String
    '                    Dim QtyPerPack As String
    '                    Dim LotCode As String
    '                    Dim Loc As String
    '                    Dim PN As String
    '                    Dim MfgPN As String

    '                    Dim DateCode As String
    '                    Dim Cust As String
    '                    Dim SEQ As String
    '                    Dim MyTier As String = ""


    '                    'ComponentID = MyRow.Item("ComponentID")
    '                    ComponentID = "OuterBOX-PCB"
    '                    'QtyPerPack = MyRow.Item("QtyPerPackage")
    '                    QtyPerPack = txtQty.Text
    '                    PN = MyRow.Item("UGPN")
    '                    LotCode = MyRow.Item("LotCode")
    '                    Loc = MyRow.Item("StorageLoc")
    '                    MfgPN = MyRow.Item("MfgPN")
    '                    ' MyTier = IIf(MyRow.IsNull("TIER"), "", MyRow.Item("TIER"))

    '                    DateCode = MyRow.Item("DateCode")

    '                    'If txtCustomer.Text.Trim.ToUpper = "" Then
    '                    Cust = ""
    '                    'Else
    '                    '    Cust = txtCustomer.Text.Trim.ToUpper
    '                    'End If

    '                    SEQ = (ReptCnt + 1).ToString / NumBerOfLabels
    '                    '' MessageBox.Show(ComponentID)

    '                    BTFormat.SetNamedSubStringValue("UnigenPN", PN)
    '                    BTFormat.SetNamedSubStringValue("ComponentID", ComponentID)
    '                    BTFormat.SetNamedSubStringValue("Description", MfgPN)
    '                    BTFormat.SetNamedSubStringValue("StorageLoc", Loc)
    '                    BTFormat.SetNamedSubStringValue("QtyPerPack", QtyPerPack)

    '                    BTFormat.SetNamedSubStringValue("LotCode", LotCode)
    '                    BTFormat.SetNamedSubStringValue("DateCode", DateCode)
    '                    BTFormat.SetNamedSubStringValue("Customer", Cust)
    '                    BTFormat.SetNamedSubStringValue("SEQ", SEQ)

    '                    getInforHF_FromWI(PN.Trim(), MfgPN.Trim())
    '                    BTFormat.SetNamedSubStringValue("HF", HF)

    '                    'Get the seal for area 
    '                    If radSPL.Checked = True Then
    '                        BTFormat.SetNamedSubStringValue("AREA", "SPL")
    '                    ElseIf radRTN.Checked = True Then
    '                        BTFormat.SetNamedSubStringValue("AREA", "RTN")
    '                    ElseIf radRCV.Checked = True Then
    '                        BTFormat.SetNamedSubStringValue("AREA", "")
    '                    Else
    '                        BTFormat.SetNamedSubStringValue("AREA", "")
    '                    End If
    '                    BTFormat.PrintOut()
    '                Next

    '            Next
    '            '   BTFormat.Close(BarTender.BtSaveOptions.btSaveChanges)
    '            '   BTFormat.PrintOut()
    '            BTFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges)

    '            ' BTFormat.Close()
    '            System.Runtime.InteropServices.Marshal.ReleaseComObject(BTFormat)
    '            BTFormat = Nothing
    '            CleanUp()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End If
    'End Sub

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