using DbConnectionSample.Framework;
using RentalManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSample.DataAccess
{
    public class OrderListData
    {
        List<OrderList> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<OrderList> list = new List<OrderList>();
            using (reader)
            {
                while (reader.Read())
                {
                    OrderList obj = new OrderList();
                    obj.OrderID = Int32.Parse( reader.GetString(0));
                    obj.Username = reader.GetString(1);
                    obj.GameID = reader.GetInt32(2);
                    obj.TransectionID = reader.GetString(3);
                    obj.Amount = int.Parse(reader.GetString(4));
                    obj.PaymentMethod = reader.GetString(5);
                    obj.Status = reader.GetString(6);
                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public List<OrderList> GetOrderList()
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM [GameShop].[dbo].[OrderList]");
            List<OrderList> orderList = GetData(cmd);
            return orderList;
        }

        public DataSet GetInfo(string query)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public bool UpdateInfo(string query)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

        public bool Insert(OrderList obj)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [GameShop].[dbo].[OrderList] VALUES (@order_id, @username, @game_id, @Transection_id, @amount, @payment_method, @status)");

            SqlParameter p = new SqlParameter("@order_id", SqlDbType.Int);
            p.Value = obj.OrderID;

            SqlParameter p1 = new SqlParameter("@username", SqlDbType.VarChar, 50);
            p1.Value = obj.Username;

            SqlParameter p2 = new SqlParameter("@game_id", SqlDbType.Int);
            p2.Value = obj.GameID;

            SqlParameter p3 = new SqlParameter("@transection_id", SqlDbType.VarChar, 50);
            p3.Value = obj.TransectionID;

            SqlParameter p4 = new SqlParameter("@amount", SqlDbType.Int);
            p4.Value = obj.Amount;

            SqlParameter p5 = new SqlParameter("@payment_method", SqlDbType.VarChar, 50);
            p5.Value = obj.PaymentMethod;

            SqlParameter p6 = new SqlParameter("@status", SqlDbType.VarChar, 50);
            p6.Value = obj.Status;

            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }
    }
}
