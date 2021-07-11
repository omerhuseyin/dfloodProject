using DFlood.DFLoodDiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DFlood.Forms
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            SettingController.Start();
        }

        private int bootTp, bootScrMd, bootScrPnt, bootDcCheck, bootAutoSave, bootUnlmtd, bootDelete;
        private System.Media.SoundPlayer snd = new SoundPlayer();

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private void Alert(string msg, string dsc, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, dsc, type);
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

        private void GetSetting()
        {
            SetSecureMode.Checked = Properties.Settings.Default.IsSecureMode;
            SetUnlimitedFlood.Checked = Properties.Settings.Default.IsUnlimitedFloodMode;
            SetTopMost.Checked = Properties.Settings.Default.IsTopMostMode;
            SetSecurityPoint.Checked = Properties.Settings.Default.IsSecurityPointMode;
            DiscordTaskChecker.Checked = Properties.Settings.Default.IsDiscordChecker;
            MessageDeleteAfter.Checked = Properties.Settings.Default.IsDeleteAfterMode;
            MinSenderInterval.Value = Properties.Settings.Default.MinimumSenderInterval;
            MaxSenderInterval.Value = Properties.Settings.Default.MaximumSenderInterval;
            SenderFloodCount.Value = Properties.Settings.Default.FloodCount;
            MessageDeleteInterval.Value = Properties.Settings.Default.DeleteAfterInterval;
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.IsSecureMode = SetSecureMode.Checked;
            Properties.Settings.Default.IsUnlimitedFloodMode = SetUnlimitedFlood.Checked;
            Properties.Settings.Default.IsTopMostMode = SetTopMost.Checked;
            Properties.Settings.Default.IsSecurityPointMode = SetSecurityPoint.Checked;
            Properties.Settings.Default.IsDiscordChecker = DiscordTaskChecker.Checked;
            Properties.Settings.Default.IsDeleteAfterMode = MessageDeleteAfter.Checked;
            Properties.Settings.Default.MaximumSenderInterval = Convert.ToByte(MaxSenderInterval.Value);
            Properties.Settings.Default.MinimumSenderInterval = Convert.ToByte(MinSenderInterval.Value);
            Properties.Settings.Default.FloodCount = Convert.ToByte(SenderFloodCount.Value);
            Properties.Settings.Default.DeleteAfterInterval = Convert.ToByte(MessageDeleteInterval.Value);
            Properties.Settings.Default.Save();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            GetSetting();
            SettingController.Start();
        }

        private void SettingController_Tick(object sender, EventArgs e)
        {
            SaveSetting();
        }

        private void SetSecureMode_CheckedChanged(object sender, EventArgs e)
        {
            bootScrMd = bootScrMd + 1;

            if (bootScrMd > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (SetSecureMode.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Güvenli Mod Başarıyla Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (SetSecureMode.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Güvenli Mod Başarıyla Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }

        private void FormSetting_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\dflood.ico");
        }

        private void SetUnlimitedFlood_CheckedChanged(object sender, EventArgs e)
        {
            bootUnlmtd = bootUnlmtd + 1;

            if (bootUnlmtd > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (SetUnlimitedFlood.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Sınırsız Flood Başarıyla Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (SetUnlimitedFlood.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Sınırsız Flood Başarıyla Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }

        private void SetSecurityPoint_CheckedChanged(object sender, EventArgs e)
        {
            bootScrPnt = bootScrPnt + 1;

            if (bootScrPnt > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (SetSecurityPoint.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Güvenlik Puanı Kontrolü Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (SetSecurityPoint.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Güvenlik Puanı Kontrolü Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }

        private void DiscordTaskChecker_CheckedChanged(object sender, EventArgs e)
        {
            bootDcCheck = bootDcCheck + 1;

            if (bootDcCheck > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (DiscordTaskChecker.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Discord Kontrolcüsü Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (DiscordTaskChecker.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Discord Kontrolcüsü Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }


        private void MessageDeleteAfter_CheckedChanged(object sender, EventArgs e)
        {
            bootDelete = bootDelete + 1;

            if (bootDelete > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (MessageDeleteAfter.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Mesaj Silici Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (MessageDeleteAfter.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Mesaj Silici Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }

        private void SetTopMost_CheckedChanged(object sender, EventArgs e)
        {
            bootTp = bootTp + 1;

            if (bootTp > 1)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
                if (SetTopMost.Checked == true)
                {
                    this.TopMost = true;
                    this.Alert("Başarılı", "Pencere Sabitleyici Aktif Edildi", Form_Alert.enmType.Success);
                }
                else if (SetTopMost.Checked == false)
                {
                    this.TopMost = false;
                    this.Alert("Başarılı", "Pencere Sabitleyici Deaktif Edildi", Form_Alert.enmType.Warning);
                }
            }
        }
    }
}