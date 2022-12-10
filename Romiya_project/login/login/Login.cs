<<<<<<< HEAD
using Microsoft.Win32;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection
           (@"Data source=.\SQLEXPRESS;
            Initial catalog=bike_rental;
            Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM login WHERE username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, conn);
            cmd.ExecuteNonQuery();
            var dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password ,Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtusername.Text = "";
                txtpassword.Text = "";
            }

            conn.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f2 = new RegisterForm();
            f2.ShowDialog();
            this.Show();

        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;   
        }
    }
=======
using Microsoft.Win32;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection
           (@"Data source=.\SQLEXPRESS;
            Initial catalog=bike_rental;
            user id=sa;password=kist@123;");
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM login WHERE username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, conn);
            cmd.ExecuteNonQuery();
            var dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password ,Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtusername.Text = "";
                txtpassword.Text = "";
            }

            conn.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();

        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;   
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
>>>>>>> 59ac68c15793a70ec9be79f402a5327d6a303b5c
}