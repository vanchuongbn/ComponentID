Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class frmInputAuthentic
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim obj As ListItem
    Private Sub Load_Brokername()
        Dim Dal As Datalayer = New Datalayer
        dr = Dal.PopulateForm("p_GetBrokerName")
        Me.LstBroker.Items.Clear()
        While dr.Read
            obj = New ListItem(Trim(dr.Item("VENDOR").ToString()), CStr(dr.Item("VENDOR")))
            Me.LstBroker.Items.Add(obj)

        End While
    End Sub
    Private Sub Load_Brokername_Un()
        Dim Dal As Datalayer = New Datalayer
        dr = Dal.PopulateForm("p_GetBrokerName")
        Me.lstBroker1.Items.Clear()
        While dr.Read
            obj = New ListItem(Trim(dr.Item("VENDOR").ToString()), CStr(dr.Item("VENDOR")))
            Me.lstBroker1.Items.Add(obj)

        End While
    End Sub
    Private Sub frmInputAuthentic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Brokername()
        Load_Brokername_Un()
        Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded, "p_GetAuthentic")
        Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded1, "p_GetAuthentic")
        'LstBroker.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Private Sub btnRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshList.Click
        Load_Brokername()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            Me.Add_Role("N")
            obj = CType(Me.LstBroker.SelectedItem, ListItem)
            Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded, "p_GetAuthentic")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            Me.Delete_Role("X")
            obj = CType(Me.LstBrokerAdded.SelectedItem, ListItem)
            Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded, "p_GetAuthentic")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
    Private Sub Load_Role_Added(ByVal Brokername As String, ByVal Lstbox As ListBox, ByVal Sp_name As String)
        Dim Dal As Datalayer = New Datalayer
        dr = Dal.PopulateForm(Sp_name)
        Lstbox.Items.Clear()
        While dr.Read
            obj = New ListItem(Trim(dr.Item("BrokerName").ToString()), CStr(dr.Item("BrokerName")))
            Lstbox.Items.Add(obj)
        End While
    End Sub
    Private Sub Add_Role(ByVal NX As String)
        Dim obj, obj1 As ListItem
        Dim str As String = ""
        If NX = "N" Then
            If Me.LstBroker.SelectedItems.Count = 0 Or Me.LstBroker.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        Else
            If Me.LstBroker.SelectedItems.Count = 0 Or Me.LstBrokerAdded.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        End If

        obj = CType(Me.LstBroker.SelectedItem, ListItem)
        obj1 = CType(Me.LstBroker.SelectedItem, ListItem)
        conn = New SqlConnection(Strconn_66)
        cmd = New SqlCommand("SP_tblAuthentic_Add", conn)
        cmd.CommandType = CommandType.StoredProcedure
        obj = CType(Me.LstBroker.SelectedItem, ListItem)
        cmd.Parameters.Add(New SqlParameter("@BrokerName", obj.ID.Trim()))
        cmd.Parameters.Add(New SqlParameter("@nx", SqlDbType.Char, 2)).Value = NX
        Try
            Me.conn.Open()
            cmd.ExecuteNonQuery()
            'MsgBox(str)
            conn.Close()
        Catch ex As SqlException
            conn.Close()
            MsgBox(ex.Message)
            Exit Sub
        Catch exp As Exception
            conn.Close()
            MsgBox(exp.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Add_Role_Un(ByVal NX As String)
        Dim obj, obj1 As ListItem
        Dim str As String = ""
        If NX = "N" Then
            If Me.lstBroker1.SelectedItems.Count = 0 Or Me.lstBroker1.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        Else
            If Me.lstBroker1.SelectedItems.Count = 0 Or Me.LstBrokerAdded1.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        End If

        obj = CType(Me.lstBroker1.SelectedItem, ListItem)
        obj1 = CType(Me.lstBroker1.SelectedItem, ListItem)
        conn = New SqlConnection(Strconn_66)
        cmd = New SqlCommand("SP_tblAuthentic_Add_Un", conn)
        cmd.CommandType = CommandType.StoredProcedure
        obj = CType(Me.lstBroker1.SelectedItem, ListItem)
        cmd.Parameters.Add(New SqlParameter("@BrokerName", obj.ID.Trim()))
        cmd.Parameters.Add(New SqlParameter("@nx", SqlDbType.Char, 2)).Value = NX
        Try
            Me.conn.Open()
            cmd.ExecuteNonQuery()
            'MsgBox(str)
            conn.Close()
        Catch ex As SqlException
            conn.Close()
            MsgBox(ex.Message)
            Exit Sub
        Catch exp As Exception
            conn.Close()
            MsgBox(exp.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Delete_Role_Un(ByVal NX As String)
        Dim obj, obj1 As ListItem
        Dim str As String = ""
        If NX = "X" Then
            If Me.LstBrokerAdded1.SelectedItems.Count = 0 Or Me.LstBrokerAdded1.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        Else
            If Me.LstBrokerAdded1.SelectedItems.Count = 0 Or Me.LstBrokerAdded1.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        End If

        obj = CType(Me.LstBrokerAdded1.SelectedItem, ListItem)
        obj1 = CType(Me.LstBrokerAdded1.SelectedItem, ListItem)
        conn = New SqlConnection(Strconn_66)
        cmd = New SqlCommand("SP_tblAuthentic_Add_Un", conn)
        cmd.CommandType = CommandType.StoredProcedure
        obj = CType(Me.LstBrokerAdded1.SelectedItem, ListItem)
        cmd.Parameters.Add(New SqlParameter("@BrokerName", obj.ID.Trim()))
        cmd.Parameters.Add(New SqlParameter("@nx", SqlDbType.Char, 2)).Value = NX
        Try
            Me.conn.Open()
            cmd.ExecuteNonQuery()
            'MsgBox(str)
            conn.Close()
        Catch ex As SqlException
            conn.Close()
            MsgBox(ex.Message)
            Exit Sub
        Catch exp As Exception
            conn.Close()
            MsgBox(exp.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Delete_Role(ByVal NX As String)
        Dim obj, obj1 As ListItem
        Dim str As String = ""
        If NX = "X" Then
            If Me.LstBrokerAdded.SelectedItems.Count = 0 Or Me.LstBrokerAdded.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        Else
            If Me.LstBrokerAdded.SelectedItems.Count = 0 Or Me.LstBrokerAdded.SelectedItems.Count = 0 Then
                MsgBox("Please select one Broker Name ")
                Exit Sub
            End If
        End If

        obj = CType(Me.LstBrokerAdded.SelectedItem, ListItem)
        obj1 = CType(Me.LstBrokerAdded.SelectedItem, ListItem)
        conn = New SqlConnection(Strconn_66)
        cmd = New SqlCommand("SP_tblAuthentic_Add", conn)
        cmd.CommandType = CommandType.StoredProcedure
        obj = CType(Me.LstBrokerAdded.SelectedItem, ListItem)
        cmd.Parameters.Add(New SqlParameter("@BrokerName", obj.ID.Trim()))
        cmd.Parameters.Add(New SqlParameter("@nx", SqlDbType.Char, 2)).Value = NX
        Try
            Me.conn.Open()
            cmd.ExecuteNonQuery()
            'MsgBox(str)
            conn.Close()
        Catch ex As SqlException
            conn.Close()
            MsgBox(ex.Message)
            Exit Sub
        Catch exp As Exception
            conn.Close()
            MsgBox(exp.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub LstBroker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBroker.SelectedIndexChanged
        Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded, "p_GetAuthentic")
    End Sub
    Dim colColors As Collection = New Collection
    Sub SetColorForNewRow(ByVal MyBrush As Brush)
        colColors.Add(MyBrush)
    End Sub
    Private Sub LstBroker_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstBroker.DrawItem
        For j As Integer = 0 To LstBroker.Items.Count - 1
            For i As Integer = 0 To LstBrokerAdded.Items.Count - 1
                If LstBroker.Items(j).ToString().Contains(LstBrokerAdded.Items(i).ToString().Trim()) Then
                    e.DrawBackground()
                    If e.Index >= 0 AndAlso e.Index < ListBox1.Items.Count Then
                        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), _
                            e.Font, colColors.Item(1 + e.Index), _
                            e.Bounds, StringFormat.GenericDefault)
                        SetColorForNewRow(Brushes.Blue)
                    End If
                    e.DrawFocusRectangle()


                Else
                    e.DrawBackground()
                    If e.Index >= 0 AndAlso e.Index < ListBox1.Items.Count Then
                        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), _
                            e.Font, colColors.Item(1 + e.Index), _
                            e.Bounds, StringFormat.GenericDefault)
                        SetColorForNewRow(Brushes.Black)
                    End If
                    e.DrawFocusRectangle()
                    ' LstBroker.Items(j).ForeColor = Color.Blue
                End If
            Next


        Next
    End Sub

    Private Sub btnAdded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdded.Click
        Try
            Me.Add_Role_Un("N")
            obj = CType(Me.lstBroker1.SelectedItem, ListItem)
            Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded1, "p_GetAuthentic_un")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDeleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleted.Click
        Try
            Me.Delete_Role_Un("X")
            obj = CType(Me.LstBrokerAdded1.SelectedItem, ListItem)
            Load_Role_Added(obj.ID.Trim, Me.LstBrokerAdded1, "p_GetAuthentic_un")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefreshList1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshList1.Click
        Load_Brokername_Un()
    End Sub
End Class