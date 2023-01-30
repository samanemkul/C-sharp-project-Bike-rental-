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
using System.Security.Cryptography;

namespace petrol_bikes
{
    public partial class Electric_bike : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public Electric_bike()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Ebike" +
                "(name,bikeno,year)" +
                "values(@name,@bikeno,@year)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", Ename.Text);
            cmd.Parameters.AddWithValue("@bikeno", Eno.Text);
            cmd.Parameters.AddWithValue("@year", Eyear.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Ebike set name='" + Ename.Text + "',bikeno='" + Eno.Text + "' ,year ='" + Eyear.Text + "' where id = '" + EID.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully");
            con.Close();
            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Ebike where id = '" + EID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted successfully");
            con.Close();
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            string name = data.Cells["name"].Value.ToString();
            string bikeno = data.Cells["bikeno"].Value.ToString();
            string year = data.Cells["year"].Value.ToString();
            string id = data.Cells["id"].Value.ToString();
            MessageBox.Show("Selected name: " + name);
            MessageBox.Show("Selected bikeno: " + bikeno);
            MessageBox.Show("Selected year: " + year);
            Ename.Text = name;
            Eno.Text = bikeno;
            Eyear.Text = year;
            EID.Text = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Electric_bike_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            dataGridView1.Rows.Clear();
            string query = "select * from Ebike";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int sn = 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["name"].ToString();
                string bikeno = table.Rows[i]["bikeno"].ToString();
                string year = table.Rows[i]["year"].ToString();
                string id = table.Rows[i]["id"].ToString();
                dataGridView1.Rows.Add(sn++, name, bikeno, year,id);
            }
        }
    }
}
