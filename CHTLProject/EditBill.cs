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
    public partial class EditOrder : Form
    {
        public int oldquantity;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        SqlDataReader Dr;
        public EditOrder()
        {
            InitializeComponent();
            cn = new SqlConnection(Dbc.myConnection());
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("pr_SuaOrderOut", cn);
            cm.Parameters.Add(new SqlParameter("orderid", lblBillOut.Text));
            cm.Parameters.Add(new SqlParameter("productID", lblProductId.Text));
            cm.Parameters.Add(new SqlParameter("quantity", oldquantity));
            cm.Parameters.Add(new SqlParameter("newquantity", txtQuantity.Text));
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            cn.Close();
            this.Close();
        }
    }
}
