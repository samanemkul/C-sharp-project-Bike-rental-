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
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM rental where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void SearchRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carrentalDataSet3.rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.carrentalDataSet3.rental);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\CarRentalServiceManagementSystemCSharp\CarRentalServiceManagementSystemCSharp\carrental.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM rental";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
