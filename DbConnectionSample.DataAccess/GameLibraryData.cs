using DbConnectionSample.Framework;
using RentalManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionSample.DataAccess
{
    public class GameLibraryData
    {
        List<GameLibrary> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<GameLibrary> list = new List<GameLibrary>();
            using (reader)
            {
                while (reader.Read())
                {
                    GameLibrary obj = new GameLibrary();
                    obj.GameID = reader.GetInt32(0);
                    obj.GameTitle = reader.GetString(1);
                    obj.ReleasedYear = reader.GetInt32(2);
                    obj.Price = reader.GetInt32(3);
                    obj.DeveloperName = reader.GetString(4);
                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public List<GameLibrary> GetGameList()
        {
            SqlDbAccess da =  new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("SELECT * FROM [GameShop].[dbo].[GameLibrary]");
            List<GameLibrary> gameList = GetData(cmd);
            return gameList;
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

        public bool Insert(GameLibrary obj)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO  [GameShop].[dbo].[GameLibrary] ([game_title],[released_year],[price],[developer_name]) VALUES (@game_title, @released_year, @price, @developer_name)");

            /*SqlParameter p = new SqlParameter("@game_id", SqlDbType.Int);
            p.Value = obj.GameID;*/

            SqlParameter p1 = new SqlParameter("@game_title", SqlDbType.VarChar, 50);
            p1.Value = obj.GameTitle;

            SqlParameter p2 = new SqlParameter("@released_year", SqlDbType.Int);
            p2.Value = obj.ReleasedYear;

            SqlParameter p3 = new SqlParameter("@price", SqlDbType.Int);
            p3.Value = obj.Price;

            SqlParameter p4 = new SqlParameter("@developer_name", SqlDbType.VarChar,50);
            p4.Value = obj.DeveloperName;

            //cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;
        }

        public bool DeleteGame(int id)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand("DELETE FROM [GameShop].[dbo].[GameLibrary] WHERE game_id = '"+id+"'");
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
    }
}
