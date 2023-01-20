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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
        bool sideBarExpand;
        bool bikeCollapse;
        public adminDb()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            adminSidebar_timer.Start();
        }

        private void sidebar_click(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                //if sidebar is expanded minimize
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    adminSidebar_timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    adminSidebar_timer.Stop();
                }
            }
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
    }
}
