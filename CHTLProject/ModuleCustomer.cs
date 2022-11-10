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
    public partial class ModuleCustomer : Form
    {
        public int oldquantity;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        SqlDataReader Dr;
        public ModuleCustomer()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("pr_SuaKH", cn);
            cm.Parameters.Add(new SqlParameter("customerId", lblId));
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            cn.Close();
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("pr_ThemKH @", cn);
            cm.Parameters.Add(new SqlParameter("CustomerName",txtCategoryName.Text));
            cm.Parameters.Add(new SqlParameter("customerPhone",txtCustomerPhone.Text));
            cm.Parameters.Add(new SqlParameter("point", 0));
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
