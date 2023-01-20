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
    public partial class adminCatElectric : Form
    {
        public adminCatElectric()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add electric data
            this.Hide();
            addelectricbike aeb = new addelectricbike();
            aeb.ShowDialog();
            this.Show();
        }
    }
}
