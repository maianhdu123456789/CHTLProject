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
    public partial class ModuleEmployee : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Db = new DBConnect();
        SqlDataReader Dr;
        public ModuleEmployee()
        {
            InitializeComponent();
            cn = new SqlConnection(Db.myConnection());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (txtPassword.Text == txtRePassword.Text)
            {
                cm = new SqlCommand("pr_ThemNV", cn);
                cm.Parameters.Add(new SqlParameter("@EmployeeName", txtEName.Text));
                cm.Parameters.Add(new SqlParameter("@dayOfBirth", dtpDayofbirth.Value.Date));
                cm.Parameters.Add(new SqlParameter("@employeeAddress", txtEAddress.Text));
                cm.Parameters.Add(new SqlParameter("@employeePhoneNum", txtEPhone.Text));
                cm.Parameters.Add(new SqlParameter("@username", txtUserName.Text));
                cm.Parameters.Add(new SqlParameter("@pass_word", txtPassword.Text));
                
                cm.CommandType = CommandType.StoredProcedure;
                cm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("PassWork dont match !!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
            this.Close();
        }

        private void btnChange_pass_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (txtPassword.Text == txtRePassword.Text)
            {
            cm = new SqlCommand("pr_SuaNv", cn);
            cm.Parameters.Add(new SqlParameter("@EmployeeName", txtEName.ToString()));
            cm.Parameters.Add(new SqlParameter("@dayOfBirth", dtpDayofbirth.Value.Date));
            cm.Parameters.Add(new SqlParameter("@employeeAddress", txtEAddress.ToString()));
            cm.Parameters.Add(new SqlParameter("@employeePhoneNum", txtEPhone.ToString()));
            cm.Parameters.Add(new SqlParameter("@username", txtUserName.ToString()));
            cm.Parameters.Add(new SqlParameter("@pass_word", txtPassword.Text));
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("PassWork dont match !!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
            this.Close();

        }
    }
}
