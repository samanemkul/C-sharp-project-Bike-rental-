////<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
           (@"Data source=.\SQLEXPRESS;
            Initial catalog=bike_rental;
            Integrated Security=True;");

        private void label7_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
           
        }

        //Register
        //private void button1_Click(object sender, EventArgs e)
        //{ 
        //    if(txtusername.Text == "" && txtfirstname.Text == "" && txtpassword.Text == "")
        //    {
        //        MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if(txtfirstname.Text == txtpPassword.Text)
        //    {
        //        conn.Open();
        //        string register = "Insert into login values('" + txtusername.Text
        //            + "','" + txtfirstname.Text + "','" + txtComPassword.Text + "')";
        //            SqlCommand cmd = new SqlCommand(register, conn);
        //            MessageBox.Show("Your account has beemn succesfully created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //            conn.Close();

        //        txtusername.Text = "";
        //        txtfirstname.Text = "";
        //        txtComPassword.Text = "";
        //    }
        //    else
        //    {
        //            MessageBox.Show("Password does not match,Please Re-enter","Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtfirstname.Text = "";
        //            txtComPassword.Text = "";
        //            txtfirstname.Focus();


        //    }

        //}

        //private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(CheckbxShowPas.Checked)
        //    {
        //        txtfirstname.UseSystemPasswordChar = true;
        //        txtComPassword.UseSystemPasswordChar = true;
        //    }
        //    else
        //    {
        //        txtfirstname.UseSystemPasswordChar = false;
        //        txtComPassword.UseSystemPasswordChar = false;

        //    }
        //}
        ////form
        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    txtfirstname.UseSystemPasswordChar=false;
        //    txtPassword.UseSystemPasswordChar=true;  
        //}
        //protected void button2_Paint(object sender, PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
        //    GraphicsPath GraphPath = new GraphicsPath();
        //    GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
        //    GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
        //    GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
        //    GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
        //    this.Region = new Region(GraphPath);
        //}
        private void txtfirstname_Enter(object sender, EventArgs e)
        {
            string fname = txtfirstname.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                txtfirstname.Text = "";
                txtfirstname.ForeColor = Color.Black;
            }
        }
        private void txtfirstname_Leave_1(object sender, EventArgs e)
        {
            string fname = txtfirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                txtfirstname.Text = "first name";
                txtfirstname.ForeColor = Color.Gray;
            }

        }

        private void txtmiddlename_Enter(object sender, EventArgs e)
        {
            string mname = txtmiddlename.Text;
            if (mname.ToLower().Trim().Equals("middle name"))
            {
                txtmiddlename.Text = "";
                txtmiddlename.ForeColor = Color.Black;
            }
        }

        private void txtmiddlename_Leave(object sender, EventArgs e)
        {
            string mname = txtmiddlename.Text;
            if (mname.ToLower().Trim().Equals("middle name") || mname.Trim().Equals(""))
            {
                txtmiddlename.Text = "middle name";
                txtmiddlename.ForeColor = Color.Gray;
            }
        }

        private void txtlastname_Enter(object sender, EventArgs e)
        {
            string lname = txtlastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                txtlastname.Text = "";
                txtlastname.ForeColor = Color.Black;
            }
        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {
            string lname = txtlastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                txtlastname.Text = "last name";
                txtlastname.ForeColor = Color.Gray;
            }
        }

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            string add = txtaddress.Text;
            if (add.ToLower().Trim().Equals("complete address"))
            {
                txtaddress.Text = "";
                txtaddress.ForeColor = Color.Black;
            }
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            string add = txtaddress.Text;
            if (add.ToLower().Trim().Equals("complete address") || add.Trim().Equals(""))
            {
                txtaddress.Text = "complete address";
                txtaddress.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            string mail = txtemail.Text;
            if (mail.ToLower().Trim().Equals("email address"))
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string mail = txtemail.Text;
            if (mail.ToLower().Trim().Equals("email address") || mail.Trim().Equals(""))
            {
                txtemail.Text = "email address";
                txtemail.ForeColor = Color.Gray;
            }
        }

        private void txtnumber_Enter(object sender, EventArgs e)
        {
            string num = txtnumber.Text;
            if (num.ToLower().Trim().Equals("contact number"))
            {
                txtnumber.Text = "";
                txtnumber.ForeColor = Color.Black;
            }
        }

        private void txtnumber_Leave(object sender, EventArgs e)
        {
            string num = txtaddress.Text;
            if (num.ToLower().Trim().Equals("contact number") || num.Trim().Equals(""))
            {
                txtnumber.Text = "contact number";
                txtnumber.ForeColor = Color.Gray;
            }
        }

        private void txtxstatus_Enter(object sender, EventArgs e)
        {
            string st = txtxstatus.Text;
            if (st.ToLower().Trim().Equals("civil status"))
            {
                txtxstatus.Text = "";
                txtxstatus.ForeColor = Color.Black;
            }
        }

        private void txtxstatus_Leave(object sender, EventArgs e)
        {
            string st = txtxstatus.Text;
            if (st.ToLower().Trim().Equals("civil status") || st.Trim().Equals(""))
            {
                txtxstatus.Text = "civil status";
                txtxstatus.ForeColor = Color.Gray;
            }
        }

        private void txtgender_Enter(object sender, EventArgs e)
        {
            string gen = txtgender.Text;
            if (gen.ToLower().Trim().Equals("gender"))
            {
                txtgender.Text = "";
                txtgender.ForeColor = Color.Black;
            }
        }

        private void txtgender_Leave(object sender, EventArgs e)
        {
            string gen = txtgender.Text;
            if (gen.ToLower().Trim().Equals("gender") || gen.Trim().Equals(""))
            {
                txtgender.Text = "gender";
                txtgender.ForeColor = Color.Gray;
            }
        }

        private void age_Enter(object sender, EventArgs e)
        {
            string ag = age.Text;
            if (ag.ToLower().Trim().Equals("age"))
            {
                age.Text = "";
                age.ForeColor = Color.Black;
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            string ag = age.Text;
            if (ag.ToLower().Trim().Equals("age") || ag.Trim().Equals(""))
            {
                age.Text = "age";
                age.ForeColor = Color.Gray;
            }
        }
        private void txtusername_Enter(object sender, EventArgs e)
        {
            string st = txtusername.Text;
            if (st.ToLower().Trim().Equals("username"))
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.Black;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            string st = txtusername.Text;
            if (st.ToLower().Trim().Equals("username") || st.Trim().Equals(""))
            {
                txtusername.Text = "username";
                txtusername.ForeColor = Color.Gray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            string st = txtpassword.Text;
            if (st.ToLower().Trim().Equals("password"))
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            string st = txtpassword.Text;
            if (st.ToLower().Trim().Equals("password") || st.Trim().Equals(""))
            {
                txtpassword.Text = "password";
                txtpassword.ForeColor = Color.Gray;
            }
        }
        //Register
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into register" + "(firstname,middlename,lastname,address,emailaddress,contactnumber,status,gender,age,DOB,username,password)" + "values('"+txtfirstname.Text + "','"+txtmiddlename.Text +"','"+txtaddress.Text + "','"+txtemail.Text +"','"+txtnumber.Text + "','"+ txtxstatus.Text + "','"+txtgender.Text +"',,'"+age.Text + "','"+dateTimePicker1.Text + "','"+txtusername.Text +"',,'"+txtpassword.Text + "')";
            SqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Your account has been succesfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
//=======
//﻿using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace login
//{
//    public partial class Form2 : Form
//    {
//        public Form2()
//        {
//            InitializeComponent();
//        }
//        SqlConnection conn = new SqlConnection
//           (@"Data source=.\SQLEXPRESS;
//            Initial catalog=bike_rental;
//            user id=sa;password=kist@123;");

//        private void label7_Click(object sender, EventArgs e)
//        {
//            new Login().Show();
//            this.Hide();
           
//        }

//        //Register
//        private void button1_Click(object sender, EventArgs e)
//        { 
//            if(txtusername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
//            {
//                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else if(txtpassword.Text == txtComPassword.Text)
//            {
//                conn.Open();
//                string register = "Insert into login values('" + txtusername.Text
//                    + "','" + txtpassword.Text + "','" + txtComPassword.Text + "')";
//                    SqlCommand cmd = new SqlCommand(register, conn);
//                    MessageBox.Show("Your account has beemn succesfully created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
//                    conn.Close();

//                txtusername.Text = "";
//                txtpassword.Text = "";
//                txtComPassword.Text = "";
//            }
//            else
//            {
//                    MessageBox.Show("Password does not match,Please Re-enter","Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    txtpassword.Text = "";
//                    txtComPassword.Text = "";
//                    txtpassword.Focus();

                    
//            }
              
//        }

//        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
//        {
//            if(CheckbxShowPas.Checked)
//            {
//                txtpassword.UseSystemPasswordChar = true;
//                txtComPassword.UseSystemPasswordChar = true;
//            }
//            else
//            {
//                txtpassword.UseSystemPasswordChar = false;
//                txtComPassword.UseSystemPasswordChar = false;

//            }
//        }

//        private void Form2_Load(object sender, EventArgs e)
//        {
//            txtpassword.UseSystemPasswordChar=false;
//            txtComPassword.UseSystemPasswordChar=true;  
//        }
//    }
//}
//>>>>>>> 59ac68c15793a70ec9be79f402a5327d6a303b5c
