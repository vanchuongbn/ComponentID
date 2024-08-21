Public Class jerrytest
    Dim colColors As Collection = New Collection
    Private Sub jerrytest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.DrawMode = DrawMode.OwnerDrawFixed
    End Sub
    Private Sub listbox_add_Blue()
        SetColorForNewRow(Brushes.Blue)
        ListBox1.Items.Add("Blue") ' adds the line to the list box
    End Sub

    Private Sub listbox_add_Black()
        SetColorForNewRow(Brushes.Black)
        ListBox1.Items.Add("Black") ' adds the line to the list box
    End Sub

    Sub listbox_remove_0()
        If ListBox1.Items.Count < 1 Then Exit Sub
        ' Must remove brush color from colColors collection first!
        colColors.Remove(1) ' Collection index starts at 1
        ListBox1.Items.RemoveAt(0)
    End Sub
    Sub SetColorForNewRow(ByVal MyBrush As Brush)
        colColors.Add(MyBrush)
    End Sub
    Private Sub ListBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem

        e.DrawBackground()
        If e.Index >= 0 AndAlso e.Index < ListBox1.Items.Count Then
            e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), _
                e.Font, colColors.Item(1 + e.Index), _
                e.Bounds, StringFormat.GenericDefault)
            SetColorForNewRow(Brushes.Blue)
        End If
        e.DrawFocusRectangle()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        listbox_add_Black()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        listbox_add_Blue()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        listbox_remove_0()
    End Sub
End Class