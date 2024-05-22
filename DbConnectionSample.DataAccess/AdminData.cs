using DbConnectionSample.Framework;
using RentalManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbConnectionSample.DataAccess
{
    public class AdminData
    {
        public DataSet GetInfo(string query)
        {
            SqlDbAccess da = new SqlDbAccess();
            SqlCommand cmd = da.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
