
namespace DFlood
{
    partial class cheat
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
            this.formMover = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOwO = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.btnImport = new MaterialSkin.Controls.MaterialButton();
            this.txtFilePath = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFloodCount = new Guna.UI.WinForms.GunaNumeric();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMessageSenderIntervalMin = new Guna.UI.WinForms.GunaNumeric();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.optUnlimitedFlood = new Guna.UI.WinForms.GunaSwitch();
            this.optSecureMode = new Guna.UI.WinForms.GunaSwitch();
            this.label15 = new System.Windows.Forms.Label();
            this.tmrVirusTotal = new System.Windows.Forms.Timer(this.components);
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnStartService = new MaterialSkin.Controls.MaterialButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMessageSenderIntervalMax = new Guna.UI.WinForms.GunaNumeric();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.topMostSwitch = new Guna.UI.WinForms.GunaSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.messageDeleteInterval = new Siticone.UI.WinForms.SiticoneNumericUpDown();
            this.deleteAfter = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.keywords = new System.Windows.Forms.ListBox();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.messageRefreshTime = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messageDeleteTimer = new System.Windows.Forms.Timer(this.components);
            this.ofdTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.formMover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            this.gunaGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageDeleteInterval)).BeginInit();
            this.gunaGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formMover
            // 
            this.formMover.Controls.Add(this.label1);
            this.formMover.Controls.Add(this.btnOwO);
            this.formMover.Controls.Add(this.btnMinimize);
            this.formMover.Controls.Add(this.btnExit);
            this.formMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.formMover.Location = new System.Drawing.Point(0, 0);
            this.formMover.Name = "formMover";
            this.formMover.Size = new System.Drawing.Size(861, 35);
            this.formMover.TabIndex = 0;
            this.formMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMover_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "DFlood Spam Trainer ";
            // 
            // btnOwO
            // 
            this.btnOwO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwO.Image = global::DFlood.Properties.Resources.discord_24px1;
            this.btnOwO.Location = new System.Drawing.Point(14, 7);
            this.btnOwO.Name = "btnOwO";
            this.btnOwO.Size = new System.Drawing.Size(20, 20);
            this.btnOwO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOwO.TabIndex = 3;
            this.btnOwO.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::DFlood.Properties.Resources.yellow_circle;
            this.btnMinimize.Location = new System.Drawing.Point(791, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::DFlood.Properties.Resources.red_circle;
            this.btnExit.Location = new System.Drawing.Point(828, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 36);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "github.com/omerhuseyingul";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(355, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "DFlood | All Rights Are Free";
            // 
            // elipseForm
            // 
            this.elipseForm.Radius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 1000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // btnImport
            // 
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Depth = 0;
            this.btnImport.DrawShadows = true;
            this.btnImport.HighEmphasis = true;
            this.btnImport.Icon = null;
            this.btnImport.Location = new System.Drawing.Point(10, 122);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(107, 36);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "İçeri Aktar";
            this.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImport.UseAccentColor = false;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.ForeColor = System.Drawing.Color.Black;
            this.txtFilePath.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFilePath.Location = new System.Drawing.Point(10, 82);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(251, 31);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Metin Dosyasını İçeri Aktar";
            // 
            // txtFloodCount
            // 
            this.txtFloodCount.AllowDrop = true;
            this.txtFloodCount.BackColor = System.Drawing.Color.Transparent;
            this.txtFloodCount.BaseColor = System.Drawing.Color.White;
            this.txtFloodCount.BorderColor = System.Drawing.Color.Silver;
            this.txtFloodCount.BorderSize = 0;
            this.txtFloodCount.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFloodCount.ButtonForeColor = System.Drawing.Color.White;
            this.txtFloodCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFloodCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFloodCount.ForeColor = System.Drawing.Color.Black;
            this.txtFloodCount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFloodCount.Location = new System.Drawing.Point(196, 137);
            this.txtFloodCount.Maximum = ((long)(60));
            this.txtFloodCount.Minimum = ((long)(1));
            this.txtFloodCount.Name = "txtFloodCount";
            this.txtFloodCount.Radius = 600;
            this.txtFloodCount.Size = new System.Drawing.Size(63, 30);
            this.txtFloodCount.TabIndex = 1;
            this.txtFloodCount.Value = ((long)(5));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Atılacak Flood Sayısı (30 - ∞ ) : ";
            // 
            // txtMessageSenderIntervalMin
            // 
            this.txtMessageSenderIntervalMin.AllowDrop = true;
            this.txtMessageSenderIntervalMin.BackColor = System.Drawing.Color.Transparent;
            this.txtMessageSenderIntervalMin.BaseColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMin.BorderColor = System.Drawing.Color.Silver;
            this.txtMessageSenderIntervalMin.BorderSize = 0;
            this.txtMessageSenderIntervalMin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMin.ButtonForeColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtMessageSenderIntervalMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessageSenderIntervalMin.ForeColor = System.Drawing.Color.Black;
            this.txtMessageSenderIntervalMin.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtMessageSenderIntervalMin.Location = new System.Drawing.Point(196, 42);
            this.txtMessageSenderIntervalMin.Maximum = ((long)(5));
            this.txtMessageSenderIntervalMin.Minimum = ((long)(1));
            this.txtMessageSenderIntervalMin.Name = "txtMessageSenderIntervalMin";
            this.txtMessageSenderIntervalMin.Radius = 600;
            this.txtMessageSenderIntervalMin.Size = new System.Drawing.Size(63, 30);
            this.txtMessageSenderIntervalMin.TabIndex = 1;
            this.txtMessageSenderIntervalMin.Value = ((long)(3));
            this.txtMessageSenderIntervalMin.ValueChanged += new System.EventHandler(this.txtMessageSenderIntervalMin_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gönderme Aralığı (minimum) : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Güvenli Mod";
            // 
            // optUnlimitedFlood
            // 
            this.optUnlimitedFlood.BaseColor = System.Drawing.SystemColors.Control;
            this.optUnlimitedFlood.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.optUnlimitedFlood.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.optUnlimitedFlood.FillColor = System.Drawing.Color.White;
            this.optUnlimitedFlood.Location = new System.Drawing.Point(171, 94);
            this.optUnlimitedFlood.Name = "optUnlimitedFlood";
            this.optUnlimitedFlood.Size = new System.Drawing.Size(28, 20);
            this.optUnlimitedFlood.TabIndex = 2;
            this.optUnlimitedFlood.CheckedChanged += new System.EventHandler(this.optUnlimitedFlood_CheckedChanged);
            // 
            // optSecureMode
            // 
            this.optSecureMode.BaseColor = System.Drawing.SystemColors.Control;
            this.optSecureMode.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.optSecureMode.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.optSecureMode.FillColor = System.Drawing.Color.White;
            this.optSecureMode.Location = new System.Drawing.Point(171, 65);
            this.optSecureMode.Name = "optSecureMode";
            this.optSecureMode.Size = new System.Drawing.Size(30, 20);
            this.optSecureMode.TabIndex = 1;
            this.optSecureMode.CheckedChanged += new System.EventHandler(this.optSecureMode_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Sonsuz Flood";
            // 
            // tmrVirusTotal
            // 
            this.tmrVirusTotal.Interval = 10;
            this.tmrVirusTotal.Tick += new System.EventHandler(this.tmrVirusTotal_Tick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnStartService);
            this.gunaGroupBox1.Controls.Add(this.btnImport);
            this.gunaGroupBox1.Controls.Add(this.txtFilePath);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(28, 56);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(272, 192);
            this.gunaGroupBox1.TabIndex = 6;
            this.gunaGroupBox1.Text = "[DFlood Trainer] Hizmet Başlatıcısı";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnStartService
            // 
            this.btnStartService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartService.Depth = 0;
            this.btnStartService.DrawShadows = true;
            this.btnStartService.Enabled = false;
            this.btnStartService.HighEmphasis = true;
            this.btnStartService.Icon = null;
            this.btnStartService.Location = new System.Drawing.Point(122, 122);
            this.btnStartService.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartService.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(137, 36);
            this.btnStartService.TabIndex = 4;
            this.btnStartService.Text = "Hizmeti Başlat";
            this.btnStartService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartService.UseAccentColor = false;
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txtFloodCount);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.txtMessageSenderIntervalMax);
            this.gunaGroupBox2.Controls.Add(this.txtMessageSenderIntervalMin);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(28, 264);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(272, 179);
            this.gunaGroupBox2.TabIndex = 7;
            this.gunaGroupBox2.Text = "[DFlood Trainer] Gönderme Ayarları";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gönderme Aralığı (maximum) : ";
            // 
            // txtMessageSenderIntervalMax
            // 
            this.txtMessageSenderIntervalMax.AllowDrop = true;
            this.txtMessageSenderIntervalMax.BackColor = System.Drawing.Color.Transparent;
            this.txtMessageSenderIntervalMax.BaseColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMax.BorderColor = System.Drawing.Color.Silver;
            this.txtMessageSenderIntervalMax.BorderSize = 0;
            this.txtMessageSenderIntervalMax.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMax.ButtonForeColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMessageSenderIntervalMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessageSenderIntervalMax.ForeColor = System.Drawing.Color.Black;
            this.txtMessageSenderIntervalMax.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMessageSenderIntervalMax.Location = new System.Drawing.Point(196, 92);
            this.txtMessageSenderIntervalMax.Maximum = ((long)(10));
            this.txtMessageSenderIntervalMax.Minimum = ((long)(6));
            this.txtMessageSenderIntervalMax.Name = "txtMessageSenderIntervalMax";
            this.txtMessageSenderIntervalMax.Radius = 600;
            this.txtMessageSenderIntervalMax.Size = new System.Drawing.Size(63, 30);
            this.txtMessageSenderIntervalMax.TabIndex = 1;
            this.txtMessageSenderIntervalMax.Value = ((long)(6));
            this.txtMessageSenderIntervalMax.ValueChanged += new System.EventHandler(this.txtMessageSenderIntervalMax_ValueChanged);
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Empty;
            this.gunaGroupBox3.Controls.Add(this.topMostSwitch);
            this.gunaGroupBox3.Controls.Add(this.optUnlimitedFlood);
            this.gunaGroupBox3.Controls.Add(this.label11);
            this.gunaGroupBox3.Controls.Add(this.optSecureMode);
            this.gunaGroupBox3.Controls.Add(this.label6);
            this.gunaGroupBox3.Controls.Add(this.label15);
            this.gunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox3.Location = new System.Drawing.Point(324, 56);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(272, 192);
            this.gunaGroupBox3.TabIndex = 8;
            this.gunaGroupBox3.Text = "[DFlood Trainer] Çalışma Ayarları";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // topMostSwitch
            // 
            this.topMostSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.topMostSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.topMostSwitch.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.topMostSwitch.FillColor = System.Drawing.Color.White;
            this.topMostSwitch.Location = new System.Drawing.Point(171, 126);
            this.topMostSwitch.Name = "topMostSwitch";
            this.topMostSwitch.Size = new System.Drawing.Size(28, 20);
            this.topMostSwitch.TabIndex = 3;
            this.topMostSwitch.CheckedChanged += new System.EventHandler(this.topMostSwitch_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pencere Sabitle";
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Controls.Add(this.label13);
            this.gunaGroupBox4.Controls.Add(this.messageDeleteInterval);
            this.gunaGroupBox4.Controls.Add(this.deleteAfter);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox4.Location = new System.Drawing.Point(324, 264);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Size = new System.Drawing.Size(272, 179);
            this.gunaGroupBox4.TabIndex = 7;
            this.gunaGroupBox4.Text = "[DFlood Trainer] Silme Ayarları";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Silme Süresi : ";
            // 
            // messageDeleteInterval
            // 
            this.messageDeleteInterval.BackColor = System.Drawing.Color.Transparent;
            this.messageDeleteInterval.BorderThickness = 0;
            this.messageDeleteInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageDeleteInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageDeleteInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageDeleteInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageDeleteInterval.DisabledState.Parent = this.messageDeleteInterval;
            this.messageDeleteInterval.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.messageDeleteInterval.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.messageDeleteInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageDeleteInterval.FocusedState.Parent = this.messageDeleteInterval;
            this.messageDeleteInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDeleteInterval.ForeColor = System.Drawing.Color.Black;
            this.messageDeleteInterval.Location = new System.Drawing.Point(146, 114);
            this.messageDeleteInterval.Name = "messageDeleteInterval";
            this.messageDeleteInterval.ShadowDecoration.Parent = this.messageDeleteInterval;
            this.messageDeleteInterval.Size = new System.Drawing.Size(63, 27);
            this.messageDeleteInterval.TabIndex = 2;
            this.messageDeleteInterval.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageDeleteInterval.UpDownButtonForeColor = System.Drawing.Color.White;
            this.messageDeleteInterval.ValueChanged += new System.EventHandler(this.messageDeleteInterval_ValueChanged);
            // 
            // deleteAfter
            // 
            this.deleteAfter.AutoSize = true;
            this.deleteAfter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deleteAfter.CheckedState.BorderRadius = 2;
            this.deleteAfter.CheckedState.BorderThickness = 0;
            this.deleteAfter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deleteAfter.Location = new System.Drawing.Point(51, 71);
            this.deleteAfter.Name = "deleteAfter";
            this.deleteAfter.Size = new System.Drawing.Size(168, 21);
            this.deleteAfter.TabIndex = 1;
            this.deleteAfter.Text = "Mesajı Attıktan Sonra Sil";
            this.deleteAfter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.deleteAfter.UncheckedState.BorderRadius = 2;
            this.deleteAfter.UncheckedState.BorderThickness = 0;
            this.deleteAfter.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.deleteAfter.UseVisualStyleBackColor = true;
            this.deleteAfter.CheckedChanged += new System.EventHandler(this.deleteAfter_CheckedChanged);
            // 
            // keywords
            // 
            this.keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.keywords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keywords.ForeColor = System.Drawing.Color.White;
            this.keywords.FormattingEnabled = true;
            this.keywords.HorizontalScrollbar = true;
            this.keywords.ItemHeight = 17;
            this.keywords.Location = new System.Drawing.Point(0, 29);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(216, 187);
            this.keywords.TabIndex = 9;
            // 
            // gunaGroupBox5
            // 
            this.gunaGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BorderColor = System.Drawing.Color.Empty;
            this.gunaGroupBox5.Controls.Add(this.keywords);
            this.gunaGroupBox5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox5.Location = new System.Drawing.Point(621, 56);
            this.gunaGroupBox5.Name = "gunaGroupBox5";
            this.gunaGroupBox5.Size = new System.Drawing.Size(219, 236);
            this.gunaGroupBox5.TabIndex = 0;
            this.gunaGroupBox5.Text = "[DFlood Trainer] Kelime Listesi";
            this.gunaGroupBox5.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // messageRefreshTime
            // 
            this.messageRefreshTime.AnimationSpeed = 0.6F;
            this.messageRefreshTime.BaseColor = System.Drawing.Color.Gainsboro;
            this.messageRefreshTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messageRefreshTime.IdleColor = System.Drawing.Color.Gainsboro;
            this.messageRefreshTime.IdleOffset = 20;
            this.messageRefreshTime.IdleThickness = 15;
            this.messageRefreshTime.Image = global::DFlood.Properties.Resources.discord_will_provide_official_verification_esports_team_4;
            this.messageRefreshTime.ImageSize = new System.Drawing.Size(120, 120);
            this.messageRefreshTime.Location = new System.Drawing.Point(653, 301);
            this.messageRefreshTime.Maximum = 1000;
            this.messageRefreshTime.Name = "messageRefreshTime";
            this.messageRefreshTime.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageRefreshTime.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageRefreshTime.ProgressOffset = 20;
            this.messageRefreshTime.ProgressThickness = 30;
            this.messageRefreshTime.Size = new System.Drawing.Size(144, 144);
            this.messageRefreshTime.TabIndex = 4;
            this.messageRefreshTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.messageRefreshTime_MouseDown);
            this.messageRefreshTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.messageRefreshTime_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DFlood.Properties.Resources.rgbline;
            this.pictureBox2.Location = new System.Drawing.Point(3, 487);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(862, 10);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DFlood.Properties.Resources.rgbline;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 10);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // messageDeleteTimer
            // 
            this.messageDeleteTimer.Interval = 1000;
            this.messageDeleteTimer.Tick += new System.EventHandler(this.messageDeleteTimer_Tick);
            // 
            // ofdTimer
            // 
            this.ofdTimer.Interval = 1000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "BETA";
            // 
            // cheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(861, 526);
            this.Controls.Add(this.gunaGroupBox5);
            this.Controls.Add(this.messageRefreshTime);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox4);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formMover);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cheat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwO Bot External Trainer";
            this.Load += new System.EventHandler(this.cheat_Load);
            this.formMover.ResumeLayout(false);
            this.formMover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageDeleteInterval)).EndInit();
            this.gunaGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formMover;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnOwO;
        private Guna.UI.WinForms.GunaElipse elipseForm;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox txtFilePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer messageTimer;
        private Guna.UI.WinForms.GunaNumeric txtMessageSenderIntervalMin;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialButton btnImport;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaCircleProgressBar messageRefreshTime;
        private Guna.UI.WinForms.GunaSwitch optSecureMode;
        private Guna.UI.WinForms.GunaSwitch optUnlimitedFlood;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaNumeric txtFloodCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrVirusTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaNumeric txtMessageSenderIntervalMax;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox5;
        private System.Windows.Forms.ListBox keywords;
        private System.Windows.Forms.Label label16;
        private Siticone.UI.WinForms.SiticoneCheckBox deleteAfter;
        private System.Windows.Forms.Label label13;
        private Siticone.UI.WinForms.SiticoneNumericUpDown messageDeleteInterval;
        private Guna.UI.WinForms.GunaSwitch topMostSwitch;
        private System.Windows.Forms.Timer messageDeleteTimer;
        private System.Windows.Forms.Timer ofdTimer;
        private MaterialSkin.Controls.MaterialButton btnStartService;
        private System.Windows.Forms.Label label2;
    }
}