﻿using ShowMessage;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DFlood
{
    public partial class cheat : Form
    {
        public cheat()
        {
            InitializeComponent();
        }

        private int topMostCounter, startStopCounter, messageCounter, floodCount, nextWord, keyWordsCount;
        private int messageSendInterval = 1, min = 3, max = 6;
        private System.Media.SoundPlayer snd = new SoundPlayer();
        private Random rnd = new Random();
        private OpenFileDialog ofd = new OpenFileDialog();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(int hWnd);

        private void formMover_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        }

        private void MessageDeleteEventListener()
        {
            SendKeys.Send("{UP}");
            SendKeys.Send("^(a)");
            SendKeys.Send("{BACKSPACE}");
            SendKeys.Send("{ENTER}");
            SendKeys.Send("{ENTER}");
        }

        private void messageTimer_Tick(object sender, EventArgs e)
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

        private void deleteAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteAfter.Checked == true)
                MessageDeleteEventListener();
        }

        private void messageDeleteInterval_ValueChanged(object sender, EventArgs e)
        {
            messageDeleteTimer.Interval = Convert.ToInt16(messageDeleteInterval.Value) * 1000;
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
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void messageRefreshTime_MouseDown(object sender, MouseEventArgs e)
        {
            tmrVirusTotal.Start();
        }

        private void cheat_Load(object sender, EventArgs e)
        {
        }

        private void secureMode_CheckedChanged(object sender, EventArgs e)
        {
            snd.SoundLocation = "openSound.wav";
            snd.Play();
            if (secureMode.Checked == true)
            {
                txtMessageSenderIntervalMin.Enabled = false;
                txtFloodCount.Enabled = false;
                txtMessageSenderIntervalMin.Value = txtMessageSenderIntervalMin.Minimum;
                ShowMessage.ShowMessage.MsgShow("Güvenli Mod Başarıyla Etkinleştirildi", "DFlood");
            }
            else if (secureMode.Checked == false)
            {
                txtMessageSenderIntervalMin.Enabled = true;
                txtFloodCount.Enabled = true;
                ShowMessage.ShowMessage.MsgShow("Güvenli Mod Başarıyla Devre Dışı Bırakıldı", "DFlood");
            }
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
                ShowMessage.ShowMessage.MsgShow("Flood Hizmeti Başarıyla Başlatıldı", "DFlood");
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
                ShowMessage.ShowMessage.MsgShow("Flood Hizmeti Başarıyla Kapatıldı. Yapılan Flood : " + messageCounter, MsgType.Success, MsgLanguage.English);
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
                ShowMessage.ShowMessage.MsgShow($"{ofd.FileName} Dosyası Başarıyla DFlood Trainer'a Aktarıldı", "DFlood");
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
            snd.SoundLocation = "openSound.wav";
            snd.Play();

            topMostCounter = topMostCounter + 1;

            if (topMostCounter % 2 == 1)
            {
                this.TopMost = true;
                ShowMessage.ShowMessage.MsgShow("Pencere Sabitleyici Başarıyla Etkinleştirildi", "DFlood");
            }
            else
            {
                this.TopMost = false;
                ShowMessage.ShowMessage.MsgShow("Pencere Sabitleyici Başarıyla Devre Dışı Bırakıldı", "DFlood");
            }
        }

        private void unlimitedFlood_CheckedChanged(object sender, EventArgs e)
        {
            snd.SoundLocation = "openSound.wav";
            snd.Play();

            if (unlimitedFlood.Checked == false)
            {
                ShowMessage.ShowMessage.MsgShow("Sınırsız Flood Başarıyla Devre Dışı Bırakıldı", "DFlood");
                floodCount = Convert.ToInt16(txtFloodCount.Value);
                txtFloodCount.Enabled = true;
            }
            else
            {
                ShowMessage.ShowMessage.MsgShow("Sınırsız Flood Başarıyla Etkinleştirildi", "DFlood");
                txtFloodCount.Enabled = false;
            }
        }


        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength == 0)
                btnStartService.Enabled = false;
            else
                btnStartService.Enabled = true;
        }

        private void txtMessageSenderIntervalMin_ValueChanged(object sender, EventArgs e)
        {
            min = Convert.ToInt16(txtMessageSenderIntervalMin.Value);
        }

        private void txtMessageSenderIntervalMax_ValueChanged(object sender, EventArgs e)
        {
            max = Convert.ToInt16(txtMessageSenderIntervalMax.Value);
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