using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FinalPrint : Form
    {
        public FinalPrint()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
    	    String message = System.Environment.UserName;
            Font messageFont = new Font("Arial",24,System.Drawing.GraphicsUnit.Point);
    	    g.DrawString(message,messageFont,Brushes.Black,100,100);

        }

        private void FinalPrint_Load(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = conn;
            com.CommandText = "ProductList";
            DataSet ds = new DataSet();
            SqlDataAdapter adpater = new SqlDataAdapter("ProductList", conn);
            adpater.Fill(ds);
             
            this.reportViewer1.RefreshReport();
        }
    }
}
