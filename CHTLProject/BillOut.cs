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
    public partial class BillOut : Form
    {
        public string productid;

        public int quantity;
        
        public BillOut()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchProduct searchProduct = new SearchProduct(this); 
            searchProduct.ShowDialog();

        }
    }
}
