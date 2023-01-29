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
    public partial class electricbikeCustomer : Form
    {
        public electricbikeCustomer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void eBike5_Click(object sender, EventArgs e)
        {
            // For Doohan Scooter

            eBike5 eB5 = new eBike5();
            eB5.ShowDialog();
            this.Show();
        }

        private void e1_Click(object sender, EventArgs e)
        {
            // For Yatri P1

            eBike1 eB1 = new eBike1();
            eB1.ShowDialog();
            this.Show();
        }

        private void e2_Click(object sender, EventArgs e)
        {
            // For Super Soco

            eBike2 eB2 = new eBike2();
            eB2.ShowDialog();
            this.Show();
        }

        private void e3_Click(object sender, EventArgs e)
        {
            // For NIU Scooter

            eBike3 eB3 = new eBike3();
            eB3.ShowDialog();
            this.Show();
        }

        private void e4_Click(object sender, EventArgs e)
        {
            // For Bella Scooter

            eBike4 eB4 = new eBike4();
            eB4.ShowDialog();
            this.Show();
        }
    }
}
