using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTLProject
{
    public partial class SearchProduct : Form
    {
        
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        SqlDataReader Dr;
        BillOut BO;
        
        public SearchProduct(BillOut billOut)
        {
            InitializeComponent();
            cn = new SqlConnection(Dbc.myConnection());
            BO = billOut;
            LoadProduct();
        }

        void LoadProduct()
        {
            dgvSearchProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Product ", cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvSearchProduct.Rows.Add(i, Dr["ProductId"].ToString(), Dr["ProductName"].ToString()) ;
            }
            Dr.Close();
            cn.Close();// ngat ket noi
            txtQuantity.Text = 1.ToString();
        }


        void LoadProductSearch()
        {
            dgvSearchProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Product WHERE CONCAT (productID,productName) LIKE '%" + txtSearch.Text + "%' ", cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvSearchProduct.Rows.Add(i, Dr["ProductId"].ToString(), Dr["ProductName"].ToString());
            }
            Dr.Close();
  
            cn.Close();// ngat ket noi
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgvSearchProduct.Columns[e.ColumnIndex].Name;
            DataGridViewRow r = new DataGridViewRow();
            r = dgvSearchProduct.Rows[e.RowIndex];
            if (colName == "Select")
            {
                try
                {
                    cn.Open();

                    cm = new SqlCommand("pr_ThemOrderOut", cn);
                    cm.Parameters.Add(new SqlParameter("@orderid", BO.lblBillOutID.Text));
                    cm.Parameters.Add(new SqlParameter("productID", r.Cells[1].Value.ToString()));
                    cm.Parameters.Add(new SqlParameter("quantity", txtQuantity.Text));
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("* An error occurred while interacting with SQL Server: " + ex);
                }
                finally
                {
                    cn.Close();
                }
                txtQuantity.Text = 1.ToString();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductSearch();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
        }
        
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search product here")
            {
                txtSearch.Clear();  
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;

            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.MediumPurple;

            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
