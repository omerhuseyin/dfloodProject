﻿using System;
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
    public partial class FormCopyright : Form
    {
        public FormCopyright()
        {
            InitializeComponent();
        }


        private void FormCopyright_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\Cursors\\dflood.ico");
        }
    }
}