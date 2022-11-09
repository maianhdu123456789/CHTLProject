using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHTLProject
{
    public partial class Customer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string str = @"Data Source=LAPTOP-IJQG44F2\SQLEXPRESS;Initial Catalog=ShopApp;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader Dr;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DBConnect cn = new DBConnect();
            cn.myConnection();
            /*            var index = dgvCategory.Rows.Add();
                        dgvCategory.Rows[index].Cells["Column2"].Value = cn.GetFieldValues("SELECT customerId from Customer") ;
                        dgvCategory.Rows[index].Cells["Column3"].Value = cn.GetFieldValues("SELECT customerName from Customer");
                        dgvCategory.Rows[index].Cells["Column4"].Value = cn.GetFieldValues("SELECT customerPhone from Customer");
                        dgvCategory.Rows[index].Cells["Column5"].Value = cn.GetFieldValues("SELECT point from Customer");*/
            DataTable dt = new DataTable();
            dt = cn.getTable("SELECT * from Customer");
            dgvCategory.DataSource = dt;
        }
        void LoadCustomerSearch()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM Customer WHERE CONCAT (CustomerId,CustomerName) LIKE '%" + txtSearch.Text + "%' ", cn);
            Dr = cmd.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, Dr["CustomerId"].ToString(), Dr["CustomerName"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
            dgvCategory.Rows.Clear();
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerSearch();
        }
    }
}
