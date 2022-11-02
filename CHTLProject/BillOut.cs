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
    public partial class BillOut : Form
    {
        public string productid;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        public int quantity;
        string employeeid;


        public BillOut(string employeeid)
        {
            InitializeComponent();
            cn = new SqlConnection(Dbc.myConnection());
            this.employeeid = employeeid;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchProduct searchProduct = new SearchProduct(this); 
            searchProduct.ShowDialog();

        }
        private string FindLastBillOutID()
        {
            // lay ID cua billOut gan nhat
            cn.Open();
            cm = new SqlCommand("SELECT TOP(1) * FROM BillOut ORDER BY(billOutID) DESC", cn);
            SqlDataReader Dr = cm.ExecuteReader();
            string i = "";
            if (Dr.Read())
            {
                i = Dr["billOutID"].ToString();
            }
            Dr.Close();
            cn.Close();
            return i;
        }
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            cn.Open(); //mo ket noi

            //goi thu tuc tao Bill moi
            cm = new SqlCommand("pr_ThemBillOut", cn);
            cm.Parameters.Add(new SqlParameter("@employeeID", lblEmployeeID.Text));
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            cn.Close();// dong ket noi

            //gan ID cua bill moi tao cho label hien thi billOutID
            lblBillOutID.Text = FindLastBillOutID();
        }

        private void BillOut_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = employeeid;
        }
    }
}
