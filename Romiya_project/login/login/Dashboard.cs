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
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
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
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void sidebar_click(object sender, EventArgs e)
        {
            //SET the minimum and maximum size of the sidebar

            if(sideBarExpand)
            {
                //if sidebar is expanded, minimize
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sidebar_timer.Stop();    
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sidebar_timer.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
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
            bike_timer.Start();
        }

        private void btn_about_Click_1(object sender, EventArgs e)
        {

        }
    }
}
