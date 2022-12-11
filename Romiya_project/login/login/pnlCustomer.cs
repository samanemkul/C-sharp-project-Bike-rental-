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
    public partial class pnlCustomer : UserControl
    {
        public pnlCustomer()
        {
            InitializeComponent();
        }
        bool sidebarExpand;
        bool bikeCollapse;
        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void sidebartimer_tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width ==  sidebar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_timer.Stop();
                }
            }
        }

        private void biketimer_click(object sender, EventArgs e)
        {
            if(bikeCollapse)
            {
                bikeContainer.Height += 10;
                if(bikeContainer.Height == bikeContainer.MinimumSize.Height)
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
    }
}
