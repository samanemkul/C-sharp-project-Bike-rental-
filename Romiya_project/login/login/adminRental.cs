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
    public partial class adminRental : Form
    {
        public adminRental()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add rental
            this.Hide();
            addRental addr = new addRental();
            addr.ShowDialog();
            this.Show();
        }
    }
}
