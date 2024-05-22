using System.Data.SqlClient;
using System.Data;
using DbConnectionSample.Framework;
using RentalManagement;
using System.Collections.Generic;
using System.Xml.Linq;


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
                    obj.PhoneNumber = reader.GetString(4);
                    obj.Email = reader.GetString(5);
                    obj.Address = reader.GetString(6);
                    obj.Gender = reader.GetString(7);
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
            SqlCommand cmd = da.GetCommand("SELECT username, first_name, +" +
                                           "last_name, phone_number, email, +" +
                                           "address, gender FROM [GameShop].[dbo].[User]");
            List<User> userList = GetData(cmd);
            return userList;
        }

        public List<User> GetStudentInfoByName(String name)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM StudentInfo WHERE Name lik '%" +
           name + "%'");
            List<User> studentList = GetData(cmd);
            return studentList;
        }

       

/*public bool Insert(StudentInfo obj)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [dbo].[StudentInfo] +" +
                "([ID],[Name],[StudentID],[ContactNo])" +
                "VALUES (@ID, @Name, @ContactNo, @StudentID)");
            SqlParameter p = new SqlParameter("@ID", SqlDbType.Int);
            p.Value = obj.ID;
            SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            p1.Value = obj.Name;

            SqlParameter p3 = new SqlParameter("@StudentID", SqlDbType.VarChar, 10);
            p3.Value = obj.StudentID;

            SqlParameter p2 = new SqlParameter("@ContactNo", SqlDbType.VarChar, 12);
            p2.Value = obj.ContactNo;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }*/

    }
}