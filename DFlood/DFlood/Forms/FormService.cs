using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFlood.DFLoodDiscordRPC;

namespace DFlood.Forms
{
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private System.Media.SoundPlayer snd = new SoundPlayer();
        private Random rnd = new Random();
        private OpenFileDialog fileDialog = new OpenFileDialog();
        private OperatingSystem operating = System.Environment.OSVersion;
        private DateTime today = DateTime.Now;

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private int topTimeFloods, messageCount, nextWord, sendFloodCount, messageSendInterval = 1, securityPoint, ssCounter, min = 2, max = 6, messageDeleteInterval, floodCounter;

        private int keyWordsCount, floodCount;
        private bool unlimitedFlood, deleteAfter;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ssCounter = ssCounter + 1;
            if (ssCounter % 2 == 1)
            {
                SendMessage.Start();
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                bunifuButton1.Text = "Servisi Durdur";
                FloodSendService();
            }
            else if (ssCounter % 2 == 0)
            {
                SendMessage.Stop();
                snd.SoundLocation = "success.wav";
                snd.Play();
                bunifuButton1.Text = "Servisi Başlat";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Minimum : {min}";
            label2.Text = $"Maximum : {max}";
            messageSendInterval = messageSendInterval - 1;
            label4.Text = $"Üretilen Kelime {wordlist.Items[nextWord].ToString()}";
        }

        private void GetSettings()
        {
            messageDeleteInterval = Properties.Settings.Default.DeleteAfterInterval;
            min = Convert.ToInt16(Properties.Settings.Default.MinimumSenderInterval);
            max = Convert.ToInt16(Properties.Settings.Default.MaximumSenderInterval);
            bool unlimitedFlood = Properties.Settings.Default.IsUnlimitedFloodMode;
            bool deleteAfter = Properties.Settings.Default.IsDeleteAfterMode;
            int floodCounter = Properties.Settings.Default.FloodCount;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            snd.SoundLocation = "openSound.wav";
            snd.Play();
            DialogResult reply = fileDialog.ShowDialog();

            if (reply == DialogResult.OK)
            {
                wordlist.Items.Clear();
                StreamReader reader = new StreamReader(fileDialog.FileName);
                string line = reader.ReadLine();
                while (line != null)
                {
                    wordlist.Items.Add(line);
                    line = reader.ReadLine();
                }

                snd.SoundLocation = "success.wav";
                snd.Play();
                StartButton.Enabled = true;
                this.Alert($"Import Successfully", Form_Alert.enmType.Success);
                FilePath.Text = fileDialog.FileName;
            }
            else if (reply == DialogResult.Cancel)
            {
                FilePath.Enabled = false;
                StartButton.Enabled = false;
            }
        }

        private void SendMessage_Tick(object sender, EventArgs e)
        {
            messageSendInterval = messageSendInterval - 1;

            if (messageSendInterval == 0)
            {
                if (unlimitedFlood == true)
                {
                    if (deleteAfter == true)
                    {
                        FloodDeleteService();
                        FloodSendService();
                    }
                    else
                    {
                        FloodSendService();
                    }
                }

                if (unlimitedFlood == false)
                {
                    floodCount = floodCount + 1;
                    if (floodCount == floodCounter)
                    {
                        SendMessage.Stop();
                    }

                    if (deleteAfter == true)
                    {
                        FloodDeleteService();
                        FloodSendService();
                    }
                    else
                    {
                        FloodSendService();
                    }
                }
            }
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

        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
            this.presence.smallImageText = "Flood Ekranında";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void FloodSendService()
        {
            min = Convert.ToInt16(Properties.Settings.Default.MinimumSenderInterval);
            max = Convert.ToInt16(Properties.Settings.Default.MaximumSenderInterval);

            messageSendInterval = rnd.Next(min, max);

            keyWordsCount = wordlist.Items.Count;
            nextWord = rnd.Next(0, keyWordsCount);
            wordlist.SelectedIndex = nextWord;

            SendKeys.Send(wordlist.SelectedItem.ToString());
            SendKeys.Send("{ENTER}");

            messageSendInterval = rnd.Next(min, max);

            topTimeFloods = topTimeFloods + 1;
        }

        private void FloodDeleteService()
        {
            SendKeys.Send("{UP}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("^{a}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
            System.Threading.Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ssCounter = ssCounter + 1;
            if (ssCounter % 2 == 1)
            {
                SendMessage.Start();
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                StartButton.Text = "Servisi Durdur";
                FloodSendService();
            }
            else if (ssCounter % 2 == 0)
            {
                SendMessage.Stop();
                snd.SoundLocation = "success.wav";
                snd.Play();
                StartButton.Text = "Servisi Başlat";
            }
        }
    }
}