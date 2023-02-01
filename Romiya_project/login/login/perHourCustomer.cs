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
    public partial class perHourCustomer : Form
    {
        public perHourCustomer()
        {
            InitializeComponent();
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //for Hour payment
            this.Hide();
            customerHourPayment cHP = new customerHourPayment();
            cHP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
