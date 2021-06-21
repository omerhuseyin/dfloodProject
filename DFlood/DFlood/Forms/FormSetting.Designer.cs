
namespace DFlood.Forms
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSendSettings = new Guna.UI.WinForms.GunaGroupBox();
            this.SenderFloodCount = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxSenderInterval = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.lblMaxSenderInterval = new System.Windows.Forms.Label();
            this.MinSenderInterval = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.grpWorkSettings = new Guna.UI.WinForms.GunaGroupBox();
            this.MessageDeleteInterval = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.MessageDeleteAfter = new Guna.UI.WinForms.GunaCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.SetSecurityPoint = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SetTopMost = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SetUnlimitedFlood = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SetSecureMode = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.langUs = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.langTr = new System.Windows.Forms.PictureBox();
            this.AutoSave = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.DiscordTaskChecker = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SettingController = new System.Windows.Forms.Timer(this.components);
            this.grpSendSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SenderFloodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSenderInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSenderInterval)).BeginInit();
            this.grpWorkSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageDeleteInterval)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.langUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langTr)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSendSettings
            // 
            this.grpSendSettings.BackColor = System.Drawing.Color.Transparent;
            this.grpSendSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.grpSendSettings.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpSendSettings.Controls.Add(this.SenderFloodCount);
            this.grpSendSettings.Controls.Add(this.label2);
            this.grpSendSettings.Controls.Add(this.label1);
            this.grpSendSettings.Controls.Add(this.MaxSenderInterval);
            this.grpSendSettings.Controls.Add(this.lblMaxSenderInterval);
            this.grpSendSettings.Controls.Add(this.MinSenderInterval);
            this.grpSendSettings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSendSettings.ForeColor = System.Drawing.Color.White;
            this.grpSendSettings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.grpSendSettings.Location = new System.Drawing.Point(12, 8);
            this.grpSendSettings.Name = "grpSendSettings";
            this.grpSendSettings.Size = new System.Drawing.Size(295, 153);
            this.grpSendSettings.TabIndex = 0;
            this.grpSendSettings.Text = "Flood Gönderme Ayarları";
            this.grpSendSettings.TextLocation = new System.Drawing.Point(70, 8);
            // 
            // SenderFloodCount
            // 
            this.SenderFloodCount.BackColor = System.Drawing.Color.Transparent;
            this.SenderFloodCount.BorderThickness = 0;
            this.SenderFloodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SenderFloodCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SenderFloodCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SenderFloodCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SenderFloodCount.DisabledState.Parent = this.SenderFloodCount;
            this.SenderFloodCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.SenderFloodCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.SenderFloodCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SenderFloodCount.FocusedState.Parent = this.SenderFloodCount;
            this.SenderFloodCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderFloodCount.ForeColor = System.Drawing.Color.Black;
            this.SenderFloodCount.Location = new System.Drawing.Point(207, 111);
            this.SenderFloodCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SenderFloodCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SenderFloodCount.Name = "SenderFloodCount";
            this.SenderFloodCount.ShadowDecoration.Parent = this.SenderFloodCount;
            this.SenderFloodCount.Size = new System.Drawing.Size(52, 26);
            this.SenderFloodCount.TabIndex = 10;
            this.SenderFloodCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SenderFloodCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.SenderFloodCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gönderilecek Flood Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Maksimum Gönderme Süresi";
            // 
            // MaxSenderInterval
            // 
            this.MaxSenderInterval.BackColor = System.Drawing.Color.Transparent;
            this.MaxSenderInterval.BorderThickness = 0;
            this.MaxSenderInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxSenderInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaxSenderInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaxSenderInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxSenderInterval.DisabledState.Parent = this.MaxSenderInterval;
            this.MaxSenderInterval.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.MaxSenderInterval.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.MaxSenderInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaxSenderInterval.FocusedState.Parent = this.MaxSenderInterval;
            this.MaxSenderInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSenderInterval.ForeColor = System.Drawing.Color.Black;
            this.MaxSenderInterval.Location = new System.Drawing.Point(207, 76);
            this.MaxSenderInterval.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MaxSenderInterval.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.MaxSenderInterval.Name = "MaxSenderInterval";
            this.MaxSenderInterval.ShadowDecoration.Parent = this.MaxSenderInterval;
            this.MaxSenderInterval.Size = new System.Drawing.Size(52, 26);
            this.MaxSenderInterval.TabIndex = 12;
            this.MaxSenderInterval.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MaxSenderInterval.UpDownButtonForeColor = System.Drawing.Color.White;
            this.MaxSenderInterval.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblMaxSenderInterval
            // 
            this.lblMaxSenderInterval.AutoSize = true;
            this.lblMaxSenderInterval.Location = new System.Drawing.Point(25, 47);
            this.lblMaxSenderInterval.Name = "lblMaxSenderInterval";
            this.lblMaxSenderInterval.Size = new System.Drawing.Size(165, 17);
            this.lblMaxSenderInterval.TabIndex = 11;
            this.lblMaxSenderInterval.Text = "Minimum Gönderme Süresi";
            // 
            // MinSenderInterval
            // 
            this.MinSenderInterval.BackColor = System.Drawing.Color.Transparent;
            this.MinSenderInterval.BorderThickness = 0;
            this.MinSenderInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinSenderInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MinSenderInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinSenderInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinSenderInterval.DisabledState.Parent = this.MinSenderInterval;
            this.MinSenderInterval.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.MinSenderInterval.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.MinSenderInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinSenderInterval.FocusedState.Parent = this.MinSenderInterval;
            this.MinSenderInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSenderInterval.ForeColor = System.Drawing.Color.Black;
            this.MinSenderInterval.Location = new System.Drawing.Point(207, 42);
            this.MinSenderInterval.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinSenderInterval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MinSenderInterval.Name = "MinSenderInterval";
            this.MinSenderInterval.ShadowDecoration.Parent = this.MinSenderInterval;
            this.MinSenderInterval.Size = new System.Drawing.Size(52, 26);
            this.MinSenderInterval.TabIndex = 10;
            this.MinSenderInterval.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MinSenderInterval.UpDownButtonForeColor = System.Drawing.Color.White;
            this.MinSenderInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grpWorkSettings
            // 
            this.grpWorkSettings.BackColor = System.Drawing.Color.Transparent;
            this.grpWorkSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.grpWorkSettings.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpWorkSettings.Controls.Add(this.MessageDeleteInterval);
            this.grpWorkSettings.Controls.Add(this.MessageDeleteAfter);
            this.grpWorkSettings.Controls.Add(this.label3);
            this.grpWorkSettings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpWorkSettings.ForeColor = System.Drawing.Color.White;
            this.grpWorkSettings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.grpWorkSettings.Location = new System.Drawing.Point(12, 167);
            this.grpWorkSettings.Name = "grpWorkSettings";
            this.grpWorkSettings.Size = new System.Drawing.Size(295, 153);
            this.grpWorkSettings.TabIndex = 0;
            this.grpWorkSettings.Text = "Mesaj Silme Ayarları";
            this.grpWorkSettings.TextLocation = new System.Drawing.Point(89, 8);
            // 
            // MessageDeleteInterval
            // 
            this.MessageDeleteInterval.BackColor = System.Drawing.Color.Transparent;
            this.MessageDeleteInterval.BorderThickness = 0;
            this.MessageDeleteInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageDeleteInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageDeleteInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageDeleteInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageDeleteInterval.DisabledState.Parent = this.MessageDeleteInterval;
            this.MessageDeleteInterval.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.MessageDeleteInterval.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.MessageDeleteInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageDeleteInterval.FocusedState.Parent = this.MessageDeleteInterval;
            this.MessageDeleteInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDeleteInterval.ForeColor = System.Drawing.Color.Black;
            this.MessageDeleteInterval.Location = new System.Drawing.Point(186, 107);
            this.MessageDeleteInterval.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MessageDeleteInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MessageDeleteInterval.Name = "MessageDeleteInterval";
            this.MessageDeleteInterval.ShadowDecoration.Parent = this.MessageDeleteInterval;
            this.MessageDeleteInterval.Size = new System.Drawing.Size(52, 26);
            this.MessageDeleteInterval.TabIndex = 10;
            this.MessageDeleteInterval.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MessageDeleteInterval.UpDownButtonForeColor = System.Drawing.Color.White;
            this.MessageDeleteInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MessageDeleteAfter
            // 
            this.MessageDeleteAfter.BaseColor = System.Drawing.Color.White;
            this.MessageDeleteAfter.CheckedOffColor = System.Drawing.Color.Gray;
            this.MessageDeleteAfter.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MessageDeleteAfter.FillColor = System.Drawing.Color.White;
            this.MessageDeleteAfter.Location = new System.Drawing.Point(71, 69);
            this.MessageDeleteAfter.Name = "MessageDeleteAfter";
            this.MessageDeleteAfter.Size = new System.Drawing.Size(150, 20);
            this.MessageDeleteAfter.TabIndex = 0;
            this.MessageDeleteAfter.Text = "Mesaj Attıktan Sonra Sil";
            this.MessageDeleteAfter.CheckedChanged += new System.EventHandler(this.MessageDeleteAfter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mesaj Silme Süresi";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.SetSecurityPoint);
            this.gunaGroupBox1.Controls.Add(this.SetTopMost);
            this.gunaGroupBox1.Controls.Add(this.SetUnlimitedFlood);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.SetSecureMode);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(346, 8);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(295, 153);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Algoritma";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(110, 8);
            // 
            // SetSecurityPoint
            // 
            this.SetSecurityPoint.Location = new System.Drawing.Point(186, 116);
            this.SetSecurityPoint.Name = "SetSecurityPoint";
            this.SetSecurityPoint.Size = new System.Drawing.Size(26, 17);
            this.SetSecurityPoint.TabIndex = 5;
            this.SetSecurityPoint.Text = "siticoneOSToggleSwith1";
            this.SetSecurityPoint.CheckedChanged += new System.EventHandler(this.SetSecurityPoint_CheckedChanged);
            // 
            // SetTopMost
            // 
            this.SetTopMost.Location = new System.Drawing.Point(186, 93);
            this.SetTopMost.Name = "SetTopMost";
            this.SetTopMost.Size = new System.Drawing.Size(26, 17);
            this.SetTopMost.TabIndex = 8;
            this.SetTopMost.Text = "siticoneOSToggleSwith1";
            this.SetTopMost.CheckedChanged += new System.EventHandler(this.SetTopMost_CheckedChanged);
            // 
            // SetUnlimitedFlood
            // 
            this.SetUnlimitedFlood.Location = new System.Drawing.Point(186, 68);
            this.SetUnlimitedFlood.Name = "SetUnlimitedFlood";
            this.SetUnlimitedFlood.Size = new System.Drawing.Size(26, 17);
            this.SetUnlimitedFlood.TabIndex = 7;
            this.SetUnlimitedFlood.Text = "siticoneOSToggleSwith1";
            this.SetUnlimitedFlood.CheckedChanged += new System.EventHandler(this.SetUnlimitedFlood_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Güvenlik Puanı ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pencere Sabitle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sınırsız Flood ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Güvenli Mod ";
            // 
            // SetSecureMode
            // 
            this.SetSecureMode.Location = new System.Drawing.Point(186, 42);
            this.SetSecureMode.Name = "SetSecureMode";
            this.SetSecureMode.Size = new System.Drawing.Size(26, 17);
            this.SetSecureMode.TabIndex = 5;
            this.SetSecureMode.Text = "siticoneOSToggleSwith1";
            this.SetSecureMode.CheckedChanged += new System.EventHandler(this.SetSecureMode_CheckedChanged);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.langUs);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.langTr);
            this.gunaGroupBox2.Controls.Add(this.AutoSave);
            this.gunaGroupBox2.Controls.Add(this.DiscordTaskChecker);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(346, 167);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(295, 153);
            this.gunaGroupBox2.TabIndex = 0;
            this.gunaGroupBox2.Text = "Diğer Ayarlar";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(105, 8);
            // 
            // langUs
            // 
            this.langUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langUs.Image = global::DFlood.Properties.Resources.usaflag;
            this.langUs.Location = new System.Drawing.Point(178, 100);
            this.langUs.Name = "langUs";
            this.langUs.Size = new System.Drawing.Size(33, 33);
            this.langUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.langUs.TabIndex = 11;
            this.langUs.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "DFlood Dili : ";
            // 
            // langTr
            // 
            this.langTr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langTr.Image = global::DFlood.Properties.Resources.trflag;
            this.langTr.Location = new System.Drawing.Point(133, 100);
            this.langTr.Name = "langTr";
            this.langTr.Size = new System.Drawing.Size(33, 33);
            this.langTr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.langTr.TabIndex = 9;
            this.langTr.TabStop = false;
            // 
            // AutoSave
            // 
            this.AutoSave.Location = new System.Drawing.Point(220, 71);
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(26, 17);
            this.AutoSave.TabIndex = 5;
            this.AutoSave.Text = "siticoneOSToggleSwith1";
            this.AutoSave.CheckedChanged += new System.EventHandler(this.AutoSave_CheckedChanged);
            // 
            // DiscordTaskChecker
            // 
            this.DiscordTaskChecker.Location = new System.Drawing.Point(220, 47);
            this.DiscordTaskChecker.Name = "DiscordTaskChecker";
            this.DiscordTaskChecker.Size = new System.Drawing.Size(26, 17);
            this.DiscordTaskChecker.TabIndex = 8;
            this.DiscordTaskChecker.Text = "siticoneOSToggleSwith1";
            this.DiscordTaskChecker.CheckedChanged += new System.EventHandler(this.DiscordTaskChecker_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Otomatik Ayar Kaydetme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Discord Kapalıysa Aç";
            // 
            // SettingController
            // 
            this.SettingController.Tick += new System.EventHandler(this.SettingController_Tick);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.grpWorkSettings);
            this.Controls.Add(this.grpSendSettings);
            this.Name = "FormSetting";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.grpSendSettings.ResumeLayout(false);
            this.grpSendSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SenderFloodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSenderInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSenderInterval)).EndInit();
            this.grpWorkSettings.ResumeLayout(false);
            this.grpWorkSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageDeleteInterval)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.langUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langTr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grpSendSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxSenderInterval;
        private Guna.UI.WinForms.GunaGroupBox grpWorkSettings;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith DiscordTaskChecker;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith AutoSave;
        public Guna.UI.WinForms.GunaCheckBox MessageDeleteAfter;
        public Siticone.UI.WinForms.SiticoneRoundedNumericUpDown MessageDeleteInterval;
        public System.Windows.Forms.Label label3;
        public Siticone.UI.WinForms.SiticoneRoundedNumericUpDown SenderFloodCount;
        public Siticone.UI.WinForms.SiticoneRoundedNumericUpDown MaxSenderInterval;
        public Siticone.UI.WinForms.SiticoneRoundedNumericUpDown MinSenderInterval;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith SetSecureMode;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith SetUnlimitedFlood;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith SetTopMost;
        public Siticone.UI.WinForms.SiticoneOSToggleSwith SetSecurityPoint;
        private System.Windows.Forms.Timer SettingController;
        private System.Windows.Forms.PictureBox langTr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox langUs;
    }
}