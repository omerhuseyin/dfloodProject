
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFloodMode = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnOk = new Siticone.UI.WinForms.SiticoneImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilePath = new Guna.UI.WinForms.GunaTextBox();
            this.keywords = new System.Windows.Forms.ListBox();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.messageDeleteTimer = new System.Windows.Forms.Timer(this.components);
            this.dataChecker = new System.Windows.Forms.Timer(this.components);
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnModeChanger = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnImport = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.btnStartService = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 1000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // lblFloodMode
            // 
            this.lblFloodMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFloodMode.Location = new System.Drawing.Point(170, 46);
            this.lblFloodMode.Name = "lblFloodMode";
            this.lblFloodMode.Size = new System.Drawing.Size(275, 34);
            this.lblFloodMode.TabIndex = 0;
            this.lblFloodMode.Text = "DFlood Rank Modu\r\nMetin Dosyasının İçeri Aktarılması Bekleniyor...";
            this.lblFloodMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnOk);
            this.gunaGroupBox1.Controls.Add(this.pictureBox3);
            this.gunaGroupBox1.Controls.Add(this.pictureBox1);
            this.gunaGroupBox1.Controls.Add(this.txtFilePath);
            this.gunaGroupBox1.Controls.Add(this.lblFloodMode);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(34, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(600, 149);
            this.gunaGroupBox1.TabIndex = 6;
            this.gunaGroupBox1.Text = "Veri Girişi";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(285, 7);
            // 
            // btnOk
            // 
            this.btnOk.CheckedState.Parent = this.btnOk;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.HoveredState.Parent = this.btnOk;
            this.btnOk.Image = global::DFlood.Properties.Resources.success_50px;
            this.btnOk.Location = new System.Drawing.Point(447, 97);
            this.btnOk.Name = "btnOk";
            this.btnOk.PressedState.Parent = this.btnOk;
            this.btnOk.Size = new System.Drawing.Size(36, 25);
            this.btnOk.TabIndex = 14;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DFlood.Properties.Resources.input;
            this.pictureBox3.Location = new System.Drawing.Point(257, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DFlood.Properties.Resources.txt;
            this.pictureBox1.Location = new System.Drawing.Point(149, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.Transparent;
            this.txtFilePath.BaseColor = System.Drawing.Color.White;
            this.txtFilePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilePath.BorderSize = 0;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilePath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilePath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(186, 92);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.Radius = 19;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(259, 36);
            this.txtFilePath.TabIndex = 11;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // keywords
            // 
            this.keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.keywords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keywords.ForeColor = System.Drawing.Color.White;
            this.keywords.FormattingEnabled = true;
            this.keywords.HorizontalScrollbar = true;
            this.keywords.ItemHeight = 17;
            this.keywords.Items.AddRange(new object[] {
            "Veri Bulunamadı"});
            this.keywords.Location = new System.Drawing.Point(0, 29);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(220, 153);
            this.keywords.TabIndex = 9;
            // 
            // gunaGroupBox5
            // 
            this.gunaGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BorderColor = System.Drawing.Color.Empty;
            this.gunaGroupBox5.Controls.Add(this.pictureBox5);
            this.gunaGroupBox5.Controls.Add(this.keywords);
            this.gunaGroupBox5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox5.Location = new System.Drawing.Point(415, 190);
            this.gunaGroupBox5.Name = "gunaGroupBox5";
            this.gunaGroupBox5.Radius = 10;
            this.gunaGroupBox5.Size = new System.Drawing.Size(219, 183);
            this.gunaGroupBox5.TabIndex = 0;
            this.gunaGroupBox5.Text = "Kelime Listesi";
            this.gunaGroupBox5.TextLocation = new System.Drawing.Point(80, 7);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DFlood.Properties.Resources.list;
            this.pictureBox5.Location = new System.Drawing.Point(56, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // messageDeleteTimer
            // 
            this.messageDeleteTimer.Interval = 1000;
            // 
            // dataChecker
            // 
            this.dataChecker.Interval = 1000;
            this.dataChecker.Tick += new System.EventHandler(this.dataChecker_Tick);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnModeChanger);
            this.gunaGroupBox2.Controls.Add(this.pictureBox4);
            this.gunaGroupBox2.Controls.Add(this.btnImport);
            this.gunaGroupBox2.Controls.Add(this.btnStartService);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(34, 190);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 10;
            this.gunaGroupBox2.Size = new System.Drawing.Size(361, 183);
            this.gunaGroupBox2.TabIndex = 6;
            this.gunaGroupBox2.Text = "Fonksiyonlar";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(150, 7);
            // 
            // btnModeChanger
            // 
            this.btnModeChanger.CheckedState.Parent = this.btnModeChanger;
            this.btnModeChanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeChanger.CustomImages.Parent = this.btnModeChanger;
            this.btnModeChanger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModeChanger.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModeChanger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModeChanger.ForeColor = System.Drawing.Color.White;
            this.btnModeChanger.HoveredState.Parent = this.btnModeChanger;
            this.btnModeChanger.Image = global::DFlood.Properties.Resources.rank;
            this.btnModeChanger.Location = new System.Drawing.Point(45, 108);
            this.btnModeChanger.Name = "btnModeChanger";
            this.btnModeChanger.ShadowDecoration.Parent = this.btnModeChanger;
            this.btnModeChanger.Size = new System.Drawing.Size(251, 35);
            this.btnModeChanger.TabIndex = 14;
            this.btnModeChanger.Text = "Rank Modu";
            this.btnModeChanger.Click += new System.EventHandler(this.btnModeChanger_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DFlood.Properties.Resources.button;
            this.pictureBox4.Location = new System.Drawing.Point(121, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.CheckedState.Parent = this.btnImport;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.CustomImages.Parent = this.btnImport;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.HoveredState.Parent = this.btnImport;
            this.btnImport.Image = global::DFlood.Properties.Resources.import;
            this.btnImport.Location = new System.Drawing.Point(45, 56);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(111, 35);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "İçeri Aktar";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.CheckedState.Parent = this.btnStartService;
            this.btnStartService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartService.CustomImages.Parent = this.btnStartService;
            this.btnStartService.Enabled = false;
            this.btnStartService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStartService.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStartService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartService.ForeColor = System.Drawing.Color.White;
            this.btnStartService.HoveredState.Parent = this.btnStartService;
            this.btnStartService.Image = global::DFlood.Properties.Resources.play;
            this.btnStartService.Location = new System.Drawing.Point(185, 56);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.ShadowDecoration.Parent = this.btnStartService;
            this.btnStartService.Size = new System.Drawing.Size(111, 35);
            this.btnStartService.TabIndex = 12;
            this.btnStartService.Text = "Başlat";
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(669, 385);
            this.Controls.Add(this.gunaGroupBox5);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Başlatıcısı";
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseEnter += new System.EventHandler(this.main_MouseEnter);
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFloodMode;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox5;
        private System.Windows.Forms.ListBox keywords;
        private System.Windows.Forms.Timer messageDeleteTimer;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton btnImport;
        private Guna.UI.WinForms.GunaTextBox txtFilePath;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton btnStartService;
        private System.Windows.Forms.Timer dataChecker;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton btnModeChanger;
        private Siticone.UI.WinForms.SiticoneImageButton btnOk;
    }
}