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
    public partial class adminClientManagement : Form
    {
        public adminClientManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add client
            this.Hide();
            addClient addc = new addClient();
            addc.ShowDialog();
            this.Show();
        }
    }
}
