using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

namespace AShengUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShellExecute(string Command)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.Arguments = "/C " + Command;
            startInfo.RedirectStandardError = true;
            //startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                System.Reflection.Assembly asb = Assembly.GetEntryAssembly();
                AssemblyName asbName = asb.GetName();
                Version this_ver = asbName.Version;
                System.Diagnostics.FileVersionInfo ui_server = System.Diagnostics.FileVersionInfo.GetVersionInfo(@"\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe");
                Version server_ver = new Version(ui_server.FileVersion);

                switch (server_ver.CompareTo(this_ver))
                {

                    case 1:
                        ShellExecute("taskkill /F /IM ComponentID.exe");
                        System.Threading.Thread.Sleep(2000);
                        if (File.Exists(@"C:\Program Files (x86)\UNIGEN\ComponentLabel\ComponentID.exe"))

                            File.SetAttributes(@"C:\Program Files (x86)\UNIGEN\ComponentLabel\ComponentID.exe", FileAttributes.Normal);
                        File.Delete(@"C:\Program Files (x86)\UNIGEN\ComponentLabel\ComponentID.exe");
                        File.Copy(@"\\files\UHAN CC Share driver\08.IT\9. Software\ComponentID WH\ComponentID.exe", @"C:\Program Files (x86)\UNIGEN\ComponentLabel\ComponentID.exe", true);
                        System.Diagnostics.Process.Start(@"C:\Program Files (x86)\UNIGEN\ComponentLabel\ComponentID.exe");
                        //Application.ExitThread();
                        break;
                    default: break;
                }
                //ShellExecute("taskkill /F /IM AShengClient.exe");
                //System.Threading.Thread.Sleep(2000);
                ////File.Delete(@"C:\\FlyService\\IDLE.fly");
                //if (File.Exists(@"C:\Windows\AShengClient.exe"))
                //{
                //    File.SetAttributes(@"C:\Windows\AShengClient.exe", FileAttributes.Normal);
                //    File.Delete(@"C:\Windows\AShengClient.exe");
                //}

                ////if (!Directory.Exists("C:\\FlyService")) Directory.CreateDirectory("C:\\Windows");
                //if (File.Exists(@"Z:\Temp\TE-PROGRAM\TE-PRO2\Jerry\Fly\AShengClient.exx"))
                //{
                //    File.Copy(@"Z:\Temp\TE-PROGRAM\TE-PRO2\Jerry\Fly\AShengClient.exx", @"C:\Windows\AShengClient.exe", true);
                //}
                //else
                //{
                //    File.Copy(@"F:\Temp\TE-PROGRAM\TE-PRO2\Jerry\Fly\AShengClient.exx", @"C:\Windows\AShengClient.exe", true);
                //}
               

                //System.Diagnostics.Process.Start(@"C:\Windows\AShengClient.exe");
                //ShellExecute("D:\\AutoDL\\ShowUI.exe");


                Application.Exit();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}
