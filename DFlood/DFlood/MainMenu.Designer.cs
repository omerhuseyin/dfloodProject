﻿
namespace DFlood
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnContact = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyright = new FontAwesome.Sharp.IconButton();
            this.btnSponsoredServers = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnServiceStarter = new FontAwesome.Sharp.IconButton();
            this.btnStats = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnVirusTotal = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.dfloodIcon = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.TopMostChecker = new System.Windows.Forms.Timer(this.components);
            this.totalTimeCalculator = new System.Windows.Forms.Timer(this.components);
            this.fadeOpacity = new System.Windows.Forms.Timer(this.components);
            this.fadeOpacity2 = new System.Windows.Forms.Timer(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVirusTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfloodIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnCopyright);
            this.panelMenu.Controls.Add(this.btnSponsoredServers);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnServiceStarter);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 460);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.IconChar = FontAwesome.Sharp.IconChar.At;
            this.btnContact.IconColor = System.Drawing.Color.White;
            this.btnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContact.IconSize = 32;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 350);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnContact.Size = new System.Drawing.Size(178, 50);
            this.btnContact.TabIndex = 8;
            this.btnContact.Text = "Bize Ulaşın";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            this.btnContact.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "© DFlood 2021";
            // 
            // btnCopyright
            // 
            this.btnCopyright.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyright.FlatAppearance.BorderSize = 0;
            this.btnCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyright.ForeColor = System.Drawing.Color.White;
            this.btnCopyright.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.btnCopyright.IconColor = System.Drawing.Color.White;
            this.btnCopyright.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopyright.IconSize = 32;
            this.btnCopyright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyright.Location = new System.Drawing.Point(0, 300);
            this.btnCopyright.Name = "btnCopyright";
            this.btnCopyright.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCopyright.Size = new System.Drawing.Size(178, 50);
            this.btnCopyright.TabIndex = 6;
            this.btnCopyright.Text = "Yasal Uyarı";
            this.btnCopyright.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyright.UseVisualStyleBackColor = true;
            this.btnCopyright.Click += new System.EventHandler(this.btnCopyright_Click);
            this.btnCopyright.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // btnSponsoredServers
            // 
            this.btnSponsoredServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSponsoredServers.FlatAppearance.BorderSize = 0;
            this.btnSponsoredServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSponsoredServers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSponsoredServers.ForeColor = System.Drawing.Color.White;
            this.btnSponsoredServers.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.btnSponsoredServers.IconColor = System.Drawing.Color.White;
            this.btnSponsoredServers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSponsoredServers.IconSize = 32;
            this.btnSponsoredServers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSponsoredServers.Location = new System.Drawing.Point(0, 250);
            this.btnSponsoredServers.Name = "btnSponsoredServers";
            this.btnSponsoredServers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSponsoredServers.Size = new System.Drawing.Size(178, 50);
            this.btnSponsoredServers.TabIndex = 5;
            this.btnSponsoredServers.Text = "Sponsorlar";
            this.btnSponsoredServers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSponsoredServers.UseVisualStyleBackColor = true;
            this.btnSponsoredServers.Click += new System.EventHandler(this.btnSponsoredServers_Click);
            this.btnSponsoredServers.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 200);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(178, 50);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // btnServiceStarter
            // 
            this.btnServiceStarter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceStarter.FlatAppearance.BorderSize = 0;
            this.btnServiceStarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStarter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServiceStarter.ForeColor = System.Drawing.Color.White;
            this.btnServiceStarter.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnServiceStarter.IconColor = System.Drawing.Color.White;
            this.btnServiceStarter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServiceStarter.IconSize = 32;
            this.btnServiceStarter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceStarter.Location = new System.Drawing.Point(0, 150);
            this.btnServiceStarter.Name = "btnServiceStarter";
            this.btnServiceStarter.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnServiceStarter.Size = new System.Drawing.Size(178, 50);
            this.btnServiceStarter.TabIndex = 3;
            this.btnServiceStarter.Text = "Servis Başlatıcısı";
            this.btnServiceStarter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServiceStarter.UseVisualStyleBackColor = true;
            this.btnServiceStarter.Click += new System.EventHandler(this.btnServiceStarter_Click);
            this.btnServiceStarter.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnStats.IconColor = System.Drawing.Color.White;
            this.btnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStats.IconSize = 32;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(0, 100);
            this.btnStats.Name = "btnStats";
            this.btnStats.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStats.Size = new System.Drawing.Size(178, 50);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "İstatistikler";
            this.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            this.btnStats.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(178, 100);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::DFlood.Properties.Resources.dflood2;
            this.btnHome.Location = new System.Drawing.Point(51, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(73, 75);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelTitleBar.Controls.Add(this.btnVirusTotal);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(178, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(669, 66);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            // 
            // btnVirusTotal
            // 
            this.btnVirusTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVirusTotal.Image = global::DFlood.Properties.Resources.green_circle;
            this.btnVirusTotal.Location = new System.Drawing.Point(640, 5);
            this.btnVirusTotal.Name = "btnVirusTotal";
            this.btnVirusTotal.Size = new System.Drawing.Size(17, 17);
            this.btnVirusTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVirusTotal.TabIndex = 2;
            this.btnVirusTotal.TabStop = false;
            this.btnVirusTotal.Click += new System.EventHandler(this.btnVirusTotal_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::DFlood.Properties.Resources.yellow_circle;
            this.btnMinimize.Location = new System.Drawing.Point(622, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 17);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(57, 24);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(68, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Ana Sayfa";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(122)))), ((int)(((byte)(225)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(122)))), ((int)(((byte)(225)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 33;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 18);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(35, 33);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::DFlood.Properties.Resources.red_circle;
            this.btnExit.Location = new System.Drawing.Point(604, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(17, 17);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(178, 66);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(669, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelDesktop.Controls.Add(this.lblTime);
            this.panelDesktop.Controls.Add(this.dfloodIcon);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(178, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(669, 385);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(136)))), ((int)(((byte)(34)))));
            this.lblTime.Location = new System.Drawing.Point(304, 125);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(105, 22);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "undefined";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dfloodIcon
            // 
            this.dfloodIcon.Image = global::DFlood.Properties.Resources.dflood2;
            this.dfloodIcon.Location = new System.Drawing.Point(91, 106);
            this.dfloodIcon.Name = "dfloodIcon";
            this.dfloodIcon.Size = new System.Drawing.Size(124, 123);
            this.dfloodIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dfloodIcon.TabIndex = 0;
            this.dfloodIcon.TabStop = false;
            this.dfloodIcon.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 10;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // TopMostChecker
            // 
            this.TopMostChecker.Tick += new System.EventHandler(this.TopMostChecker_Tick);
            // 
            // totalTimeCalculator
            // 
            this.totalTimeCalculator.Interval = 1000;
            this.totalTimeCalculator.Tick += new System.EventHandler(this.totalTimeCalculator_Tick);
            // 
            // fadeOpacity2
            // 
            this.fadeOpacity2.Interval = 40;
            this.fadeOpacity2.Tick += new System.EventHandler(this.fadeOpacity2_Tick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(847, 460);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVirusTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfloodIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSponsoredServers;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnServiceStarter;
        private FontAwesome.Sharp.IconButton btnStats;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCopyright;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnVirusTotal;
        private System.Windows.Forms.PictureBox dfloodIcon;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TopMostChecker;
        private FontAwesome.Sharp.IconButton btnContact;
        private System.Windows.Forms.Timer totalTimeCalculator;
        private System.Windows.Forms.Timer fadeOpacity;
        private System.Windows.Forms.Timer fadeOpacity2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}