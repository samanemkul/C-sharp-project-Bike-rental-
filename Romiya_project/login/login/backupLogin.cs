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
    public partial class backupLogin : Form
    {
        public backupLogin()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerDb cDB = new customerDb();
            cDB.ShowDialog();
            this.Show();
            this.Close();
            
        }
    }
}
