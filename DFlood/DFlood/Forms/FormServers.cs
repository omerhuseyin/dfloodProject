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
    public partial class FormServers : Form
    {
        public FormServers()
        {
            InitializeComponent();
        }

        private void btnMafia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/dkkkDwVAhN");
        }

        private void FormServers_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\dflood.ico");
        }
    }
}