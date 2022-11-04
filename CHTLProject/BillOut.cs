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
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        SqlDataReader Dr;
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
            LoadBillOut();

        }
        //tim ID cua bill gan nha
        private string FindLastBillOutID()
        {
            // lay ID cua billOut gan nhat
            cn.Open();
            cm = new SqlCommand("SELECT TOP(1) * FROM BillOut ORDER BY(billOutID) DESC", cn);
            SqlDataReader Dr = cm.ExecuteReader();
            string lastId = "";
            if (Dr.Read())
            {
                lastId = Dr["billOutID"].ToString();
            }
            Dr.Close();
            cn.Close();
            return lastId;
        }
        //tim tong tien phai thanh toan cua bill gan nhat
        private string FindBillOutTotal(String billOutID)
        {
            // lay ID cua billOut gan nhat
            cn.Open();
            cm = new SqlCommand("SELECT total FROM BillOut where billOutID = @billOutID", cn);
            cm.Parameters.Add("@billOutID", billOutID);
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
        //tim ID cau khach hang qua so dien thoai
        private String FindCustomerID(String phone)
        {
            cn.Open();
            cm = new SqlCommand("SELECT customerID FROM Customer WHERE customerPhone = @phone", cn);
            cm.Parameters.Add("@phone", phone);
            SqlDataReader Dr = cm.ExecuteReader();
            string i = "";
            if (Dr.Read())
            {
                i = Dr["customerID"].ToString();
            }
            Dr.Close();
            cn.Close();
            return i;
        }
        //tao bill moi (bill duoc tao ra la bill rong)
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            dgvBillOut.Rows.Clear();    
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
        //event load form
        private void BillOut_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = employeeid;
            LoadBillOut();
            LoadRecord();
        }

        //Load du lieu tren tabcontrol BillOut
        private void LoadBillOut()
        {
            //gan ID cua bill gan nhat cho label hien thi billOutID
            lblBillOutID.Text = FindLastBillOutID();
            //hien thi tong tien phai thanh toan cua bill gan nhat
            lblTotal.Text = FindBillOutTotal(lblBillOutID.Text) + "đ";
            
            dgvBillOut.Rows.Clear();
            //mo ket noi
            cn.Open();
            //tien hanh lay du lieu
            cm = new SqlCommand("select * from OrderDetail", cn);
            Dr = cm.ExecuteReader();

            int i = 0; //bien so thu tu
            //dien du lieu vao datagridview dgvBillOut
            while (Dr.Read())
            {
                i++;
                dgvBillOut.Rows.Add(i, Dr["ProductId"].ToString(), Dr["ProductName"].ToString(), Dr["Price"].ToString(), Dr["Quantity"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
        }
        //Kiem tra nhan vien dang dang nhap co phai quan ly khong
        private bool CheckManager()
        {
            cn.Open();
            //lay du lieu checkManager
            cm = new SqlCommand("select checkManageer from Employee where EmployeeID = @employeeid", cn);
            cm.Parameters.Add("@employeeid", lblEmployeeID.Text);
            SqlDataReader Dr = cm.ExecuteReader();
            Boolean check = false;
            if (Dr.Read())
            {
                check = Convert.ToBoolean(Dr["checkManageer"].ToString());
            }
            Dr.Close();
            cn.Close();
            //tra ve du checkManager cua nhan vien
            return check;
        }
        //Load du lieu len tabcontrol Record BillOut
        private void LoadRecord()
        {
            dgvBillOutDetail.Rows.Clear();
            //kiem tra nhan vien co phai la quan ly khong
            if(CheckManager())
            {
                cn.Open();
                //quan ly duoc xem tat ca don da ban
                //lay du lieu tu view BillOutDetail
                cm = new SqlCommand("select * from BillOutDetail", cn);
            }
            else
            {
                cn.Open();
                //nhan vien chi duoc xem don da ban cua minh
                //lay du lieu tu view BillOutDetail
                cm = new SqlCommand("select billOutID, billDate, total, EmployeeName, customerID from BillOutDetail where employeeID = @employeeID", cn);
                cm.Parameters.Add("@employeeid", lblEmployeeID.Text);

            }

            Dr = cm.ExecuteReader();
            int i = 0;
            //hien thi thong tin cac don da ban ra datagridview dgvBillOutDetail
            while (Dr.Read())
            {
                i++;
                dgvBillOutDetail.Rows.Add(i, Dr["billOutId"], Dr["billDate"].ToString(), Dr["total"].ToString(), Dr["employeeName"].ToString(), Dr["customerID"].ToString());
            }
            Dr.Close();
            cn.Close();
        }
        //cap nhat label hien thi diem cua khach hang
        private void updatePoint(String customerID)
        {
            cn.Open();
            cm = new SqlCommand("SELECT point FROM Customer WHERE customerID = @customerID", cn);
            cm.Parameters.Add("@customerID", customerID);
            SqlDataReader Dr = cm.ExecuteReader();
            if (Dr.Read())
            {
                lblPoint.Text = Dr["point"].ToString();
            }
            Dr.Close();
            cn.Close();
        }
        //cap nhat label hien thi tong tien hoa don truoc khi giam gia
        private void updateTotalBefore ()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(price) as total FROM OrderOut WHERE orderID = @orderID", cn);
            cm.Parameters.Add("@orderID", lblBillOutID.Text);
            Dr = cm.ExecuteReader();
            if (Dr.Read())
            {
                lblSalesTotal.Text = Dr["total"].ToString() + "đ";
            }
            Dr.Close();
            cn.Close();
        }
        //event cập nhật BillOut
        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            try
            {
                //tim ID cau khach hang qua so dien thoai
                String customerID = FindCustomerID(txtCustomerPhone.Text);
                //goi thu tuc cap nhat thong tin billOut
                cn.Open();
                cm = new SqlCommand("pr_UpdateBillOut", cn);
                cm.Parameters.Add(new SqlParameter("@billOutID", lblBillOutID.Text));
                cm.Parameters.Add(new SqlParameter("customerID", customerID));
                cm.Parameters.Add(new SqlParameter("point", txtCustomerPoint.Text));
                cm.CommandType = CommandType.StoredProcedure;
                cm.ExecuteNonQuery();
                cn.Close();
                //hien thi diem cua khach hang sau khi giam gia va thanh toan
                updatePoint(customerID);
                //cap nhat label hien thi tong tien hoa don truoc khi giam gia
                updateTotalBefore();
                //cap nhat label hien thi giam gia
                lblDiscount.Text = "-"+txtCustomerPoint.Text+"đ";
                LoadBillOut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //even an nut tren txtCustomerPhone de tim thong tin khach hang
        private void txtCustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //neu an enter se bat dau tim
            {
                cn.Open();
                //lay ten và diem cua khach hang hien thi ra giao dien thong qua
                //so dien thoai duoc nhap vao
                cm = new SqlCommand("select customerName, point from Customer where customerPhone = @phone", cn);
                cm.Parameters.Add("@phone", txtCustomerPhone.Text);
                Dr = cm.ExecuteReader();
                while (Dr.Read())
                {
                    lblCustomerName.Text = Dr["customerName"].ToString();
                    lblPoint.Text = Dr["point"].ToString();
                }
                Dr.Close();
                cn.Close();
            }
        }

        private void dgvBillOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBillOut.Columns[e.ColumnIndex].Name;
            if (colName == "Del") //neu click vao cot xoa
            {
                //xac nhan co muon xoa
                if (MessageBox.Show("Are you want to delete this record ?", "Edit record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    //goi thu tuc xoa item order cua bill dang duoc thao tac
                    cm = new SqlCommand("EXEC pr_XoaOrderOut @BillOutID, @ProductID, @Quantity ", cn);
                    cm.Parameters.AddWithValue("@BillOutID", lblBillOutID.Text);
                    cm.Parameters.AddWithValue("@ProductID", dgvBillOut[1, e.RowIndex].Value.ToString());
                    cm.Parameters.AddWithValue("@Quantity", dgvBillOut[4, e.RowIndex].Value.ToString());
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Order is been successfully deleted!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    //load lai du lieu trong dgvBillOut sau khi xoa
                    LoadBillOut();
                }
            }
            else if (colName == "Edit") //neu click vao cot sua
            {
                try
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dgvBillOut.Rows[e.RowIndex];
                    if (r != null)
                    {
                        //goi form EditerOrder de nhap thon tin xoa
                        EditOrder editOrder = new EditOrder();
                        editOrder.lblBillOut.Text = lblBillOutID.Text;
                        editOrder.lblProductId.Text = dgvBillOut[1, e.RowIndex].Value.ToString();
                        editOrder.txtProductName.Text = dgvBillOut[2, e.RowIndex].Value.ToString();
                        editOrder.oldquantity = Int32.Parse(dgvBillOut[4, e.RowIndex].Value.ToString());
                        editOrder.ShowDialog();
                        ////load lai du lieu trong dgvBillOut sau khi sua
                        LoadBillOut();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }
        //event click button PrintBill - gọi form HoaDon
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.lblDiscount.Text = lblDiscount.Text;
            hoaDon.lblTongTien.Text = lblSalesTotal.Text;
            hoaDon.lblTotal.Text = lblTotal.Text;
            hoaDon.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
