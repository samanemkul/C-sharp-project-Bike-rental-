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
    public partial class adminCatPetrol : Form
    {
        public adminCatPetrol()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //add bike 
            this.Hide();
            addpetrolbike apb1 = new addpetrolbike();
            apb1.ShowDialog();
            this.Show();
        }
    }
}
