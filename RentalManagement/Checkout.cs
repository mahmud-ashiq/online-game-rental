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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        public int game_id;
        public void ShowInfo(int id,string title, string price)
        {
            game_id= id;
            textBox1.Text= title;
            textBox2.Text= price;
            textBox1.ReadOnly= true;
            textBox2.ReadOnly= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Order order = new Order();
                bool result = order.ConfirmOrder(game_id,textBox3.Text, textBox2.Text, comboBox1.Text);

            if (result == true)
            {
                MessageBox.Show("Order Confirmed");
                this.Hide();
            }
            else MessageBox.Show("asdf");
            
            
        }
    }
}
