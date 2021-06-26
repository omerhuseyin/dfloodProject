using DFlood.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFlood
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info,
            SecurePoint,
            cwncy
        }

        private Form_Alert.enmAction action;

        private int x, y;

        public void showAlert(string msg, string dsc, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox2.Image = Resources.success_50px;
                    this.BackColor = Color.SeaGreen;
                    break;

                case enmType.Error:
                    this.pictureBox2.Image = Resources.error_50px;
                    this.BackColor = Color.DarkRed;
                    break;

                case enmType.Info:
                    this.pictureBox2.Image = Resources.important_50px;
                    this.BackColor = Color.RoyalBlue;
                    break;

                case enmType.Warning:
                    this.pictureBox2.Image = Resources.clouderror_50px;
                    this.BackColor = Color.DarkOrange;
                    break;

                case enmType.SecurePoint:
                    this.pictureBox2.Image = Resources.securitypoint_50px;
                    this.BackColor = Color.Aqua;
                    break;

                case enmType.cwncy:
                    this.pictureBox2.Image = Resources.money;
                    this.BackColor = Color.Green;
                    break;
            }

            this.lblMsg.Text = msg;
            this.lblDescription.Text = dsc;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;

                case Form_Alert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {
        }
    }
}