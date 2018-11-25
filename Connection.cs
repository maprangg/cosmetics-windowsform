using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_ERP
{
    class Connection
    {
        public static string strConn = ConfigurationManager.ConnectionStrings["connectqerp"].ConnectionString;
        public static SqlConnection connection;

        public static void connectionDatabase()
        {
            connection = new SqlConnection();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            else
            {


                connection.ConnectionString = strConn;
                connection.Open();
            }

        }
    }
}
