using Microsoft.Reporting.WinForms;
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
        BillReport objReport = new BillReport(); 
        public FinalPrint()
        {
            InitializeComponent();
        }

        public FinalPrint(BillReport obj):this()
        {
            objReport = obj;
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "BookStore.Report1.rdlc"; // bind reportviewer with .rdlc
            List<BillReport> lstBillReport = new List<BillReport>();
            lstBillReport.Add(objReport);  
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", lstBillReport); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            // dataset.Value = list;

            Microsoft.Reporting.WinForms.ReportDataSource dataset1 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", objReport.productList); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset1);
            // dataset1.Value = list;

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
        

        private void btnPrint_Click(object sender, EventArgs e)
        {
           // printPreviewDialog1.ShowDialog();
        }

        
        private void FinalPrint_Load(object sender, EventArgs e)
        {
            
        }
    }
}
