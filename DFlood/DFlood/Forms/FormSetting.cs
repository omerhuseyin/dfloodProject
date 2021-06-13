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

        private int bootTp, topMostCounter;
        private System.Media.SoundPlayer snd = new SoundPlayer();

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

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

        private void GetSetting()
        {
            SetSecureMode.Checked = Properties.Settings.Default.IsSecureMode;
            SetUnlimitedFlood.Checked = Properties.Settings.Default.IsUnlimitedFloodMode;
            SetTopMost.Checked = Properties.Settings.Default.IsTopMostMode;
            SetSecurityPoint.Checked = Properties.Settings.Default.IsSecurityPointMode;
            DiscordTaskChecker.Checked = Properties.Settings.Default.IsDiscordChecker;
            AutoSave.Checked = Properties.Settings.Default.IsAutoSave;
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
            Properties.Settings.Default.IsAutoSave = AutoSave.Checked;
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

        private void SetTopMost_CheckedChanged(object sender, EventArgs e)
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
    }
}