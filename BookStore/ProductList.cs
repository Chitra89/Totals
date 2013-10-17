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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            try
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
                dgvProductList.DataSource = ds;
                dgvProductList.DataMember = "Table";
                dgvProductList.Dock = DockStyle.Fill;
                dgvProductList.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
