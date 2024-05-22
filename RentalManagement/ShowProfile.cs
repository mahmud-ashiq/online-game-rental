using DbConnectionSample.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalManagement
{
    public partial class ShowProfile : Form
    {
        public ShowProfile()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            DataAccess dataAccess = new DataAccess();
            string query = "SELECT first_name, last_name, phone_number, email,address, gender FROM [GameShop].[dbo].[User] WHERE username = '" + AccountOperation.current_user + "' ";
            UserData userData = new UserData();
            var ds= userData.ShowProfile(query);

            while (ds.Read())
            { 
                textBox1.Text = ds.GetValue(0).ToString();
                textBox2.Text = ds.GetValue(1).ToString();
                textBox3.Text = ds.GetValue(2).ToString();
                textBox4.Text = ds.GetValue(3).ToString();
                textBox5.Text = ds.GetValue(4).ToString();
                textBox6.Text = ds.GetValue(5).ToString();
            }
           
            
        }
    }
}
