using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Deployment.Application;

namespace RentalManagement
{
    public class DataAccess
    {
        private SqlConnection sqlcon { get; set; }
        private SqlCommand sqlcom { get; set; }
        private SqlDataAdapter sda { get; set; }
        private SqlCommandBuilder sqlbuilder { get; set; }
        private DataSet ds { get; set; }
        private SqlDataReader sdt {get; set;}
        //private DataTable dt { get; set; }
        public DataAccess()
        {
            sqlcon = new SqlConnection(@"Data Source=DESKTOP-TDE3LQ5\SQLEXPRESS;Initial Catalog=GameShop;User ID=sa;Password=ashiq");
            sqlcon.Open();
        }

        private void QueryText(string query)
        {
            sqlcom = new SqlCommand(query, sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            sda = new SqlDataAdapter(sqlcom);
            ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            QueryText(sql);
            sda = new SqlDataAdapter(sqlcom);
            ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            QueryText(sql);
 
            int u = sqlcom.ExecuteNonQuery();
            return u;
        }

        public SqlDataReader GetData(string sql)
        {
            QueryText(sql);
            sdt = sqlcom.ExecuteReader();
            return sdt;
        }

        
    }
}

