using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHTLProject
{
    public partial class Customer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string str = @"Data Source=LAPTOP-IJQG44F2\SQLEXPRESS;Initial Catalog=ShopApp;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(str);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Customer ";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dgvCategory.DataSource = dt;
            cn.Close();
        }
    }
}
