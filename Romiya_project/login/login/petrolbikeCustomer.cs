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
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void bikeName1_Click(object sender, EventArgs e)
        {
            // For Yamaha XTZ150
            myGlobal.BikeType = "";
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

        private void bikeName7_Click(object sender, EventArgs e)
        {
            // For Jawa Classic 300

            pBike7 pB7 = new pBike7();
            pB7.ShowDialog();
            this.Show();
        }

        private void bikeName8_Click(object sender, EventArgs e)
        {
            // For Pulsar NS 200

            pBike8 pB8 = new pBike8();
            pB8.ShowDialog();
            this.Show();
        }

        private void bikeName9_Click(object sender, EventArgs e)
        {
            // For MT - 15 

            pBike9 pB9 = new pBike9();
            pB9.ShowDialog();
            pB9.Show();
        }

        private void bikeName10_Click(object sender, EventArgs e)
        {
            // For Apache RTR 200

            pBike10 pB10 = new pBike10();
            pB10.ShowDialog();
            this.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
