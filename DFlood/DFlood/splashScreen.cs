using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace DFlood
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
            splashTimer.Start();
        }

        private main cht = new main();
        private System.Media.SoundPlayer snd = new SoundPlayer();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(int hWnd);

        private void FormMoveEvent(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        private void splashTimer_Tick_1(object sender, EventArgs e)
        {
            splashProgressBar.Value += 10;
            if (splashProgressBar.Value == 1300)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();
            }
            if (splashProgressBar.Value == 1500)
            {
                splashTimer.Stop();
                this.Hide();
                cht.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}