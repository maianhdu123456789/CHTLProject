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
        public string conn;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();

        public string myConnection()
        {
            conn = @"Data Source=LAPTOP-IJQG44F2\SQLEXPRESS; Initial Catalog=ShopApp;Integrated Security=True";
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
        public string GetFieldValues(string sql)
        {
            cn.ConnectionString = myConnection();
            string ma = "";
            cm = new SqlCommand(sql,cn);
            cn.Open();
            SqlDataReader reader;
            reader = cm.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            cn.Close();
            return ma;
        }
    }
}
