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
    public partial class AdminPanel : Form
    {
        GameLibraryData gameLibraryData = new GameLibraryData();
        public AdminPanel()
        {
            InitializeComponent();
            dataGridView1.DataSource = gameLibraryData.GetGameList();
            textBox1.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Users().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            history.AdminHistory();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Order().PendingOrders();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [GameShop].[dbo].[GameLibrary] SET price = '"+int.Parse(textBox4.Text)+"' WHERE game_id = '"+int.Parse(textBox1.Text)+"'";
            bool result = gameLibraryData.UpdateInfo(query);
            if (result == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
                MessageBox.Show("Failed");
            
            dataGridView1.DataSource = gameLibraryData.GetGameList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameLibraryData data = new GameLibraryData();
            bool result = data.DeleteGame(int.Parse(textBox1.Text));
            if(result== true)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
                MessageBox.Show("Not Found");
            dataGridView1.DataSource = gameLibraryData.GetGameList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RefundRequest refundRequest = new RefundRequest(0);
            refundRequest.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Are you really want to logout?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameShopOperation operation = new GameShopOperation();
            bool result = operation.AddGame(textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), textBox5.Text);
            if(result == true)
            {
                MessageBox.Show("Added Successfully");
            }
            else MessageBox.Show("Failed");
            dataGridView1.DataSource = gameLibraryData.GetGameList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
