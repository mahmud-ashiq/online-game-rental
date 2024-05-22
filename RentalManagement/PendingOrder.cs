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
    public partial class PendingOrder : Form
    {
        string query = "SELECT * FROM [Gameshop].[dbo].[OrderList] WHERE status = 'Pending'";
        OrderListData orderListData = new OrderListData();
        public PendingOrder()
        {
            InitializeComponent();
            var ds = orderListData.GetInfo(query);
            dataGridView1.DataSource = ds.Tables[0];
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "Approval";
            dataGridViewButtonColumn.Name = "Approval";
            dataGridViewButtonColumn.Text = "Approve";
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dataGridViewButtonColumn);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dataGridView1.Columns[e.ColumnIndex].Name == "Approval")
            {
                int order_id = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                 Order order = new Order();
                 order.Approval(order_id);
                var ds = orderListData.GetInfo(query);
                dataGridView1.DataSource = ds.Tables[0];
            }            
        }

        
    }
}
