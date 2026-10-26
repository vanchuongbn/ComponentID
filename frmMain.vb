
Public Class frmMain



    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ComponentID/Current User: " & Datalayer.LoginName.ToUpper & "-" & String.Format("Version {0}", My.Application.Info.Version.ToString)

        If Integer.Parse(Datalayer.Level) > 1 Then
            mnuDeleteComponent.Visible = True
        Else
            mnuDeleteComponent.Visible = False
        End If




    End Sub

    Private Sub ReprintComponentIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintComponentIDToolStripMenuItem.Click

        Dim frm2 As New frmReprintLabel
        With frm2
            .MdiParent = Me
            .Show()
        End With
    End Sub


    Private Sub UpdateComponentInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateComponentInfoToolStripMenuItem.Click


        Dim frm3 As New frmUpdate()


        With frm3
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub EnterComponentInfoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterComponentInfoToolStripMenuItem1.Click


        Dim frm As New frmComponent


        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub SerachToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerachToolStripMenuItem.Click
        Dim frm1 As New FrmSearch
        With frm1
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub PrintFromOracleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintFromOracleToolStripMenuItem.Click

        Dim Pull2Prin As New frmPull2Print()
        With Pull2Prin
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim About As New AboutBox1
        With About
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub RePrintComponentIDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RePrintComponentIDToolStripMenuItem1.Click
        'Dim reprint As New Re_PrintComponentID()
        Dim reprint As New frmRePrintNew()
        With reprint
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub mnuDeleteComponent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteComponent.Click
        Dim delete As New frmDeleteComponetID()
        With delete
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ReturnFromProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnFromProductToolStripMenuItem.Click
        Dim return_from_product As New frmReturnFromProduct()
        With return_from_product
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ConvertMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertMaterialToolStripMenuItem.Click
        Dim Convert_material As New frmConvert_Material()
        With Convert_material
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub PrintOuterPCBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOuterPCBToolStripMenuItem.Click
        Dim PrintPCB As New frmPrintOuter_PCB()
        With PrintPCB
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub UpdateQtyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateQtyToolStripMenuItem.Click
        Dim update_qtywhendelete_wrong As New Re_PrintComponentID()
        With update_qtywhendelete_wrong
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub CheckFIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFIFToolStripMenuItem.Click
        Dim check_fifo As New frmCheckFIFO()
        With check_fifo
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub UpdateFromOracleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFromOracleToolStripMenuItem.Click
        Dim update_oracle As New frmUpdateFromOracle()
        With update_oracle
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ChecKOverDateCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecKOverDateCodeToolStripMenuItem.Click

        Dim overdatecode As New frmCheckOverdateCode()
        With overdatecode
            .MdiParent = Me
            .Show()
        End With
    End Sub
    
    Private Sub XoaComponentTintriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XoaComponentTintriToolStripMenuItem.Click
        Dim xoawocomponent As New frmDeleteWO_ComponentTriniti()
        With xoawocomponent
            .MdiParent = Me
            .Show()
        End With
    End Sub


    Private Sub ExpectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpectToolStripMenuItem.Click
        Dim expectdatecode As New frmExpectDC()
        With expectdatecode
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub InputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputToolStripMenuItem.Click
        Dim broker As New frmInputAuthentic()
        With broker
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ExportByBrockerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportByBrockerToolStripMenuItem.Click
        Dim brokerex As New frmBrokerExport()
        With brokerex
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub InPutBrokerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPutBrokerToolStripMenuItem.Click
        Dim borker As New frmBrokerMaster()
        With borker
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim mrb As New frmUpdateMRB()
        With mrb
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub CheckPrintingTempHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckPrintingTempHistoryToolStripMenuItem.Click
        Dim mrb As New frm_Component_CheckPrinted_History()
        With mrb
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub CheckCurrentMRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckCurrentMRToolStripMenuItem.Click
        Dim mrb_Cur As New frm_CheckCurrent_MRB()
        With mrb_Cur
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub ComponentLocationTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponentLocationTransferToolStripMenuItem.Click
        Dim mrb_Cur As New FrmComponentLocationTransfer()
        With mrb_Cur
            .MdiParent = Me
            .Show()
        End With
    End Sub
End Class