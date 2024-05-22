using DbConnectionSample.DataAccess;
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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            
        }
        public void UserHistory()
        {
            string query = "SELECT * FROM [Gameshop].[dbo].[OrderList] WHERE username = '" + AccountOperation.current_user + "'";
            OrderListData orderListData = new OrderListData();
            var ds = orderListData.GetInfo(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void AdminHistory()
        {
            OrderListData orderListData = new OrderListData();
            dataGridView1.DataSource = orderListData.GetOrderList();
        }
    }
}
