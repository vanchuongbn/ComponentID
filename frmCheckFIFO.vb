

Imports System.Data.SqlClient
Public Class frmCheckFIFO
    Dim mydaya As New Datalayer
    Dim dsComponent As DataSet

    Private Sub frmCheckFIFO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub searchFIFO(ByVal component As String, ByVal ugpn As String)
        dsComponent = mydaya.GetdsDateCode_FIFO(component, ugpn)
        DGRFIFO.DataSource = dsComponent.Tables(0)
    End Sub

    Private Sub tbnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSearch.Click
        searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
    End Sub

    Private Sub DGRFIFO_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGRFIFO.CellClick
        Try
            Me.txtComponent_ID.Text = Me.DGRFIFO.CurrentRow.Cells(0).Value.ToString.Trim
            Me.txtDateCode.Text = Me.DGRFIFO.CurrentRow.Cells(4).Value.ToString.Trim
            Me.txtLoc.Text = Me.DGRFIFO.CurrentRow.Cells(9).Value.ToString.Trim
            Me.txtUGPN.Text = Me.DGRFIFO.CurrentRow.Cells(1).Value.ToString.Trim
            
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txtUGPN__KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUGPN_.KeyPress
        If (Asc(e.KeyChar)) = Keys.Enter Then  
            searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
        End If
    End Sub

    Private Sub txtUGPN__TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUGPN_.TextChanged
        searchFIFO(txtComponentID.Text.Trim, txtUGPN_.Text.Trim)
    End Sub
End Class