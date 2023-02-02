using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class adminDb : Form
    {
        
        bool bikeCollapse;
        public adminDb()
        {
            InitializeComponent();
         
        }
        private void adminBike_Click(object sender, EventArgs e)
        {
            adminBike_timer.Start();
        }

        private void btn_adminBikes_Click(object sender, EventArgs e)
        {
           if(bikeCollapse)
            {
                bikeContainer.Height += 10;
                if(bikeContainer.Height == bikeContainer.MaximumSize.Height)
                {
                    bikeCollapse = false;
                    adminBike_timer.Stop();
                }
            }
           else
            {
                bikeContainer.Height -= 10;
                if(bikeContainer.Height == bikeContainer.MinimumSize.Height)
                {
                    bikeCollapse = true;
                    adminBike_timer.Stop();
                }
            }
        }

        private void btn_customerPetrolBike_Click(object sender, EventArgs e)
        {
            //admin bike category for petrol bikes
            this.Hide();
            adminCatPetrol adminCat1 = new adminCatPetrol();
            adminCat1.ShowDialog();
            this.Show();
        }

        private void btn_customerElectricBike_Click(object sender, EventArgs e)
        {

        }

        private void btn_adminPayment_Click(object sender, EventArgs e)
        {
            //admin payment
            this.Hide();
            adminPayment adpay = new adminPayment();
            adpay.ShowDialog();
            this.Show();
        }

        private void btn_clientManagement_Click(object sender, EventArgs e)
        {
            // admin Client Management
            this.Hide();
            adminClientManagement adcm = new adminClientManagement();
            adcm.ShowDialog();
            this.Show();
        }

        private void btn_rental_Click(object sender, EventArgs e)
        {
            //admin rental
            this.Hide();
            adminRental adr = new adminRental();
            adr.ShowDialog();
            this.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            logout logO = new logout();
            logO.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
