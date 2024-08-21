Imports System
Imports System.Reflection
Public Class frmLogin
    Dim Mydata As New Datalayer
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click


        GetIN()


    End Sub

    Private Sub GetIN()
        Try
            If txtLoginID.Text.Trim = "" Then
                MessageBox.Show("Missing login info!")
                txtLoginID.Focus()
                Exit Sub

            End If

            Dim dsUser As DataSet
            dsUser = Mydata.GetdsUser(txtLoginID.Text.Trim)
            If dsUser.Tables(0).Rows.Count = 0 Then
                lblMessage.Text = "Invalide login!"

            Else
                Dim user As String
                Dim lv As String
                ' user = "philip" ''
                user = dsUser.Tables(0).Rows(0)("UserName")
                lv = dsUser.Tables(0).Rows(0)("Level") 'Jerry add new
                Datalayer.LoginName = user
           
                Datalayer.Level = lv 'Jerry add new
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Try
            Dim asb As System.Reflection.Assembly = Assembly.GetEntryAssembly()
            Dim asbName As AssemblyName = asb.GetName()
            Dim this_ver As Version = asbName.Version
            Dim ui_server As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo("\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe")
            Dim server_ver As Version = New Version(ui_server.FileVersion)

            If server_ver <> this_ver Then
                Dim result As DialogResult = MessageBox.Show("This version: " & this_ver.ToString() & " Please update system now for update some function!", "ComponentID Update", MessageBoxButtons.YesNoCancel)

                If result = DialogResult.Yes Then

                    If server_ver = this_ver Then
                        timer1.Enabled = False
                    Else
                        timer1.Enabled = True
                    End If
                ElseIf result = DialogResult.No Then
                Else
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtLoginID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoginID.KeyPress


        If (Asc(e.KeyChar)) = Keys.Enter Then
            GetIN()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim asb As System.Reflection.Assembly = Assembly.GetEntryAssembly()
        Dim asbName As AssemblyName = asb.GetName()
        Dim this_ver As Version = asbName.Version
        Dim ui_server As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo("\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe")
        Dim server_ver As Version = New Version(ui_server.FileVersion)

        If server_ver <> this_ver Then
            System.Diagnostics.Process.Start("C:\Program Files (x86)\UNIGEN\ComponentLabel\AShengUpdate.exe")
            Timer1.Enabled = False
        End If
    End Sub
End Class