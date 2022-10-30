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
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
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
                dgvSearchProduct.Rows.Add(i, Dr["ProductId"].ToString(), Dr["ProductName"], Dr["Price"], Dr["Category"], Dr["Brand"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // for select product
            string colName= dgvSearchProduct.Columns[e.ColumnIndex].Name;
            if (colName== "Select")
            {

            }


            /*

            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record ?", "Edit record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    // cm = new SqlCommand("DELETE FROM Category WHERE categoryId LIKE '" +
                    //   dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    // cot 1 : id; hang
                    cm = new SqlCommand("EXEC pr_XoaLoaiSP @categoryId", cn);
                    cm.Parameters.AddWithValue("@categoryId", dgvCategory[1, e.RowIndex].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category is been successfully deleted!!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            */
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
