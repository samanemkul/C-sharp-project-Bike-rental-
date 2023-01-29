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
    public partial class pBike7 : Form
    {
        public pBike7()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //for payment option
            Option Opt = new Option();
            Opt.ShowDialog();
            this.Show();
        }
    }
}
