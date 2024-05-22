using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DbConnectionSample.DataAccess;

namespace RentalManagement
{
    internal class Order
    {
        OrderListData orderListData = new OrderListData();
        public void AddToCart(int game_id,string title, string price)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            checkout.ShowInfo(game_id,title, price);
        }

        public bool ConfirmOrder(int id,string transection, string price, string method)
        {
            Random random = new Random();           
            OrderList orderList = new OrderList();
            orderList.OrderID = random.Next(99999);
            orderList.Username = AccountOperation.current_user;
            orderList.GameID = id;
            orderList.TransectionID = transection;
            orderList.Amount =int.Parse(price);
            orderList.PaymentMethod= method;
            orderList.Status = "Pending";
            OrderListData data = orderListData;
            bool result = data.Insert(orderList);
            
                if (result == true)
                {
                    return true;
                }
                else return false;
        }
        public void PurchaseHistory()
        {   
            History history = new History();
            history.Show();
            history.UserHistory();
        }

        public void PendingOrders()
        {
            new PendingOrder().Show();
        }

        public void Approval(int order_id)
        {
            string query = "UPDATE [GameShop].[dbo].[OrderList] SET status = 'Approved' WHERE order_id = '" + order_id + "'";
            bool result = orderListData.UpdateInfo(query);
            if (result)
            {
                MessageBox.Show("Approved");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
        public void RefundRequest(int order_id)
        {
            string query = "UPDATE [GameShop].[dbo].[OrderList] SET status = 'Requesting Refund' WHERE order_id = '" + order_id + "'";
            bool result = orderListData.UpdateInfo(query);
            if (result)
            {
                MessageBox.Show("Request submitted");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        public void RefundApproval(int order_id)
        {
            string query = "UPDATE [GameShop].[dbo].[OrderList] SET status = 'Refunded' WHERE order_id = '" + order_id + "'";
            bool result = orderListData.UpdateInfo(query);
            if (result)
            {
                MessageBox.Show("Refunded");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}

