Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
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



    Public Sub check_openserver()
        Dim parth_split As String()
        Dim path As String = Application.ExecutablePath.ToString().ToUpper()

        If path.ToString() <> "" AndAlso Not path.Contains("172.16.1.24") AndAlso Not path.Contains("FILES") Then
            parth_split = path.Split(":"c)

            If parth_split(0).Trim() <> "D" AndAlso parth_split(0).Trim() <> "C" Then
                Me.Close()
                Application.[Exit]()
            End If
        End If

        If path.Contains("172.16.1.24") Then
            Me.Close()
            Application.[Exit]()
        End If

        If path.Contains("FILES") Then
            Me.Close()
            Application.[Exit]()
        End If
    End Sub
    Private Sub ShellExecute(ByVal Command As String)
        Dim p As Process = New Process()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo("cmd.exe")
        startInfo.Arguments = "/C " & Command
        startInfo.RedirectStandardError = True
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = True
        p.StartInfo = startInfo
        p.Start()
        p.WaitForExit()
    End Sub
    Function CheckCurrent_Version() As Boolean
        Dim retval As Boolean = False
        Try

            'connection string : Strconn_ITDB_70 As String = "Server=172.16.1.70;Database=UHAN_Web_ITDB;User ID=sa;Password=p@ssw0rd;Trusted_Connection=False;"
            Dim conn1 As SqlConnection = New SqlConnection(ModVar.Strconn_ITDB_70)
            Dim da As New SqlDataAdapter("UHAN_Application_Get_Current_InforByApplication_Name'" + Application.ProductName.ToString + "'", conn1)
            conn1.Open()
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            conn1.Close()
            Dim a As String = ""
            If dt.Rows.Count > 0 Then
                If Application.ProductVersion.ToString <> dt.Rows(0).Item("Current_AssemblyVersion").ToString() Then
                    For Each process As Process In Process.GetProcessesByName("Uhan_Update")
                        process.Kill()
                    Next

                    If (Not System.IO.Directory.Exists("C:\UHAN_Applications")) Then
                        Directory.CreateDirectory("C:\UHAN_Applications")
                    End If
                    Try

                        ShellExecute("taskkill /F /IM Uhan_Update.exe")
                        System.Threading.Thread.Sleep(2000)
                        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create("ftp://172.16.1.24/UHAN_Applications/"), FtpWebRequest)
                        ftpRequest.Credentials = New NetworkCredential("ughn\Administrator", "Ughn2023$!1")
                        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
                        Dim response As FtpWebResponse = CType(ftpRequest.GetResponse(), FtpWebResponse)
                        Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                        Dim directories As List(Of String) = New List(Of String)()
                        Dim line As String = streamReader.ReadLine()

                        While Not String.IsNullOrEmpty(line)
                            directories.Add(line)
                            line = streamReader.ReadLine()
                        End While

                        streamReader.Close()

                        Using ftpClient As WebClient = New WebClient()
                            ftpClient.Credentials = New System.Net.NetworkCredential("ughn\Administrator", "Ughn2023$!1")
                            '' If directories(0).Contains(".") Then

                            Dim path As String = "ftp://172.16.1.24/UHAN_Applications/Uhan_Update.exe"
                            Dim trnsfrpth As String = "C:\UHAN_Applications\Uhan_Update.exe"
                            ftpClient.DownloadFile(path, trnsfrpth)
                            Me.Close()
                        End Using

                        'File.Copy("\\172.16.1.24\uhanccsharedriver\UHAN_Applications\Uhan_Update.exe", "C:\UHAN_Applications\Uhan_Update.exe", True)
                        'File.Copy("\\172.16.1.24\uhanccsharedriver\UHAN_Applications\Cfg.txt", "C:\UHAN_Applications\Cfg.txt", True)

                    Catch ex As Exception

                    End Try

                    MsgBox("PLEASE DOWNLOAD NEW VERSION THEN DELETE OLD VERSION ON YOUR PC. ONLY USE NEW VERSION")
                    Try
                        'Pass the filepath and filename to the StreamWriter Constructor
                        Using sw As New StreamWriter("C:\UHAN_Applications\Cfg.txt")
                            sw.Write(String.Empty)
                            sw.WriteLine(dt.Rows(0).Item("Application_ID").ToString())
                        End Using
                    Catch ex As Exception
                        ' do nothing
                    End Try
                    Process.Start("C:\UHAN_Applications\Uhan_Update.exe")
                ElseIf Application.ProductVersion.ToString = dt.Rows(0).Item("Current_AssemblyVersion").ToString() Then
                    retval = True

                End If
            End If
        Catch ex As Exception
            retval = False
        End Try
        Return retval
    End Function
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        'Try
        '    Dim asb As System.Reflection.Assembly = Assembly.GetEntryAssembly()
        '    Dim asbName As AssemblyName = asb.GetName()
        '    Dim this_ver As Version = asbName.Version
        '    Dim ui_server As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo("\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe")
        '    Dim server_ver As Version = New Version(ui_server.FileVersion)

        '    If server_ver <> this_ver Then
        '        Dim result As DialogResult = MessageBox.Show("This version: " & this_ver.ToString() & " Please update system now for update some function!", "ComponentID Update", MessageBoxButtons.YesNoCancel)

        '        If result = DialogResult.Yes Then

        '            If server_ver = this_ver Then
        '                timer1.Enabled = False
        '            Else
        '                timer1.Enabled = True
        '            End If
        '        ElseIf result = DialogResult.No Then
        '        Else
        '            Me.Close()
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try
        Me.Text = "ComponentID: " & String.Format("Version {0}", My.Application.Info.Version.ToString)
        Try
            check_openserver()
            If CheckCurrent_Version() Then
                txtLoginID.Focus()
            Else
                Return
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
        'Dim asb As System.Reflection.Assembly = Assembly.GetEntryAssembly()
        'Dim asbName As AssemblyName = asb.GetName()
        'Dim this_ver As Version = asbName.Version
        'Dim ui_server As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo("\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe")
        'Dim server_ver As Version = New Version(ui_server.FileVersion)

        'If server_ver <> this_ver Then
        '    System.Diagnostics.Process.Start("C:\Program Files (x86)\UNIGEN\ComponentLabel\AShengUpdate.exe")
        '    Timer1.Enabled = False
        'End If
    End Sub
End Class