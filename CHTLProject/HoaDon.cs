using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;

namespace CHTLProject
{
    public partial class HoaDon : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect Dbc = new DBConnect();
        SqlDataReader Dr;
        Bitmap memoryimg;
        public HoaDon()
        {
            InitializeComponent();
            cn = new SqlConnection(Dbc.myConnection());
            //this.billOut = billOut;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("select OrderOut.productID, Product.productName, OrderOut.quantity, OrderOut.price\r\n"
                    + "from OrderOut inner join Product on Product.productID = OrderOut.productID where OrderOut.orderID = (select max(billOutID) from BillOut)", cn);
            Dr = cm.ExecuteReader();
            int i = 0;
            while (Dr.Read())
            {
                i++;
                donhang_gridview.Rows.Add(i, Dr["ProductId"].ToString(), Dr["ProductName"].ToString(), Dr["Price"].ToString(), Dr["Quantity"].ToString());
            }
            Dr.Close();
            cn.Close();
        }
        private void getprintarea(Panel pn)
        {
            memoryimg = new Bitmap(pn.Width, pn.Height);
            pn.DrawToBitmap(memoryimg, new Rectangle(0, 0, pn.Width, pn.Height));
        }
        private void Print(Panel pn)
        {
            PrinterSettings ps = new PrinterSettings();
            getprintarea(pn);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private void printerBtn_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
    }
}
