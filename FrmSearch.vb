Public Class FrmSearch
    Dim Mydata As New Datalayer
    Dim dsComponent As DataSet

    Private Sub FrmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnComSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComSearch.Click
        Try

     
            dsComponent = Mydata.GetdsCompontByID(txtComponentID.Text.Trim)
            DataGridView1.DataSource = dsComponent.Tables(0)
            txtComponentID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnPnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPnSearch.Click
        Try


            dsComponent = Mydata.GetdsCompontByPN(txtPN.Text.Trim)
            DataGridView1.DataSource = dsComponent.Tables(0)
            txtPN.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnPOSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOSearch.Click
        Try


            dsComponent = Mydata.GetdsCompontByPO(txtPO.Text.Trim)
            DataGridView1.DataSource = dsComponent.Tables(0)
            txtPO.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class