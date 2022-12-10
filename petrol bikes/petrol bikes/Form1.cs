using System.Data;
using System.Data.SqlClient;
namespace petrol_bikes
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=Petrolbikes;
                                                Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Pbike" +
                "(name,bikeno,year)" +
                "values(@name,@bikeno,@year)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", pname.Text);
            cmd.Parameters.AddWithValue("@bikeno", pno.Text);
            cmd.Parameters.AddWithValue("@year", pyear.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Pbike set name='" + pname.Text + "',bikeno='" + pno.Text + "' ,year ='" + pyear.Text + "' where id = '" + PID.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            DisplayData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            dataGridView1.Rows.Clear();
            string query = "select * from Pbike";
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
                dataGridView1.Rows.Add(sn++, name, bikeno, year);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Pbike where id = '" + PID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
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
            pname.Text = name;
        }
    }
}