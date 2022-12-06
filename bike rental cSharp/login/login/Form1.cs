using System.Data.SqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection
           (@"Data source=.\SQLEXPRESS;
            Initial catalog=bike_rental;
            user id=sa;password=kist@123;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}