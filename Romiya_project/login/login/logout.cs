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
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            thankyou thanks = new thankyou();
            thanks.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDb adD = new adminDb();
            adD.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
