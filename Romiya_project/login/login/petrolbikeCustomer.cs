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
    public partial class petrolbikeCustomer : Form
    {
        public petrolbikeCustomer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void bikeName1_Click(object sender, EventArgs e)
        {
            // For Yamaha XTZ150
            
            pBike1 pB1 = new pBike1();
            pB1.ShowDialog();
            this.Show();
        }

        private void bikeName2_Click(object sender, EventArgs e)
        {
            // For Honda XR 150L
            
            pBike2 pB2 = new pBike2();
            pB2.ShowDialog();
            this.Show();
        }

        private void bikeName3_Click(object sender, EventArgs e)
        {
            // For Tracker 250

            pBike3 pB3 = new pBike3();
            pB3.ShowDialog();
            this.Show();
        }

        private void bikeName4_Click(object sender, EventArgs e)
        {
            // For Hero Xpulse

            pBike4 pB4 = new pBike4();
            pB4.ShowDialog();
            this.Show();
        }

        private void bikeName5_Click(object sender, EventArgs e)
        {
            // For Cross X 250SE

            pBike5 pB5 = new pBike5();
            pB5.ShowDialog();
            this.Show();
        }

        private void bikeName6_Click(object sender, EventArgs e)
        {
            // For Royal Enfield Classic 250

            pBike6 pB6 = new pBike6();
            pB6.ShowDialog();
            this.Show();
        }
    }
}
