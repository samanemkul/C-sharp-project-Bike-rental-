﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class pBike6 : Form
    {
        public pBike6()
        {
            InitializeComponent();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //for rules and regulations
            this.Hide();
            rulesAndRegulation rAR = new rulesAndRegulation();
            rAR.ShowDialog();
            this.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
