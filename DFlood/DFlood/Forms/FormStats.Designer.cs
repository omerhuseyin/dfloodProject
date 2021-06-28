
namespace DFlood.Forms
{
    partial class FormStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
            this.bunifuGradientPanel3 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblTotalFloods = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderRadius = 35;
            this.bunifuGradientPanel3.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel3.Controls.Add(this.lblTotalTimes);
            this.bunifuGradientPanel3.Controls.Add(this.label5);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(348, 96);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(150, 120);
            this.bunifuGradientPanel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DFlood.Properties.Resources.time;
            this.pictureBox3.Location = new System.Drawing.Point(112, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalTimes
            // 
            this.lblTotalTimes.AutoSize = true;
            this.lblTotalTimes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTimes.Location = new System.Drawing.Point(27, 50);
            this.lblTotalTimes.Name = "lblTotalTimes";
            this.lblTotalTimes.Size = new System.Drawing.Size(51, 22);
            this.lblTotalTimes.TabIndex = 2;
            this.lblTotalTimes.Text = "NaN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Çalışma Süresi";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 35;
            this.bunifuGradientPanel1.Controls.Add(this.lblTotalFloods);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gold;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(138, 96);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(150, 120);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lblTotalFloods
            // 
            this.lblTotalFloods.AutoSize = true;
            this.lblTotalFloods.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalFloods.Location = new System.Drawing.Point(25, 50);
            this.lblTotalFloods.Name = "lblTotalFloods";
            this.lblTotalFloods.Size = new System.Drawing.Size(51, 22);
            this.lblTotalFloods.TabIndex = 2;
            this.lblTotalFloods.Text = "NaN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Flood";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DFlood.Properties.Resources.sendmessages;
            this.pictureBox1.Location = new System.Drawing.Point(107, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checker
            // 
            this.checker.Interval = 1000;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStats";
            this.Text = "DFlood İstatistikleri";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.MouseEnter += new System.EventHandler(this.FormStats_MouseEnter);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotalTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalFloods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer checker;
    }
}