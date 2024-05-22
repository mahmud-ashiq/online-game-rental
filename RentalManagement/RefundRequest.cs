using DbConnectionSample.DataAccess;
using System;
using System.Collections;
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
    public partial class RefundRequest : Form
    {
        string user_query = "SELECT * FROM [Gameshop].[dbo].[OrderList] WHERE username = '" + AccountOperation.current_user + "' AND status ='Approved'";
        string admin_query = "SELECT * FROM [Gameshop].[dbo].[OrderList] WHERE status ='Requesting Refund'";
        OrderListData orderListData = new OrderListData();
        public static bool flag;
        public RefundRequest(int x)
        {
            InitializeComponent();
            if (x==1)
            {
                var ds = orderListData.GetInfo(user_query);
                dataGridView1.DataSource = ds.Tables[0];
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.HeaderText = "Request Refund";
                dataGridViewButtonColumn.Name = "Request Refund";
                dataGridViewButtonColumn.Text = "Request";
                dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(dataGridViewButtonColumn);
            }
            else if(x==0)
            {
                var ds = orderListData.GetInfo(admin_query);
                dataGridView1.DataSource = ds.Tables[0];
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.HeaderText = "Approval";
                dataGridViewButtonColumn.Name = "Approval";
                dataGridViewButtonColumn.Text = "Refund";
                dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(dataGridViewButtonColumn);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Request Refund")
            {
                int order_id = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Order order = new Order();
                order.RefundRequest(order_id);
                var ds = orderListData.GetInfo(user_query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Approval")
            {
                int order_id = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Order order = new Order();
                order.RefundApproval(order_id);
                var ds = orderListData.GetInfo(admin_query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
