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
