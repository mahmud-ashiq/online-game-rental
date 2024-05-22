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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        delegate bool LoginDelegate(AccountOperation login);

        private void Form1_Load_1(object sender, EventArgs e)
        {
            forgotPass.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;            
        }
        

        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Enter Username")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.Silver;
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Enter Username";
                userTextBox.ForeColor = Color.Silver;
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.Text == "Enter Password")
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Silver;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Enter Password";
                passTextBox.ForeColor = Color.Silver;
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp= new SignUp();
            signUp.Show();
            
            this.Hide();

        }

        private void forgotPass_Click(object sender, EventArgs e)
        {
            PassResetVerification passResetVerification= new PassResetVerification();
            passResetVerification.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           
          
                if(userTextBox.Text== "Enter Username" || passTextBox.Text == "Enter Password" )
                {
                    MessageBox.Show("Please Enter Username and Password");
                }
            else
            {
                AccountOperation accountOperation = new AccountOperation();
                int result  = accountOperation.Login(userTextBox.Text, passTextBox.Text);             
                
                if(result == 1)
                {
                    new AdminPanel().Show();
                    this.Hide();
                }
                else if(result == 2)
                {
                    MessageBox.Show("Successfully logged in");
                    new HomePage().Show();
                    this.Hide();    
                }
                else if(result ==0)
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

            }
        }

        private void showpass_Click(object sender, EventArgs e)
        {
            if(showpass.Checked == true)
            {
                passTextBox.UseSystemPasswordChar = false;
            }
            else passTextBox.UseSystemPasswordChar = true;


        }
    }
    public class TransparentBackgroundTextBox : TextBox
    {
        public TransparentBackgroundTextBox()
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }
    }
}
