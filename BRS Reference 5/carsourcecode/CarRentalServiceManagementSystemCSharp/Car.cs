using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalServiceManagementSystemCSharp
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO car(car_name,car_no,category,brand_name,colour,mfg_date,milage,insurance_no) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from car;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Car Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox1.Text = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM car";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carrentalDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carrentalDataSet.car);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select car_name,car_no,category,brand_name,colour,mfg_date,milage,insurance_no from car where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox1.Text = dr.GetValue(0).ToString();
                        textBox2.Text = dr.GetValue(1).ToString();
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox5.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox7.Text = dr.GetValue(6).ToString();
                        textBox8.Text = dr.GetValue(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Car Details Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = " Update car set car_name='" + textBox1.Text + "',car_no='" + textBox2.Text + "',category='" + textBox3.Text + "',brand_name='" + textBox4.Text + "',colour='" + textBox5.Text + "',mfg_date='" + textBox6.Text + "',milage='" + textBox7.Text + "',insurance_no='" + textBox8.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from car;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox1.Text = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM car";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
        }
    }
}
