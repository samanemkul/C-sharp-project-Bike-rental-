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
    public partial class mainLogin : Form
    {
        public mainLogin()
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
            adminDb adD = new adminDb();
            adD.ShowDialog();
            this.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            backupLogin bckLogin = new backupLogin();
            bckLogin.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
