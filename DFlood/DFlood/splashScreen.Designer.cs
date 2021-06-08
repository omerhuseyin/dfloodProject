
namespace DFlood
{
    partial class splashScreen
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.splashBar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // splashBar
            // 
            this.splashBar.AnimationSpeed = 0.6F;
            this.splashBar.BaseColor = System.Drawing.Color.White;
            this.splashBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.splashBar.IdleOffset = 20;
            this.splashBar.IdleThickness = 15;
            this.splashBar.Image = global::DFlood.Properties.Resources.discord_will_provide_official_verification_esports_team_4;
            this.splashBar.ImageSize = new System.Drawing.Size(120, 120);
            this.splashBar.Location = new System.Drawing.Point(155, 37);
            this.splashBar.Maximum = 1000;
            this.splashBar.Name = "splashBar";
            this.splashBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.splashBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.splashBar.ProgressOffset = 20;
            this.splashBar.ProgressThickness = 10;
            this.splashBar.Size = new System.Drawing.Size(151, 150);
            this.splashBar.TabIndex = 5;
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 10;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(464, 229);
            this.Controls.Add(this.splashBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwO Bot External Trainer";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleProgressBar splashBar;
        private System.Windows.Forms.Timer splashTimer;
    }
}