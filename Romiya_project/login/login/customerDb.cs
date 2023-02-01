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
    public partial class customerDb : Form
    {
       
        bool bikeCollapse;
        public customerDb()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
//<<<<<<< Updated upstream
//=======
            
//>>>>>>> Stashed changes
        }

        private void menuBike_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Show();
            
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

        private void button4_Click(object sender, EventArgs e)
        {
            //bike_timer.Start();
        }

        private void btn_about_Click_1(object sender, EventArgs e)
        {

        }

        private void customerDb_Load(object sender, EventArgs e)
        {

        }

        private void btn_history_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_history_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_customerBikes_Click(object sender, EventArgs e)
        {
            bike_timer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_customerPetrolBike_Click(object sender, EventArgs e)
        {
            //typespetrolbike
            this.Hide();
            petrolbikeCustomer f2 = new petrolbikeCustomer();
            f2.ShowDialog();
            f2.Show();

        }

        private void btn_customerElectricBike_Click(object sender, EventArgs e)
        {
            //categoryelectricbike
            this.Hide();
            electricbikeCustomer f3 = new electricbikeCustomer();
            f3.ShowDialog();
            f3.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
