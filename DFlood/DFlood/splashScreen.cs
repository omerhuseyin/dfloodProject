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

namespace DFlood
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
            splashTimer.Start();
        }
        cheat cht = new cheat();
        System.Media.SoundPlayer snd = new SoundPlayer();
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashBar.Value += 10;
            if (splashBar.Value == 800)
            {
                snd.SoundLocation = "openSound.wav";
                snd.Play();

            }
            if (splashBar.Value == 1000)
            {
                this.Hide();
                cht.Show();
            }
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
