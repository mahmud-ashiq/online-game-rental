using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace RentalManagement
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }

        
        private void firstNameTextBox_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "First Name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "First Name";
                firstNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void lastNameTextBox_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last Name")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Last Name";
                lastNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void usersingupTextBox_Click(object sender, EventArgs e)
        {
            if (usersingupTextBox.Text == "Username")
            {
                usersingupTextBox.Text = "";
                usersingupTextBox.ForeColor = Color.Silver;
            }
        }

        private void usersingupTextBox_Leave(object sender, EventArgs e)
        {
            if (usersingupTextBox.Text == "")
            {
                usersingupTextBox.Text = "Username";
                usersingupTextBox.ForeColor = Color.Silver;
            }
        }

        private void usersignupPassTextBox_Click(object sender, EventArgs e)
        {
            if (usersignupPassTextBox.Text == "Password")
            {
                usersignupPassTextBox.Text = "";
                usersignupPassTextBox.ForeColor = Color.Silver;
            }
        }

        private void usersignupPassTextBox_Leave(object sender, EventArgs e)
        {
            if (usersignupPassTextBox.Text == "")
            {
                usersignupPassTextBox.Text = "Password";
                usersignupPassTextBox.ForeColor = Color.Silver;
            }
        }


        private void addressTextBox_Click(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "Address")
            {
                addressTextBox.Text = "";
                addressTextBox.ForeColor = Color.Silver;
            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "")
            {
                addressTextBox.Text = "Address";
                addressTextBox.ForeColor = Color.Silver;
            }
        }

        private void phoneTextBox_Click(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "Phone Number")
            {
                phoneTextBox.Text = "";
                phoneTextBox.ForeColor = Color.Silver;
            }
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "")
            {
                phoneTextBox.Text = "Phone Number";
                phoneTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
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

        private void otpTextBox_Enter(object sender, EventArgs e)
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

        public bool DataIsValid()
        {
            if (firstNameTextBox.Text == "First Name" || lastNameTextBox.Text == "Last Name"
                || usersignupPassTextBox.Text == "Username" || usersignupPassTextBox.Text == "Password"
                || addressTextBox.Text == "Address" || phoneTextBox.Text == "Phone Number" || emailTextBox.Text == "Email"
                || otpTextBox.Text == "Enter OTP")
            {
                MessageBox.Show("Please Enter All the Information");
                return false;
            }
            else return true;
        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if ((this.DataIsValid() == true) && (randomCode == otpTextBox.Text))
            {
                try
                {
                    AccountOperation operation= new AccountOperation();
                    bool result = operation.create_user(firstNameTextBox.Text, lastNameTextBox.Text, usersingupTextBox.Text,usersignupPassTextBox.Text
                                                        ,addressTextBox.Text, gendercombobox.Text,phoneTextBox.Text, emailTextBox.Text);
                    
                    
                    //DataAccess data = new DataAccess();
                    //string q = "INSERT INTO [GameShop].[dbo].[User] VALUES ('" + usersingupTextBox.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "',  '" + usersignupPassTextBox.Text + "','" + phoneTextBox.Text + "','" + emailTextBox.Text + "','" + addressTextBox.Text + "','" + gendercombobox.Text + "') ";
                    //int count = data.ExecuteDMLQuery(q);
                    if (result== true)
                    {
                        MessageBox.Show("Successfully Created");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured");
                }
            }
            else MessageBox.Show("Wrong Code");
        }                
        private void username_check_btn_Click(object sender, EventArgs e)
        {
        }
        private string otp_code { get; set; }
        private String randomCode { get; set; }
        public static String to;
        private void send_otp_btn_Click(object sender, EventArgs e)
        {
            AccountOperation operation = new AccountOperation();

            bool username_available = operation.UsernameCheck(usersingupTextBox.Text);
            if (username_available == false) 
            {
                bool available = operation.check_email(emailTextBox.Text);
                if (available == true)
                {
                    String from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = rand.Next(999999).ToString();
                    MailMessage message = new MailMessage();
                    to = (emailTextBox.Text).ToString();
                    from = "michaelfaraday190@gmail.com";
                    pass = "iakilbmpfpixanzi";
                    messageBody = "Your verification code is " + randomCode;
                    try { message.To.Add(to); }
                    catch (Exception ex) { MessageBox.Show("Invalid Email"); }
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Verify your Game Shop Account";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Send Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Email already in use");
            }
            else MessageBox.Show("Username already in use");
        }
    }
}

