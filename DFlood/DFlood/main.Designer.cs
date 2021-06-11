
namespace DFlood
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.formMover = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tmrVirusTotal = new System.Windows.Forms.Timer(this.components);
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtFilePath = new Guna.UI.WinForms.GunaTextBox();
            this.btnStartService = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.btnImport = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtFloodCount = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.txtMessageSenderIntervalMax = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.txtMessageSenderIntervalMin = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.topMost = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.unlimitedFlood = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.secureMode = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.messageDeleteInterval = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteAfter = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.keywords = new System.Windows.Forms.ListBox();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.messageDeleteTimer = new System.Windows.Forms.Timer(this.components);
            this.ofdTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageRefreshTime = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formMover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageSenderIntervalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageSenderIntervalMin)).BeginInit();
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
            this.formMover.Controls.Add(this.btnMinimize);
            this.formMover.Controls.Add(this.btnAbout);
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
            this.label1.Location = new System.Drawing.Point(717, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "DFlood Spam Trainer ";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::DFlood.Properties.Resources.yellow_circle;
            this.btnMinimize.Location = new System.Drawing.Point(33, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 17);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Image = global::DFlood.Properties.Resources.green_circle;
            this.btnAbout.Location = new System.Drawing.Point(52, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(17, 17);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 2;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::DFlood.Properties.Resources.red_circle;
            this.btnExit.Location = new System.Drawing.Point(14, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(17, 17);
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
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "github.com/omerhuseyingul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "v0.2";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Metin Dosyasını İçeri Aktar";
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
            this.gunaGroupBox1.Controls.Add(this.txtFilePath);
            this.gunaGroupBox1.Controls.Add(this.btnStartService);
            this.gunaGroupBox1.Controls.Add(this.btnImport);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(28, 56);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(272, 192);
            this.gunaGroupBox1.TabIndex = 6;
            this.gunaGroupBox1.Text = "[DFlood Trainer] Hizmet Başlatıcısı";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.Transparent;
            this.txtFilePath.BaseColor = System.Drawing.Color.White;
            this.txtFilePath.BorderColor = System.Drawing.Color.Silver;
            this.txtFilePath.BorderSize = 0;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilePath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilePath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(5, 83);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.Radius = 19;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(259, 36);
            this.txtFilePath.TabIndex = 11;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartService
            // 
            this.btnStartService.CheckedState.Parent = this.btnStartService;
            this.btnStartService.CustomImages.Parent = this.btnStartService;
            this.btnStartService.Enabled = false;
            this.btnStartService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStartService.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStartService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartService.ForeColor = System.Drawing.Color.White;
            this.btnStartService.HoveredState.Parent = this.btnStartService;
            this.btnStartService.Location = new System.Drawing.Point(137, 131);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.ShadowDecoration.Parent = this.btnStartService;
            this.btnStartService.Size = new System.Drawing.Size(127, 35);
            this.btnStartService.TabIndex = 12;
            this.btnStartService.Text = "Servisi Başlat";
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnImport
            // 
            this.btnImport.CheckedState.Parent = this.btnImport;
            this.btnImport.CustomImages.Parent = this.btnImport;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.HoveredState.Parent = this.btnImport;
            this.btnImport.Location = new System.Drawing.Point(5, 131);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(127, 35);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "İçeri Aktar";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txtFloodCount);
            this.gunaGroupBox2.Controls.Add(this.txtMessageSenderIntervalMax);
            this.gunaGroupBox2.Controls.Add(this.txtMessageSenderIntervalMin);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(28, 264);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(272, 179);
            this.gunaGroupBox2.TabIndex = 7;
            this.gunaGroupBox2.Text = "[DFlood Trainer] Gönderme Ayarları";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtFloodCount
            // 
            this.txtFloodCount.BackColor = System.Drawing.Color.Transparent;
            this.txtFloodCount.BorderThickness = 0;
            this.txtFloodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloodCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFloodCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFloodCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFloodCount.DisabledState.Parent = this.txtFloodCount;
            this.txtFloodCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtFloodCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtFloodCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFloodCount.FocusedState.Parent = this.txtFloodCount;
            this.txtFloodCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloodCount.ForeColor = System.Drawing.Color.Black;
            this.txtFloodCount.Location = new System.Drawing.Point(197, 138);
            this.txtFloodCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtFloodCount.Name = "txtFloodCount";
            this.txtFloodCount.ShadowDecoration.Parent = this.txtFloodCount;
            this.txtFloodCount.Size = new System.Drawing.Size(59, 32);
            this.txtFloodCount.TabIndex = 9;
            this.txtFloodCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFloodCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtFloodCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtMessageSenderIntervalMax
            // 
            this.txtMessageSenderIntervalMax.BackColor = System.Drawing.Color.Transparent;
            this.txtMessageSenderIntervalMax.BorderThickness = 0;
            this.txtMessageSenderIntervalMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageSenderIntervalMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessageSenderIntervalMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessageSenderIntervalMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessageSenderIntervalMax.DisabledState.Parent = this.txtMessageSenderIntervalMax;
            this.txtMessageSenderIntervalMax.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtMessageSenderIntervalMax.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtMessageSenderIntervalMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMax.FocusedState.Parent = this.txtMessageSenderIntervalMax;
            this.txtMessageSenderIntervalMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageSenderIntervalMax.ForeColor = System.Drawing.Color.Black;
            this.txtMessageSenderIntervalMax.Location = new System.Drawing.Point(196, 92);
            this.txtMessageSenderIntervalMax.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMax.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMax.Name = "txtMessageSenderIntervalMax";
            this.txtMessageSenderIntervalMax.ShadowDecoration.Parent = this.txtMessageSenderIntervalMax;
            this.txtMessageSenderIntervalMax.Size = new System.Drawing.Size(60, 32);
            this.txtMessageSenderIntervalMax.TabIndex = 9;
            this.txtMessageSenderIntervalMax.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMax.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMax.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMax.ValueChanged += new System.EventHandler(this.txtMessageSenderIntervalMax_ValueChanged);
            // 
            // txtMessageSenderIntervalMin
            // 
            this.txtMessageSenderIntervalMin.BackColor = System.Drawing.Color.Transparent;
            this.txtMessageSenderIntervalMin.BorderThickness = 0;
            this.txtMessageSenderIntervalMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageSenderIntervalMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessageSenderIntervalMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessageSenderIntervalMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessageSenderIntervalMin.DisabledState.Parent = this.txtMessageSenderIntervalMin;
            this.txtMessageSenderIntervalMin.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtMessageSenderIntervalMin.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtMessageSenderIntervalMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMin.FocusedState.Parent = this.txtMessageSenderIntervalMin;
            this.txtMessageSenderIntervalMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageSenderIntervalMin.ForeColor = System.Drawing.Color.Black;
            this.txtMessageSenderIntervalMin.Location = new System.Drawing.Point(197, 43);
            this.txtMessageSenderIntervalMin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMin.Name = "txtMessageSenderIntervalMin";
            this.txtMessageSenderIntervalMin.ShadowDecoration.Parent = this.txtMessageSenderIntervalMin;
            this.txtMessageSenderIntervalMin.Size = new System.Drawing.Size(59, 32);
            this.txtMessageSenderIntervalMin.TabIndex = 9;
            this.txtMessageSenderIntervalMin.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessageSenderIntervalMin.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtMessageSenderIntervalMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtMessageSenderIntervalMin.ValueChanged += new System.EventHandler(this.txtMessageSenderIntervalMin_ValueChanged);
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
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Empty;
            this.gunaGroupBox3.Controls.Add(this.topMost);
            this.gunaGroupBox3.Controls.Add(this.unlimitedFlood);
            this.gunaGroupBox3.Controls.Add(this.secureMode);
            this.gunaGroupBox3.Controls.Add(this.label11);
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
            // topMost
            // 
            this.topMost.Location = new System.Drawing.Point(171, 129);
            this.topMost.Name = "topMost";
            this.topMost.Size = new System.Drawing.Size(26, 18);
            this.topMost.TabIndex = 6;
            this.topMost.Text = "siticoneOSToggleSwith1";
            this.topMost.CheckedChanged += new System.EventHandler(this.topMost_CheckedChanged);
            // 
            // unlimitedFlood
            // 
            this.unlimitedFlood.Location = new System.Drawing.Point(171, 97);
            this.unlimitedFlood.Name = "unlimitedFlood";
            this.unlimitedFlood.Size = new System.Drawing.Size(26, 17);
            this.unlimitedFlood.TabIndex = 5;
            this.unlimitedFlood.Text = "siticoneOSToggleSwith1";
            this.unlimitedFlood.CheckedChanged += new System.EventHandler(this.unlimitedFlood_CheckedChanged);
            // 
            // secureMode
            // 
            this.secureMode.Location = new System.Drawing.Point(171, 67);
            this.secureMode.Name = "secureMode";
            this.secureMode.Size = new System.Drawing.Size(26, 17);
            this.secureMode.TabIndex = 4;
            this.secureMode.Text = "siticoneOSToggleSwith1";
            this.secureMode.CheckedChanged += new System.EventHandler(this.secureMode_CheckedChanged);
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
            this.gunaGroupBox4.Controls.Add(this.messageDeleteInterval);
            this.gunaGroupBox4.Controls.Add(this.label13);
            this.gunaGroupBox4.Controls.Add(this.deleteAfter);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox4.Location = new System.Drawing.Point(324, 264);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Size = new System.Drawing.Size(272, 179);
            this.gunaGroupBox4.TabIndex = 7;
            this.gunaGroupBox4.Text = "[DFlood Trainer] Silme Ayarları";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
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
            this.messageDeleteInterval.Location = new System.Drawing.Point(147, 111);
            this.messageDeleteInterval.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.messageDeleteInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.messageDeleteInterval.Name = "messageDeleteInterval";
            this.messageDeleteInterval.ShadowDecoration.Parent = this.messageDeleteInterval;
            this.messageDeleteInterval.Size = new System.Drawing.Size(59, 32);
            this.messageDeleteInterval.TabIndex = 9;
            this.messageDeleteInterval.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageDeleteInterval.UpDownButtonForeColor = System.Drawing.Color.White;
            this.messageDeleteInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.messageDeleteInterval.ValueChanged += new System.EventHandler(this.messageDeleteInterval_ValueChanged);
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
            // messageDeleteTimer
            // 
            this.messageDeleteTimer.Interval = 1000;
            this.messageDeleteTimer.Tick += new System.EventHandler(this.messageDeleteTimer_Tick);
            // 
            // ofdTimer
            // 
            this.ofdTimer.Interval = 1000;
            // 
            // messageRefreshTime
            // 
            this.messageRefreshTime.AnimationSpeed = 0.6F;
            this.messageRefreshTime.BaseColor = System.Drawing.Color.Gainsboro;
            this.messageRefreshTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messageRefreshTime.IdleColor = System.Drawing.Color.Gainsboro;
            this.messageRefreshTime.IdleOffset = 20;
            this.messageRefreshTime.IdleThickness = 15;
            this.messageRefreshTime.Image = global::DFlood.Properties.Resources.dflood;
            this.messageRefreshTime.ImageSize = new System.Drawing.Size(120, 120);
            this.messageRefreshTime.Location = new System.Drawing.Point(653, 296);
            this.messageRefreshTime.Maximum = 1000;
            this.messageRefreshTime.Name = "messageRefreshTime";
            this.messageRefreshTime.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageRefreshTime.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.messageRefreshTime.ProgressOffset = 20;
            this.messageRefreshTime.ProgressThickness = 30;
            this.messageRefreshTime.Size = new System.Drawing.Size(156, 156);
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
            // main
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFlood";
            this.Load += new System.EventHandler(this.main_Load);
            this.formMover.ResumeLayout(false);
            this.formMover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageSenderIntervalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageSenderIntervalMin)).EndInit();
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
        private Guna.UI.WinForms.GunaElipse elipseForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaCircleProgressBar messageRefreshTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrVirusTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox5;
        private System.Windows.Forms.ListBox keywords;
        private System.Windows.Forms.Label label16;
        private Siticone.UI.WinForms.SiticoneCheckBox deleteAfter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer messageDeleteTimer;
        private System.Windows.Forms.Timer ofdTimer;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith secureMode;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith unlimitedFlood;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith topMost;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton btnImport;
        private Guna.UI.WinForms.GunaTextBox txtFilePath;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton btnStartService;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown txtMessageSenderIntervalMin;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown txtMessageSenderIntervalMax;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown txtFloodCount;
        private System.Windows.Forms.PictureBox btnAbout;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown messageDeleteInterval;
        private System.Windows.Forms.Timer timer1;
    }
}