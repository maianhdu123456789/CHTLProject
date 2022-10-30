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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search category here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;

            }
        }
        
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search category here";
                txtSearch.ForeColor = Color.MediumPurple;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
    }
}
