Imports System.Data.SqlClient
Public Class frmBrokerMaster

    Dim cmd As SqlCommand
    Dim connection As SqlConnection
    Public Sub hienthi()
        Try
            connection = New SqlConnection(ModVar.Strconn_66)
            cmd = New SqlCommand("ShowBrockerName", connection)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            connection.Open()
            Using adap As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                adap.Fill(dt)
                dgv.DataSource = dt
                lblTotal.Text = "Total Record: " & dt.Rows.Count.ToString()
            End Using
            connection.Dispose()
            connection.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmBrokerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hienthi()
        chkStatus.Checked = True
    End Sub
    Dim status As Boolean = False
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtSupplierName.Text = String.Empty Then
            MessageBox.Show("Please input SupplierName!", "Error Msg!")
            txtSupplierName.[Select]()
            Return
        Else

            Try
                connection = New SqlConnection(ModVar.Strconn_66)
                cmd = New SqlCommand("p_insert_broker", connection)
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                connection.Open()
                cmd.Parameters.Add(New SqlParameter("@SupplierName", txtSupplierName.Text.ToString().Trim()))
                cmd.Parameters.Add(New SqlParameter("@Type", cboBroker.Text.ToString().Trim()))

                If chkStatus.Checked = True Then
                    status = True
                    cmd.Parameters.Add(New SqlParameter("@Status", status))
                Else
                    status = False
                    cmd.Parameters.Add(New SqlParameter("@Status", status))
                End If
                cmd.ExecuteNonQuery()
                connection.Dispose()
                connection.Close()
                Me.hienthi()
                Me.clear()
                txtSupplierName.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub clear()
        txtSupplierName.Text = String.Empty
        cboBroker.Text = String.Empty
        chkStatus.Checked = True

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtSupplierName.Text.Trim() = String.Empty Then Throw New NotEnoughInfoException()
            connection = New SqlConnection(ModVar.Strconn_66)
            cmd = New SqlCommand("p_update_broker", connection)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.Add(New SqlParameter("@SupplierName", txtSupplierName.Text.ToString().Trim()))
            cmd.Parameters.Add(New SqlParameter("@Type", cboBroker.Text.ToString().Trim()))
            cmd.Parameters.Add(New SqlParameter("@ID", lblID.Text.ToString()))
            If chkStatus.Checked = True Then
                status = True
                cmd.Parameters.Add(New SqlParameter("@Status", status))
            Else
                status = False
                cmd.Parameters.Add(New SqlParameter("@Status", status))
            End If
            cmd.ExecuteNonQuery()
            connection.Close()
            connection.Dispose()
            Me.hienthi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If txtSupplierName.Text.Trim() = String.Empty Then Throw New NotEnoughInfoException()
            connection = New SqlConnection(ModVar.Strconn_66)
            cmd = New SqlCommand("p_delete_broker", connection)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            connection.Open()
            cmd.Parameters.Add(New SqlParameter("@ID", lblID.Text.ToString().Trim()))
            cmd.ExecuteNonQuery()
            connection.Close()
            connection.Dispose()
            Me.hienthi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.RowCount > 0 Then
            If dgv.CurrentCell Is Nothing Then Return

            If dgv.CurrentCell.RowIndex < dgv.RowCount Then
                Dim hang As Integer = dgv.CurrentCell.RowIndex
                Dim ma As String = dgv.Rows(hang).Cells(0).Value.ToString()
                Dim [select] As String = "select *   FROM tblBroker WHERE ID=N'" & ma & "'"
                Dim ds As DataSet = localdata.getDataset([select])
                txtSupplierName.Text = ds.Tables(0).Rows(0)("SupplierName").ToString()
                cboBroker.Text = ds.Tables(0).Rows(0)("Type").ToString()
                lblID.Text = ds.Tables(0).Rows(0)("ID").ToString()
                If ds.Tables(0).Rows(0)("Status").ToString() = "True" Or ds.Tables(0).Rows(0)("Status").ToString() = "1" Then
                    chkStatus.Checked = True
                Else
                    chkStatus.Checked = False
                End If


            End If
        End If
    End Sub

    Private Sub btnFinding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinding.Click
        Try
            Dim sl As String = "SELECT *  FROM tblBroker  where ID is not null "

            If txtSupplierName.Text.Trim() <> String.Empty Then
                sl += " and SupplierName  ='" & txtSupplierName.Text & "'"
            End If

            If cboBroker.Text.Trim() <> String.Empty Then
                sl += " and Type ='" & cboBroker.Text & "'"
            End If

            If chkStatus.Checked = True Then

                sl += "  and Status = 1 "
            Else

                sl += "  and Status = 0 "
            End If

            Dim ds As DataSet = localdata.getDataset([sl])
            Dim dt As DataTable = localdata.DataTable_Sql([sl])
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            lblTotal.Text = "Total record:  " & dt.Rows.Count.ToString()
        Catch __unusedException1__ As Exception

        End Try
    End Sub
End Class
Public Class NotEnoughInfoException
    Inherits ApplicationException

    Public Sub New()
        MyBase.New()
    End Sub
End Class

Public Class SameKeyException
    Inherits ApplicationException

    Public Sub New()
        MyBase.New()
    End Sub
End Class

Public Class OutOfQuantityException
    Inherits ApplicationException

    Public Sub New()
        MyBase.New()
    End Sub
End Class

Public Class TimeLogicException
    Inherits ApplicationException

    Public Sub New()
        MyBase.New()
    End Sub
End Class

Public Class SameProductKey
    Inherits ApplicationException

    Public Sub New()
        MyBase.New()
    End Sub
End Class