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
            cn= new SqlConnection(Dbc.myConnection());
            BO = billOut;
            LoadProduct();
            //Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
            for ( int j=0; j < (dgvSearchProduct.Rows.Count)-1; j++)
            {
                dgvSearchProduct.Rows[j].Cells[3].Value = 1;
            }
            cn.Close();// ngat ket noi
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
            for (int j = 0; j < (dgvSearchProduct.Rows.Count) - 1; j++)
            {
                dgvSearchProduct.Rows[j].Cells[3].Value = 1;
            }
            cn.Close();// ngat ket noi
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            if (txtSearch.Text == "Search category here")
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
                txtSearch.Text = "Search category here";
                txtSearch.ForeColor = Color.MediumPurple;

            }
        }
    }
}
