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
    public partial class BillIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Db = new DBConnect();
        SqlDataReader Dr;
        string employeeid;
        public BillIn(string employeeid)
        {
            InitializeComponent();
            cn = new SqlConnection(Db.myConnection());
            this.employeeid = employeeid;   
        }
        
        void LoadcbSupplierName()
        {
            cbSupplierName.Items.Clear();
            cbSupplierName.DataSource = Db.getTable("select * from Supplier");
            cbSupplierName.DisplayMember = "supplierName";
            cbSupplierName.ValueMember = "supplierID";

        }
        
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private string FindLastBillInID()
        {
            // lay ID cua billOut gan nhat
            cn.Open();
            cm = new SqlCommand("SELECT TOP(1) * FROM BillIn ORDER BY(billInID) DESC", cn);
            SqlDataReader Dr = cm.ExecuteReader();
            string lastId = "";
            if (Dr.Read())
            {
                lastId = Dr["billInID"].ToString();
            }
            Dr.Close();
            cn.Close();
            return lastId;
        }

        private string FindBillInTotal(String billInID)
        {
            // lay ID cua billOut gan nhat
            cn.Open();
            cm = new SqlCommand("SELECT total FROM BillIn where billInID = @billInID", cn);
            cm.Parameters.Add("@billInID", billInID);
            SqlDataReader Dr = cm.ExecuteReader();
            string i = "";
            if (Dr.Read())
            {
                i = Dr["total"].ToString();
            }
            Dr.Close();
            cn.Close();
            return i;
        }

        private void LoadBillIn()
        {
            //gan ID cua bill gan nhat cho label hien thi billOutID
            lblBillInID.Text = FindLastBillInID();
            //hien thi tong tien phai thanh toan cua bill gan nhat
            lblSalesTotal.Text = FindBillInTotal(lblBillInID.Text) + "đ";

            dgvBillIn.Rows.Clear();
            //mo ket noi
            cn.Open();
            //tien hanh lay du lieu
            cm = new SqlCommand("select * from InStock", cn);
            Dr = cm.ExecuteReader();

            int i = 0; //bien so thu tu
            //dien du lieu vao datagridview dgvBillOut
            while (Dr.Read())
            {
                i++;
                dgvBillIn.Rows.Add(i, Dr["ProductId"].ToString(), Dr["productName"].ToString(), Dr["quantity"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
        }

        private void BillIn_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = employeeid;
            LoadBillIn();
            LoadcbSupplierName();
        }

        private void dgvRecordBillIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
