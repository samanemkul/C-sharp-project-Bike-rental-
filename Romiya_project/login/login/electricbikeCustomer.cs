using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class electricbikeCustomer : Form
    {
        bool bikeCollapse;
        public electricbikeCustomer()
        {
            InitializeComponent();
            
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bike_timer_Tick(object sender, EventArgs e)
        {
            if(bikeCollapse)
            {
                bikeContainer.Height += 10;
                if(bikeContainer.Height == bikeContainer.MaximumSize.Height)
                {
                    bikeCollapse = false;
                    bike_timer.Stop();
                }
            }
            else
            {
                bikeContainer.Height -= 10;
                if(bikeContainer.Height == bikeContainer.MinimumSize.Height)
                {
                    bikeCollapse = true;
                    bike_timer.Stop();
                }
            }
        }

        private void btn_customerBikes_Click(object sender, EventArgs e)
        {
            bike_timer.Start();
        }

        private void btn_customerElectricBike_Click(object sender, EventArgs e)
        {
            this.Hide();
            electricbikeCustomer eBC = new electricbikeCustomer();
            eBC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btn_customerPetrolBike_Click(object sender, EventArgs e)
        {
            this.Hide();
            petrolbikeCustomer pBC = new petrolbikeCustomer();
            pBC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btn_customerDb_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerDb cDB = new customerDb();
            cDB.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
