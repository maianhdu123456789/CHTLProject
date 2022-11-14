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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Db = new DBConnect();
        SqlDataReader Dr;
        string employeeid;
        public UserAccount(string employeeid)
        {
            InitializeComponent();
            cn = new SqlConnection(Db.myConnection());
            this.employeeid = employeeid;
        }
        private bool CheckManager()
        {
            cn.Open();
            //lay du lieu checkManager
            cm = new SqlCommand("select checkManageer from Employee where EmployeeID = @employeeid", cn);
            cm.Parameters.Add("@employeeid", employeeid); 
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
        private void Employee_Load(object sender, EventArgs e)
        {

            Load_Employee();
        }
        private void Load_Employee()
        {
            dgvEmployee.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from Employee",cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, Dr["EmployeeId"].ToString(), Dr["EmployeeName"].ToString(), Dr["employeeAddress"].ToString(), Dr["employeePhoneNum"], Dr["userName"], Dr["pass_word"], Dr["checkManageer"].ToString());
            }
            Dr.Close();
            cn.Close();
            /*   DataTable dt = new DataTable();
               DBConnect cnn = new DBConnect();
               cnn.myConnection();
               dt = cnn.getTable("SELECT * from Employee");
               dgvEmployee.DataSource = dt;*/
        }
        void LoadCustomerSearch()
        {
            cn.Open();
            dgvEmployee.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Employee WHERE CONCAT (EmployeeID,EmployeeName) LIKE '%" + txtSearch.Text + "%' ", cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, Dr["EmployeeId"].ToString(), Dr["EmployeeName"].ToString(), Dr["employeeAddress"].ToString(), Dr["employeePhoneNum"], Dr["userName"], Dr["pass_word"], Dr["checkManageer"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployee.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteE")
            {
                cn.Open();

                cm = new SqlCommand("pr_XoaNV", cn);
                cm.Parameters.Add(new SqlParameter("@EmployeeID", dgvEmployee[1,e.RowIndex].Value.ToString()));
                cm.CommandType = CommandType.StoredProcedure;
                cm.ExecuteNonQuery();
                MessageBox.Show("Order is been successfully deleted!!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                Load_Employee();
                
            }
            if (colName == "EditE")
            {
                int i = 0;
                ModuleEmployee ctm = new ModuleEmployee();
                ctm.txtEName.ReadOnly = true;
                ctm.txtEName.Text = dgvEmployee[2, e.RowIndex].Value.ToString();
                ctm.txtEAddress.ReadOnly = true;
                ctm.txtEAddress.Text = dgvEmployee[3, e.RowIndex].Value.ToString();
               // ctm.dtpDayofbirth.Value.Date = dgvEmployee[3, e.RowIndex].Value;
                ctm.txtEPhone.ReadOnly = true;
                ctm.txtEPhone.Text=dgvEmployee[4, e.RowIndex].Value.ToString();
                ctm.cdRole.Text = (dgvEmployee[7, e.RowIndex].Value.ToString() == "True") ? "Manager" : "Employee";
                ctm.txtUserName.ReadOnly = true;
                ctm.txtUserName.Text = dgvEmployee[5, e.RowIndex].Value.ToString();
                ctm.btnSave.Hide();
                ctm.ShowDialog();

                Load_Employee();
            }
            cn.Close();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Employee here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;

            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Employee here";
                txtSearch.ForeColor = Color.MediumPurple;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerSearch();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ModuleEmployee ctm = new ModuleEmployee();
            ctm.ShowDialog();
            Load_Employee();
        }


        /*  private void buttonSave_Click(object sender, EventArgs e)
          {
              cn.Open();
              if (CheckManager())
              {
                  if (txtPassword == txtRePassword)
                  {
                      cm = new SqlCommand("pr_ThemNV @EmployeeName @dayOfBith @employeeAddress @employeePhoneNum @userName @pass_word", cn);
                      cm.Parameters.Add(new SqlParameter("@EmployeeName", txtEName.Text));
                      cm.Parameters.Add(new SqlParameter("@dayOfBith", dtpDayofbirth));
                      cm.Parameters.Add(new SqlParameter("@employeeAddress", txtEAddress.Text));
                      cm.Parameters.Add(new SqlParameter("@employeePhoneNum", txtEPhone.Text));
                      cm.Parameters.Add(new SqlParameter("@userName", txtUserName.Text));
                      cm.Parameters.Add(new SqlParameter("@pass_word", txtPassword.Text));
                      cm.ExecuteNonQuery();
                  }
                  else
                  {
                      MessageBox.Show("Password don't match !!", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
              }
              else
              {
                  MessageBox.Show("You are not alow to do this!!", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
          }*/



    }
}
