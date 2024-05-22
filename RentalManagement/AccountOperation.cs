using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Odbc;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DbConnectionSample;
using DbConnectionSample.DataAccess;

namespace RentalManagement
{
    public delegate bool LoginDelegate(string username, string password);
    public class AccountOperation
    {
        internal static string current_user;
        
        public bool create_user(string first_name, string last_name, string username, string password, string address, string gender, string phone, string email)
        {
            User u = new User();
            u.Username= username;
            u.FirstName= first_name;
            u.LastName= last_name;
            u.Password= password;
            u.PhoneNumber= phone;
            u.Email= email;
            u.Address= address;
            u.Gender= gender;
            UserData userData = new UserData();
            return userData.Insert(u);

        }
        public static bool AdminLogin(string username , string password)
        {
            string query = "SELECT [username],[password] FROM [GameShop].[dbo].[Admin] WHERE username = '" + username + "' AND password = '" + password + "'";
            AdminData adminData = new AdminData();
            var ds = adminData.GetInfo(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public static bool user_login(string username, string password)
        {
            string query = "SELECT [username],[password] FROM [GameShop].[dbo].[User] WHERE username = '" + username + "' AND password = '" + password + "'";
            UserData userData = new UserData();
            var ds = userData.GetInfo(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                current_user = username;
                return true;
            }
            else return false;
        }

        

        public bool UsernameCheck(string username)
        {
            string query = "SELECT [username] FROM [GameShop].[dbo].[User] WHERE username = '" + username + "' ";
            UserData userData = new UserData();
            var ds = userData.GetInfo(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool password_reset (string username, string new_password) 
        {
            bool result = UsernameCheck(username);
            if (result == true)
            {
                string resetquery = "UPDATE [GameShop].[dbo].[User] SET password = '" + new_password + "' WHERE username = '" + username + "'";
                UserData userData = new UserData();
                bool flag = userData.UpdateInfo(resetquery);
                if(flag)
                {
                    MessageBox.Show("Password Changed Successfully");
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username Not Found");
                return false;
            }
        }
        private String randomCode { get; set; }
        public static String to;
        public string otp(string email)
        {
            bool result = check_email(email);
            if (result == false)
            {
                String from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (email).ToString();
                from = "michaelfaraday190@gmail.com";
                pass = "iakilbmpfpixanzi";
                messageBody = "Your verification code is " + randomCode;
                message.To.Add(to);
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
                    return randomCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Email not found");
                return null;
            }
                


        }

        
        public bool check_email(string email)
        {
                string query = "SELECT [email] FROM [GameShop].[dbo].[User] WHERE email = '" + email + "' ";
                UserData userData = new UserData();
                var ds = userData.GetInfo(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Email already in use");
                    return false;     
                }
                else
                {
                    return true;
                }
        }

        public void update_password(string password)
        {
            string query = "UPDATE [GameShop].[dbo].[User] SET password = '" + password + "' WHERE username = '" + current_user + "'";
            UserData userData = new UserData();
            bool result = userData.UpdateInfo(query);
            if (result == true)
            {
                MessageBox.Show("Password Updated Successfully");
            }
            else
            {
                MessageBox.Show("An error occured");
            }
        }

        public void update_address(string address)
        {
                string query = "UPDATE [GameShop].[dbo].[User] SET address = '" + address + "' WHERE username = '" + current_user + "'";
                UserData userData = new UserData();
                bool result = userData.UpdateInfo(query);
                if (result == true)
                {
                    MessageBox.Show("Address Updated Successfully");
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
        }

        public void update_phone(string phone)
        {
                string query = "UPDATE [GameShop].[dbo].[User] SET phone_number = '" + phone + "' WHERE username = '" + current_user + "'";
                UserData userData = new UserData();
                bool result = userData.UpdateInfo(query);
                if (result == true)
                {
                    MessageBox.Show("Phone Number Updated Successfully");
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
        }

        public int Login(string username, string password)
        {
            LoginDelegate loginDelegate = new LoginDelegate(AdminLogin);
            if( loginDelegate(username, password)==true)
            { return 1; }
            loginDelegate = user_login;
            if (loginDelegate(username, password) == true)
            { return 2; }
            else return 0;
        }
    }
}
