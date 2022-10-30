using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHTLProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        #region pannelSide

        private void customizeDesign()
        // An subpanel 
        {
            panelSubProduct.Visible = false;
            panelSubSetting.Visible = false;
            panelSubTransaction.Visible= false;
            panelSubStatistical.Visible=false;  
        }

        private void hideSubmenu()
        {
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubSetting.Visible == true)
                panelSubSetting.Visible = false;
            if (panelSubTransaction.Visible == true)
                panelSubTransaction.Visible = false;
            if (panelSubStatistical.Visible == true)
                panelSubStatistical.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            // Mo subpnel khi dc goi
            // Ko thi dong lai
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion pnanelSile

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;// hien thi ten childform 
            panelMain.Controls.Add(childForm); // them child vao panel
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void s(Button button)
        {
            panelS.BackColor = panelS.BackColor;
            panelS.Height = button.Height;
            panelS.Width = button.Width;
            panelS.Top = button.Top;
        }
        private void panelS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            s(btnProduct);
            showSubmenu(panelSubProduct);

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hideSubmenu();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supllier());
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubTransaction);
        }

        private void btnBillOut_Click(object sender, EventArgs e)
        {
            openChildForm(new BillOut());
            hideSubmenu();
        }

        private void btnBillIn_Click(object sender, EventArgs e)
        {
            openChildForm(new BillIn());
            hideSubmenu();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStatistical);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubSetting);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAccount());
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            s(btnDashboard);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer());
        }

        private void picExit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
