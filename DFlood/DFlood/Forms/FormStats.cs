using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFlood.Forms
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            checker.Start();
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            lblTotalFloods.Text = $"{Properties.Settings.Default.TopTimeFloods} Mesaj";
            lblTotalTimes.Text = $"{Properties.Settings.Default.TopTimeSeconds} Saniye";
        }

        private void FormStats_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\dflood.ico");
        }
    }
}