using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHTLProject
{
    internal class DBConnect
    {
        private string conn;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();

        public string myConnection()
        {
            conn = @"Data Source=User;Initial Catalog=ShopApp;Integrated Security=True";
            return conn;

        }
        public DataTable getTable(string query)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
