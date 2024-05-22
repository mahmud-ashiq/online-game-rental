using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalManagement
{
    public partial class Verify : Form
    {
        public Verify()
        {
            InitializeComponent();
        }

        private void otpTextBox_Click(object sender, EventArgs e)
        {
            if (resetotpTextBox.Text == "Enter OTP")
            {
                resetotpTextBox.Text = "";
                resetotpTextBox.ForeColor = Color.Silver;
            }
        }

        private void otpTextBox_Leave(object sender, EventArgs e)
        {
            if (resetotpTextBox.Text == "")
            {
                resetotpTextBox.Text = "Enter OTP";
                resetotpTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.Silver;
            }
        }

        private string otp_code { get; set; }
        private void send_otp_btn_Click(object sender, EventArgs e)
        {
            AccountOperation accountOperation = new AccountOperation();
            otp_code= accountOperation.otp(emailTextBox.Text);
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            
            
            if (otp_code == (resetotpTextBox.Text).ToString())
            {
                //to = resetotpTextBox.Text;
                //resetPass rp = new resetPass();
                //this.Hide();
                //rp.Show();
                MessageBox.Show("Verified. Now you can login");
                Login login = new Login(); 
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void go_back_verify_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
