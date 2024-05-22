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
    public partial class PassResetVerification : Form
    {
        public PassResetVerification()
        {
            InitializeComponent();
        }

        

        private void reset_pass_verify_btn_Click(object sender, EventArgs e)
        {
            if (otp_code == (otpTextBox.Text).ToString())
            {
                MessageBox.Show("Verified");
                ResetPassword resetPassword = new ResetPassword();
                resetPassword.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void reserpass_usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (reserpass_usernameTextBox.Text == "Enter Email")
            {
                reserpass_usernameTextBox.Text = "";
                reserpass_usernameTextBox.ForeColor = Color.Silver;
            }
        }
        private void reserpass_usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (reserpass_usernameTextBox.Text == "")
            {
                reserpass_usernameTextBox.Text = "Enter Email";
                reserpass_usernameTextBox.ForeColor = Color.Silver;
            }
        }

        private void otpTextBox_Click(object sender, EventArgs e)
        {
            if (otpTextBox.Text == "Enter OTP")
            {
                otpTextBox.Text = "";
                otpTextBox.ForeColor = Color.Silver;
            }
        }

        private void otpTextBox_Leave(object sender, EventArgs e)
        {
            if (otpTextBox.Text == "")
            {
                otpTextBox.Text = "Enter OTP";
                otpTextBox.ForeColor = Color.Silver;
            }
        }

        private void go_back_reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(); 
            login.Show();
        }
        private string otp_code { get; set; }
        private void send_otp_btn_Click(object sender, EventArgs e)
        {
            AccountOperation operation = new AccountOperation();
            otp_code=operation.otp(reserpass_usernameTextBox.Text);
        }

        
    }
}
