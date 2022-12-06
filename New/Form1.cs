using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace New
{
    public partial class Form1 : Form
    {
        //creation of round rectangle
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnBikes_Click(object sender, EventArgs e)
        {
            //creation of round rectangle
            pnlNav.Height = btnBikes.Height;
            pnlNav.Top = btnBikes.Top;
            btnBikes.BackColor = Color.FromArgb(46, 51, 73);
            //end
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //creation of round rectangle
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            //end
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //creation of round rectangle
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btProfile.Top;
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);
            //end
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //creation of round rectangle
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            btnAbout.BackColor = Color.FromArgb(46, 51, 73);
            //end
        }
    }
}