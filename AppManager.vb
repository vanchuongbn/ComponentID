Public Class AppManager
    <STAThread()> _
       Shared Sub Main()
        Dim frmLOGIN1 As System.Windows.Forms.Form
        frmLOGIN1 = New frmLogin
        If frmLOGIN1.ShowDialog = DialogResult.OK Then
            Dim frmmain1 As System.Windows.Forms.Form
            frmmain1 = New frmMain
            Application.Run(frmmain1)
            'ElseIf frmLOGIN1.ShowDialog = DialogResult.Retry Then
            '    Dim Temp As System.Windows.Forms.Form
            '    Temp = New Form2
            '    Temp.Show()
            '    '' Application.Run(Temp)
        End If
    End Sub
End Class




