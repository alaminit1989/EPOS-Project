﻿using EPOS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnShutdown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (Forms.Home fd = new Forms.Home())
            {
                fd.ShowDialog();
            }
        }
    }
}
