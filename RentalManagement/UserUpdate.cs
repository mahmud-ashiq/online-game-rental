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
    public partial class UserUpdate : Form
    {
        AccountOperation accountOperation = new AccountOperation();
        public UserUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountOperation.update_password(passTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountOperation.update_address(addressTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountOperation.update_phone(PhoneTextBox.Text);
        }
    }
}
