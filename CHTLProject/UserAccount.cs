﻿using System;
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
            DBConnect cn = new DBConnect();
            cn.myConnection();
            DataTable dt = new DataTable();
            dt = cn.getTable("SELECT * from Employee");
            dgvCategory.DataSource = dt;
        }
        private void Load_Employee()
        {
            DataTable dt = new DataTable();
            DBConnect cn = new DBConnect();
            cn.myConnection();
            dt = cn.getTable("SELECT * from Employee");
            dgvCategory.DataSource = dt;
        }
        void LoadCustomerSearch()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Employee WHERE CONCAT (EmployeeID,EmployeeName) LIKE '%" + txtSearch.Text + "%' ", cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, Dr["EmployeeID"].ToString(), Dr["EmployeeName"].ToString());
            }
            Dr.Close();
            cn.Close();// ngat ket noi
            dgvEmployee.Rows.Clear();
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteE")
            {
                cn.Open();

                cm = new SqlCommand("EXEC pr_XoaKH @CustomerID ", cn);
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                cm.Parameters.Add(new SqlParameter("@CustomerID", row.Cells[2].Value.ToString()));
                cm.ExecuteNonQuery();
                MessageBox.Show("Order is been successfully deleted!!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                //load lai du lieu trong dgvBillOut sau khi xoa
                
            }
            if (colName == "EditE")
            {
                ModuleCustomer ctm = new ModuleCustomer();
                ctm.ShowDialog();
            }
            cn.Close();
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
