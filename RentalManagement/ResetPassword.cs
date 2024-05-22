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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void n_passTextBox_Enter(object sender, EventArgs e)
        {
            if (n_passTextBox.Text == "New Password")
            {
                n_passTextBox.Text = "";
                n_passTextBox.ForeColor = Color.Silver;
            }
        }

        private void n_passTextBox_Leave(object sender, EventArgs e)
        {
            if (n_passTextBox.Text == "")
            {
                n_passTextBox.Text = "New Password";
                n_passTextBox.ForeColor = Color.Silver;
            }
        }

        private void cnpassTextBox_Enter(object sender, EventArgs e)
        {
            if (cnpassTextBox.Text == "Confirm New Password")
            {
                cnpassTextBox.Text = "";
                cnpassTextBox.ForeColor = Color.Silver;
            }
        }

        private void cnpassTextBox_Leave(object sender, EventArgs e)
        {
            if (cnpassTextBox.Text == "")
            {
                cnpassTextBox.Text = "Confirm New Password";
                cnpassTextBox.ForeColor = Color.Silver;
            }
        }

        private void showpass_Click(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                n_passTextBox.UseSystemPasswordChar = false;
                cnpassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                n_passTextBox.UseSystemPasswordChar = true;
                cnpassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void usernametextbox_Enter(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "Username")
            {
                usernametextbox.Text = "";
                usernametextbox.ForeColor = Color.Silver;
            }
        }

        private void usernametextbox_Leave(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "")
            {
                usernametextbox.Text = "Username";
                usernametextbox.ForeColor = Color.Silver;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (n_passTextBox.Text == cnpassTextBox.Text)
            {
                AccountOperation accountOperation = new AccountOperation();
                bool result = accountOperation.password_reset(usernametextbox.Text, cnpassTextBox.Text);
                if(result==true)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

            }
        }
    }
}
