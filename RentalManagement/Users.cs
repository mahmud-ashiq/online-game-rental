using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DbConnectionSample.DataAccess;
using DbConnectionSample.Framework;


namespace RentalManagement
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            /*DataAccess dataAccess = new DataAccess();
            string query = "SELECT username, first_name, last_name, phone_number, email, address, gender FROM [GameShop].[dbo].[User]";
            var ds=dataAccess.ExecuteQuery(query);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];*/

            UserData userData = new UserData();
            //DataTable t = userData.GetUserList();
            dataGridView1.DataSource= userData.GetUserList();
        }
    }
}
