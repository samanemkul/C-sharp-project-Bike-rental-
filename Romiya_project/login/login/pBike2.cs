using System;
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
    public partial class pBike2 : Form
    {
        public pBike2()
        {
            InitializeComponent();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // for rules and regulation
            this.Hide();
            rulesAndRegulation rAR = new rulesAndRegulation();
            rAR.ShowDialog();
            this.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
