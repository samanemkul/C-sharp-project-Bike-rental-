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
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First Name")
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == " ")
            {
                textBox1.Text = "First Name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Middle Name")
            {
                textBox2.Text = " ";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == " ")
            {
                textBox2.Text = "Middle Name";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if(textBox3.Text == "Last Name")
            {
                textBox3.Text = " ";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(textBox3.Text == " ")
            {
                textBox3.Text = "Last Name";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Enter Complete Address")
            {
                textBox4.Text = " ";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if(textBox4.Text == " ")
            {
                textBox4.Text = "Enter Complete Address";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if(textBox5.Text == "Enter Contact Number")
            {
                textBox5.Text = " ";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if(textBox5.Text == " ")
            {
                textBox5.Text = "Enter Contact Number";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if(textBox6.Text == "Enter Email Address")
            {
                textBox6.Text = " ";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if(textBox6.Text == " ")
            {
                textBox6.Text = "Enter Email Address";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Gender")
            {
                comboBox1.Text = " ";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if(comboBox1.Text == " ")
            {
                comboBox1.Text = "Gender";
                comboBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if(textBox7.Text == "Enter Civil Status")
            {
                textBox7.Text = " ";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if(textBox7.Text == " ")
            {
                textBox7.Text = "Enter Civil Status";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if(textBox8.Text == "Enter Age")
            {
                textBox8.Text = " ";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if(textBox8.Text == " ")
            {
                textBox8.Text = "Enter Age";
                textBox8.ForeColor = Color.Silver;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if(textBox9.Text == "Enter Username")
            {
                textBox9.Text = " ";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if(textBox9.Text == " ")
            {
                textBox9.Text = "Enter Username";
                textBox9.ForeColor = Color.Silver;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if(textBox10.Text == "Enter Password")
            {
                textBox10.Text = " ";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if(textBox11.Text == "Enter Account Status")
            {
                textBox11.Text = " ";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if(textBox10.Text == " ")
            {
                textBox10.Text = "Enter Password";
                textBox10.ForeColor = Color.Silver;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if(textBox11.Text == " ")
            {
                textBox11.Text = "Enter Account Status";
                textBox11.ForeColor = Color.Silver;
            }
        }
    }
}
