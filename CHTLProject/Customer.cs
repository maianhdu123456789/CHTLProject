using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHTLProject
{
    public partial class Customer : Form
    {
        DBConnect conn = new DBConnect();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader Dr;
        public Customer()
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DBConnect cn = new DBConnect();
            cn.myConnection();
            DataTable dt = new DataTable();
            dt = cn.getTable("SELECT * from Customer");
            dgvCategory.DataSource = dt;
        }
        void LoadCustomer()
        {
            DBConnect cn = new DBConnect();
            cn.myConnection();
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
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete") 
            {
                cn.Open();

                cmd = new SqlCommand("EXEC pr_XoaKH @CustomerID ", cn);
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                cmd.Parameters.Add(new SqlParameter("@CustomerID", row.Cells[2].Value.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order is been successfully deleted!!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                //load lai du lieu trong dgvBillOut sau khi xoa
                LoadCustomer();
            }
            if (colName == "Edit")
            {
                ModuleCustomer ctm = new ModuleCustomer();
                ctm.ShowDialog();
            }
            cn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerSearch();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuleCustomer ctm = new ModuleCustomer();
            ctm.ShowDialog();
        }
    }
}
