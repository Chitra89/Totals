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
    public partial class EstimateBill : Form
    {
        public EstimateBill()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            GetNewBillNumber(); 
        }

        private void GetNewBillNumber()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("select max(orderId) from orders", conn);

            conn.Open();
            object billno = com.ExecuteScalar();
            int iBillnumber = 0;
            if (billno.ToString() == "")
            {
                iBillnumber = 1;
               
            }
            else
            {
                iBillnumber = Convert.ToInt32(billno);
                iBillnumber += 1;
            }
            lblBillNo.Text = iBillnumber.ToString();   
        }

        private void wholesaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private DataSet FillCustName()
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
               // string ConStr = @"Data Source=PAWAN-PC\SQLEXPRESS;Initial Catalog=Bookstore;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = conn;
                com.CommandText = "CustomerList";
                DataSet ds = new DataSet();
                SqlDataAdapter adpater = new SqlDataAdapter("CustomerList", conn);
                adpater.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }


        }


        private DataSet FillProductName()
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
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        private void EstimateBill_Load(object sender, EventArgs e)
        {
            DataSet DataSserH = FillProductName();
            DataSet dsCust = FillCustName();
            cmbCustName.DataSource =dsCust.Tables[0];
            cmbCustName.DisplayMember = "Name";
            cmbCustName.ValueMember = "custid";
            dataGridView1.Rows.Add();
            DataGridViewTextBoxCell txtsrNo = (DataGridViewTextBoxCell)(dataGridView1.Rows[0].Cells[0]);
            txtsrNo.Value = 1;
            DataGridViewComboBoxCell ComboColumn = (DataGridViewComboBoxCell)(dataGridView1.Rows[0].Cells[1]);
            ComboColumn.DataSource = DataSserH.Tables[0];
            ComboColumn.DisplayMember = "Name";
            ComboColumn.ValueMember = "productId";
            ComboColumn.AutoComplete = true;
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
            TextBox tx = e.Control as TextBox;
            DataGridViewTextBoxCell cell = dataGridView1.CurrentCell as DataGridViewTextBoxCell;
            if (tx != null && cell.OwningColumn == dataGridView1.Columns["ColRate"])
            {
                tx.TextChanged -= new EventHandler(txtRate_TextChanged);
                tx.TextChanged += new EventHandler(txtRate_TextChanged);
            }
            if (tx != null && cell.OwningColumn == dataGridView1.Columns["ColQTY"])
            {
                tx.TextChanged -= new EventHandler(txtQty_TextChanged);
                tx.TextChanged += new EventHandler(txtQty_TextChanged);
            }
            if (tx != null && cell.OwningColumn == dataGridView1.Columns["txtScheme"])
            {
                tx.TextChanged -= new EventHandler(txtScheme_TextChanged);
                tx.TextChanged += new EventHandler(txtScheme_TextChanged);
            }
        }

        void txtScheme_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            DataGridViewRow r = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            double scheme = Convert.ToDouble(txt.Text);
            double rate = Convert.ToDouble(r.Cells["ColRate"].Value);
            double newrate = rate - (rate * scheme) / 100;

            r.Cells["ColTotal"].Value = newrate * Convert.ToDouble(r.Cells["ColQTY"].Value);
        }



        void txtQty_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            DataGridViewRow r = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            r.Cells["ColTotal"].Value = Convert.ToDouble(txt.Text) * Convert.ToDouble(r.Cells["ColRate"].Value);
        }

        void txtRate_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            DataGridViewRow r = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            r.Cells["ColTotal"].Value = Convert.ToDouble(txt.Text) * Convert.ToDouble(r.Cells["ColQTY"].Value);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl cbcolumn = (DataGridViewComboBoxEditingControl)sender;
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null && cb.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string item = cb.Text;
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(string.Format("select MRP,Qty,Rate from dbo.Product where productid={0}", cb.SelectedValue), conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DataGridViewTextBoxCell txtMRP = (DataGridViewTextBoxCell)(dataGridView1.Rows[cbcolumn.EditingControlRowIndex].Cells["ColMRP"]);
                    DataGridViewTextBoxCell txtQty = (DataGridViewTextBoxCell)(dataGridView1.Rows[cbcolumn.EditingControlRowIndex].Cells["ColQTY"]);
                    DataGridViewTextBoxCell txtRate = (DataGridViewTextBoxCell)(dataGridView1.Rows[cbcolumn.EditingControlRowIndex].Cells["ColRate"]);
                    DataGridViewTextBoxCell txtTotal = (DataGridViewTextBoxCell)(dataGridView1.Rows[cbcolumn.EditingControlRowIndex].Cells["ColTotal"]);
                    txtMRP.Value = rdr["MRP"];
                    txtQty.Value = rdr["Qty"];
                    txtRate.Value = rdr["Rate"];
                    txtTotal.Value = Convert.ToDouble(txtRate.Value) * Convert.ToDouble(txtQty.Value);


                }
            }

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                DataSet DataSserH = FillProductName();
                dataGridView1.Rows.Add();
                DataGridViewTextBoxCell txtsrNo = (DataGridViewTextBoxCell)(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0]);
                txtsrNo.Value = dataGridView1.Rows.Count;
                DataGridViewComboBoxCell ComboColumn = (DataGridViewComboBoxCell)(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1]);
                ComboColumn.DataSource = DataSserH.Tables[0];
                ComboColumn.DisplayMember = "Name";
                ComboColumn.ValueMember = "productId";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BillReport  print = new BillReport();
            print.Bill_No = Convert.ToInt16(lblBillNo.Text);
            print.partyName = cmbCustName.Text.ToString();
            print.date = Convert.ToString(lblDate.Text);
            print.paymentType = cmbPaymentType.Text.ToString();
            List<Product> product = new List<Product>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Product p = new Product();
                p.srno = Convert.ToInt16(row.Cells["SrNo"].Value);
                p.Item = Convert.ToString(row.Cells["produtlist"].FormattedValue);
                p.MRP = Convert.ToSingle(row.Cells["ColMRP"].Value);
	            p.qty = Convert.ToInt16(row.Cells["ColQTY"].Value);
                p.Rate = Convert.ToSingle(row.Cells["ColRate"].Value);
                p.Scheme = Convert.ToSingle(row.Cells["txtScheme"].Value);
                p.Amt = Convert.ToSingle(row.Cells["ColTotal"].Value);
                product.Add(p); 
               // p.Item = row.Cells["Item"].Value.ToString();
            }
            print.productList = product;

            EstimatePrintBill bill = new EstimatePrintBill(print);
            bill.rpt = print; 
            bill.Show(); 
        }
 
    }
}
