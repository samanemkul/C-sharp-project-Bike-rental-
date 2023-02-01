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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //for per hour payment
            this.Hide();
            perHourCustomer pHC = new perHourCustomer();
            pHC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // for per day payment
            this.Hide();
            perDayCustomer pDC = new perDayCustomer();
            pDC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
