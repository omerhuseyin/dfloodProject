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

        private int topTimeFloods, topTimeDeletes;

        private void Get()
        {
            topTimeFloods = Properties.Settings.Default.TopTimeFloods;
            topTimeDeletes = Properties.Settings.Default.TopTimeDeleteFloods;
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Get();
            lblTotalFloods.Text = topTimeFloods.ToString();
            lblTotalDeletes.Text = topTimeDeletes.ToString();
            lblTotalTimes.Text = Properties.Settings.Default.TopTimeSeconds.ToString();
        }
    }
}