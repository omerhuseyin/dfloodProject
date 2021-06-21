
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
            this.label7 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtFilePath = new Guna.UI.WinForms.GunaTextBox();
            this.btnStartService = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.btnImport = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.keywords = new System.Windows.Forms.ListBox();
            this.gunaGroupBox5 = new Guna.UI.WinForms.GunaGroupBox();
            this.messageDeleteTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataChecker = new System.Windows.Forms.Timer(this.components);
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.gunaGroupBox1.Location = new System.Drawing.Point(57, 82);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(272, 192);
            this.gunaGroupBox1.TabIndex = 6;
            this.gunaGroupBox1.Text = "Servis Başlatıcısı";
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
            // keywords
            // 
            this.keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.keywords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keywords.ForeColor = System.Drawing.Color.White;
            this.keywords.FormattingEnabled = true;
            this.keywords.HorizontalScrollbar = true;
            this.keywords.ItemHeight = 17;
            this.keywords.Location = new System.Drawing.Point(0, 29);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(227, 170);
            this.keywords.TabIndex = 9;
            // 
            // gunaGroupBox5
            // 
            this.gunaGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox5.BorderColor = System.Drawing.Color.Empty;
            this.gunaGroupBox5.Controls.Add(this.keywords);
            this.gunaGroupBox5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGroupBox5.Location = new System.Drawing.Point(375, 82);
            this.gunaGroupBox5.Name = "gunaGroupBox5";
            this.gunaGroupBox5.Size = new System.Drawing.Size(219, 192);
            this.gunaGroupBox5.TabIndex = 0;
            this.gunaGroupBox5.Text = "Kelime Listesi";
            this.gunaGroupBox5.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // messageDeleteTimer
            // 
            this.messageDeleteTimer.Interval = 1000;
            this.messageDeleteTimer.Tick += new System.EventHandler(this.messageDeleteTimer_Tick);
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
            // dataChecker
            // 
            this.dataChecker.Interval = 1000;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(669, 385);
            this.Controls.Add(this.gunaGroupBox5);
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
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
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
    }
}