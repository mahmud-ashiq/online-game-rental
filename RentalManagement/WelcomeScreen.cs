using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalManagement
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
        private void start_btn_Load(object sender, EventArgs e)
        {
            start_btn.Parent = pictureBox1;

        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
