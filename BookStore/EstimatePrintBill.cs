using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class EstimatePrintBill : Form
    {
        public BillReport rpt = new BillReport();   
        public EstimatePrintBill()
        {
            InitializeComponent();
              
        }

        public EstimatePrintBill(BillReport report):this()
        {
            rpt = report;
            float amt = 0;
            foreach (Product p in report.productList)
            {
                amt += p.Amt;
            }
            txtAmt.Text = amt.ToString();
            txtTotalAmt.Text = amt.ToString();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            rpt.cash_received = Convert.ToSingle(txtReceived.Text);
            rpt.Add_Discount = Convert.ToSingle(txtDiscount.Text);
            FinalPrint obj = new FinalPrint(rpt);
            obj.Show(); 
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            float discount = Convert.ToSingle(((System.Windows.Forms.TextBox)(sender)).Text);
            txtTotalAmt.Text = (Convert.ToSingle(txtAmt.Text) - discount).ToString();
        }

        
    }
}
