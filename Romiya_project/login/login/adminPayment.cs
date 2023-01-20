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
    public partial class adminPayment : Form
    {
        public adminPayment()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add payment
            this.Hide();
            addPayment addPay = new addPayment();
            addPay.ShowDialog();
            addPay.Show();
        }
    }
}
