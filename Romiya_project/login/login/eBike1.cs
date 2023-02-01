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
    public partial class eBike1 : Form
    {
        public eBike1()
        {
            InitializeComponent();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //rules and regulations
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
