using System.Data.SqlClient;

namespace DbConnectionSample.Framework
{
    public class SqlDbAccess
    {
        const string ConnectionString = "Data Source=DESKTOP-TDE3LQ5\\SQLEXPRESS;Initial Catalog=GameShop;User ID=sa;Password=ashiq";

        public SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }




    }

    
}