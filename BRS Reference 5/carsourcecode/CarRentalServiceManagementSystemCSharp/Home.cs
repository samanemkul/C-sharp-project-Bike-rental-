using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalServiceManagementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void RentalCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalCar obj = new RentalCar();
            obj.ShowDialog();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.ShowDialog();
        }

        private void NewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car obj = new Car();
            obj.ShowDialog();
        }

        private void CategoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateoryManagement obj = new CarRentalServiceManagementSystemCSharp.CateoryManagement();
            obj.ShowDialog();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCar obj = new CarRentalServiceManagementSystemCSharp.SearchCar();
            obj.ShowDialog();
        }

        private void CustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCustomer obj = new SearchCustomer();
            obj.ShowDialog();
        }

        private void RentalCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RentalCar obj = new RentalCar();
            obj.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 obj = new CarRentalServiceManagementSystemCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
