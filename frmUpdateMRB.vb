Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports ClosedXML.Excel
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmUpdateMRB
    Dim user As String
    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excel Files (*.xlsx)|*.xlsx"
            ofd.Multiselect = False
            ofd.Title = "Chọn file Excel danh sách ComponentID"

            If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Try
                Dim ids As List(Of String) = ReadComponentIdsFromExcel_ClosedXml(ofd.FileName)

                ' Đổ vào textbox dạng list (mỗi ID 1 dòng)
                txtComponentID.Text = String.Join(vbCrLf, ids)
                lbltotal.Text = "Total ComponentID: " & ids.Count.ToString()
                MessageBox.Show($"Import thành công: {ids.Count} ComponentID",
                            "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Lỗi import Excel: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Function ReadComponentIdsFromExcel_ClosedXml(filePath As String) As List(Of String)
        ' TUYỆT ĐỐI không dùng "Return" trống trong Function
        If String.IsNullOrWhiteSpace(filePath) OrElse Not File.Exists(filePath) Then
            Return New List(Of String)()
        End If

        Using wb As New XLWorkbook(filePath)
            Dim ws = wb.Worksheets.FirstOrDefault()
            If ws Is Nothing Then
                Return New List(Of String)()
            End If

            Dim startRow As Integer = 2 ' dòng 1 là header

            Dim lastRowUsed = ws.LastRowUsed()
            If lastRowUsed Is Nothing Then
                Return New List(Of String)()
            End If

            Dim lastRow As Integer = lastRowUsed.RowNumber()
            If lastRow < startRow Then
                Return New List(Of String)()
            End If

            Dim setIds As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            For r As Integer = startRow To lastRow
                Dim id As String = (ws.Cell(r, 1).GetValue(Of String)() & "").Trim() ' cột A
                If id <> "" Then setIds.Add(id)
            Next

            Return setIds.ToList()
        End Using
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtComponentID.Clear()
        DataGridView2.DataSource = Nothing

        controlID.Text = ""
        controlID_WH.Text = ""

        lbltotal.Text = "Total ComponentID: 0"
        txtComponentID.Focus()
    End Sub

    Private Function BuildCompIdTvp(compIds As List(Of String)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("CompID", GetType(String))

        For Each compId As String In compIds
            dt.Rows.Add(compId)
        Next

        Return dt
    End Function
    Private Sub tbnSearch_Click(sender As Object, e As EventArgs) Handles tbnSearch.Click

        Dim ids = GetCompIdList()
        If ids.Count = 0 Then
            MessageBox.Show("Hãy nhập danh sách ComponentID (mỗi dòng 1 mã)!", "Error Msg!")
            txtComponentID.Select()
            Exit Sub
        End If

        Try
            Using cn As New SqlConnection(Datalayer.GetConnection.ConnectionString)
                Using cmd As New SqlCommand("dbo.p_GetInforComponetID_ByList", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    Dim tvp = BuildCompIdTvp(ids)
                    Dim p = cmd.Parameters.AddWithValue("@CompIDs", tvp)
                    p.SqlDbType = SqlDbType.Structured
                    p.TypeName = "dbo.CompIDList"

                    Using adap As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adap.Fill(dt)
                        DataGridView2.DataSource = dt

                        ' nếu anh có label tổng số
                        lbltotal.Text = "Total ComponentID: " & dt.Rows.Count.ToString()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetCompIdList() As List(Of String)
        Return txtComponentID.Text _
        .Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries) _
        .Select(Function(s) s.Trim()) _
        .Where(Function(s) s <> "") _
        .Distinct(StringComparer.OrdinalIgnoreCase) _
        .ToList()
    End Function


    Private Function BuildCompIdTvp_MRB(compIds As List(Of String)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("CompID", GetType(String))

        For Each compId As String In compIds
            dt.Rows.Add(compId)
        Next

        Return dt
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim compIds As List(Of String) = GetCompIdList()
        If compIds.Count = 0 Then
            MessageBox.Show("Hãy nhập danh sách ComponentID (mỗi dòng 1 mã)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtComponentID.Focus()
            Exit Sub
        End If

        If Not rdInMRB.Checked AndAlso Not rdOutMRB.Checked Then
            MessageBox.Show("Hãy chọn MRB Type: IN MRB hoặc OUT MRB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim mrbValue As Boolean = rdInMRB.Checked ' IN=True, OUT=False

        Dim result As DialogResult =
            MessageBox.Show($"Confirm Update MRB = {mrbValue} cho {compIds.Count} ComponentID?",
                            "Update ComponentID MRB",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then Exit Sub

        Try
            Using cn As New SqlConnection(Datalayer.GetConnection.ConnectionString)
                Using cmd As New SqlCommand("dbo.p_UpdateComponentID_MRB_ByList", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    Dim tvp As DataTable = BuildCompIdTvp_MRB(compIds)
                    Dim p = cmd.Parameters.AddWithValue("@CompIDs", tvp)
                    p.SqlDbType = SqlDbType.Structured
                    p.TypeName = "dbo.CompIDList_MRB"

                    cmd.Parameters.Add("@MRB", SqlDbType.Bit).Value = mrbValue
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = user.Trim()

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Update MRB thành công và đã lưu lịch sử!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUpdateMRB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User = Datalayer.LoginName
    End Sub
End Class