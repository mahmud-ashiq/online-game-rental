using DbConnectionSample.Framework;
using RentalManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DbConnectionSample.DataAccess
{
    public class UserData
    {
        List<User> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> list = new List<User>();
            using (reader)
            {
                while (reader.Read())
                {
                    User obj = new User();
                    obj.Username = reader.GetString(0);
                    obj.FirstName = reader.GetString(1);
                    obj.LastName = reader.GetString(2);
                    obj.PhoneNumber = reader.GetString(3);
                    obj.Email = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Gender = reader.GetString(6);
                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public List<User> GetUserList()
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("SELECT username, first_name, last_name, phone_number, email,address, gender FROM [GameShop].[dbo].[User]");
            List<User> userList = GetData(cmd);
            return userList;
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

        public SqlDataReader ShowProfile(string query)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            return cmd.ExecuteReader();
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




        public List<User> GetStudentInfoByName(String name)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM StudentInfo WHERE Name like '%" +
           name + "%'");
            List<User> studentList = GetData(cmd);
            return studentList;
        }

       

public bool Insert(User obj)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [GameShop].[dbo].[User] VALUES (@username, @first_name, @last_name, @password, @phone_number, @email, @address, @gender)");

            SqlParameter p = new SqlParameter("@username", SqlDbType.VarChar, 50);
            p.Value = obj.Username;

            SqlParameter p1 = new SqlParameter("@first_name", SqlDbType.VarChar, 50);
            p1.Value = obj.FirstName;

            SqlParameter p2 = new SqlParameter("@last_name", SqlDbType.VarChar, 50);
            p2.Value = obj.LastName;

            SqlParameter p3 = new SqlParameter("@password", SqlDbType.VarChar, 50);
            p3.Value = obj.Password;

            SqlParameter p4 = new SqlParameter("@phone_number", SqlDbType.VarChar, 50);
            p4.Value = obj.PhoneNumber;

            SqlParameter p5 = new SqlParameter("@email", SqlDbType.VarChar, 50);
            p5.Value = obj.Email;

            SqlParameter p6 = new SqlParameter("@address", SqlDbType.VarChar, 50);
            p6.Value = obj.Address;

            SqlParameter p7 = new SqlParameter("@gender", SqlDbType.VarChar, 50);
            p7.Value = obj.Gender;


            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

    }
}