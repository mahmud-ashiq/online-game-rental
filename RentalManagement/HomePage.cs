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
using System.Windows.Forms.VisualStyles;

namespace RentalManagement
{
    
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            GameLibraryData gameLibraryData = new GameLibraryData();
            dataGridView1.DataSource= gameLibraryData.GetGameList();
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "Purchase";
            dataGridViewButtonColumn.Name = "Purchase";
            dataGridViewButtonColumn.Text = "Purchase";
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dataGridViewButtonColumn);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result=  MessageBox.Show("DO you really wants to logout?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Login login= new Login();
                login.Show();
                this.Hide();
                AccountOperation.current_user = null;
            }
            
        }

        private void UpdateProfile_btn_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate= new UserUpdate();
            userUpdate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ShowProfile().Show(); 
        }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Purchase")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string title = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string price = (dataGridView1.CurrentRow.Cells[4].Value.ToString());               
                Order order = new Order();
                order.AddToCart(id,title,price);
            }
            
        }

        private void purchase_history_btn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.PurchaseHistory();
        }

        private void refund_btn_Click(object sender, EventArgs e)
        {
            RefundRequest request = new RefundRequest(1);
            //request.UserRefundRequest();
            //RefundRequest.flag = true;
            request.Show();
            
            
        }
    }
}
