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

        private int startStopCounter, messageCounter, nextWord, keyWordsCount;
        private int messageSendInterval = 1, min = 2, max = 6, floodCount = 30;
        private System.Media.SoundPlayer snd = new SoundPlayer();
        private Random rnd = new Random();
        private OpenFileDialog ofd = new OpenFileDialog();
        private OperatingSystem OS = System.Environment.OSVersion;
        private DateTime today = DateTime.Now;
        private static int topTimeDeletes, topTimeFloods;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Get()
        {
            topTimeFloods = Properties.Settings.Default.TopTimeFloods;
            topTimeDeletes = Properties.Settings.Default.TopTimeDeleteFloods;
        }

        private static void Save()
        {
            Properties.Settings.Default.TopTimeFloods = topTimeFloods;
            Properties.Settings.Default.TopTimeDeleteFloods = topTimeDeletes;
        }

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

        private void Alert(string msg, string dsc, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, dsc, type);
        }

        private void formMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FloodService()
        {
            min = Convert.ToInt16(Properties.Settings.Default.MinimumSenderInterval);
            max = Convert.ToInt16(Properties.Settings.Default.MaximumSenderInterval);

            keyWordsCount = keywords.Items.Count;
            nextWord = rnd.Next(0, keyWordsCount);
            keywords.SelectedIndex = nextWord;

            SendKeys.Send(keywords.SelectedItem.ToString());
            SendKeys.Send("{ENTER}");
            Properties.Settings.Default.TopTimeFloods = topTimeFloods;
            topTimeFloods = topTimeFloods + messageCounter;
            messageCounter = messageCounter + 1;

            Properties.Settings.Default.Save();

            messageSendInterval = rnd.Next(min, max);
        }

        private void MessageDeleteEventListener()
        {
            topTimeDeletes = topTimeDeletes + 1;
            SendKeys.Send("{UP}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("^(a)");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");

            Properties.Settings.Default.TopTimeDeleteFloods = topTimeDeletes;
            Properties.Settings.Default.Save();
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
                        topTimeDeletes = topTimeDeletes + 1;
                        messageCounter = messageCounter + 1;
                        topTimeFloods = topTimeFloods + messageCounter;

                        Properties.Settings.Default.TopTimeFloods = topTimeFloods;
                        Properties.Settings.Default.TopTimeDeleteFloods = topTimeDeletes;
                        Properties.Settings.Default.Save();

                        messageSendInterval = rnd.Next(min, max);
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

        [Obsolete]
        private void main_Load(object sender, EventArgs e)
        {
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
                this.Alert("Başarılı", "Flood Hizmeti Başlatıldı", Form_Alert.enmType.Success);
            }
            else if (startStopCounter % 2 == 0)
            {
                Properties.Settings.Default.Save();
                snd.SoundLocation = "success.wav";
                btnStartService.Text = "Hizmeti Başlat";
                snd.Play();
                this.Alert("Başarılı", "Flood Hizmeti Durduruldu", Form_Alert.enmType.Warning);
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
                this.Alert($"Başarılı", "Metin Dosyası Başarıyla Aktarıldı", Form_Alert.enmType.Success);

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