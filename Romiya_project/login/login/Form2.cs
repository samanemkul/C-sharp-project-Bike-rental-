using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
           (@"Data source=.\SQLEXPRESS;
            Initial catalog=bike_rental;
            Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
           
        }

        //Register
        private void button1_Click(object sender, EventArgs e)
        { 
            if(txtusername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtpassword.Text == txtComPassword.Text)
            {
                conn.Open();
                string register = "Insert into login values('" + txtusername.Text
                    + "','" + txtpassword.Text + "','" + txtComPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(register, conn);
                    MessageBox.Show("Your account has beemn succesfully created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conn.Close();

                txtusername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";
            }
            else
            {
                    MessageBox.Show("Password does not match,Please Re-enter","Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Text = "";
                    txtComPassword.Text = "";
                    txtpassword.Focus();

                    
            }
              
            }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';

            }
        }
    }
}
