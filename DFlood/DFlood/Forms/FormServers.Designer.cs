
namespace DFlood.Forms
{
    partial class FormServers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServers));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMafia = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMafia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAFIA™ Community";
            // 
            // btnMafia
            // 
            this.btnMafia.BaseColor = System.Drawing.Color.White;
            this.btnMafia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMafia.Image = ((System.Drawing.Image)(resources.GetObject("btnMafia.Image")));
            this.btnMafia.Location = new System.Drawing.Point(295, 110);
            this.btnMafia.Name = "btnMafia";
            this.btnMafia.Size = new System.Drawing.Size(79, 78);
            this.btnMafia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMafia.TabIndex = 0;
            this.btnMafia.TabStop = false;
            this.btnMafia.UseTransfarantBackground = false;
            this.btnMafia.Click += new System.EventHandler(this.btnMafia_Click);
            // 
            // FormServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMafia);
            this.Name = "FormServers";
            this.Text = "FormServers";
            ((System.ComponentModel.ISupportInitialize)(this.btnMafia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox btnMafia;
        private System.Windows.Forms.Label label1;
    }
}