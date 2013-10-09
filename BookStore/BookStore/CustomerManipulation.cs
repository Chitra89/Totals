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
    public partial class CustomerManipulation : Form
    {
        public string strOperation = string.Empty; 
        public CustomerManipulation()
        {
            InitializeComponent();
        }

        public CustomerManipulation(string op):this()
        {
             
            strOperation = op;
            if (strOperation == "A")
            {
                txtName.Visible = true;
                cmbName.Visible = false; 

            }
            else
            {
                txtName.Visible = false;
                cmbName.Visible = true;
                DataSet ds = FillCustName();
                cmbName.DataSource = ds.Tables[0];
                cmbName.DisplayMember = "Name";
                cmbName.ValueMember = "custid"; 

            }
            
        }

        private DataSet FillCustName()
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString; SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = conn;
            com.CommandText = "Customermanipulation";
            if(cmbName.SelectedValue != null) 
                com.Parameters.Add(new SqlParameter("@custId",cmbName.SelectedValue));
            else
                com.Parameters.Add(new SqlParameter("@custId", 1));
            com.Parameters.Add(new SqlParameter("@Name", txtName.Text));
            com.Parameters.Add(new SqlParameter("@City", txtCity.Text));
            com.Parameters.Add(new SqlParameter("@Address", txtAddress.Text));
            com.Parameters.Add(new SqlParameter("@pincode", txtPin.Text));
            com.Parameters.Add(new SqlParameter("@op", strOperation));
            conn.Open(); 
            int iResult = com.ExecuteNonQuery();
            conn.Close();
            if (strOperation == "A")
                MessageBox.Show("Party added successfully");
            else if (strOperation == "E")
            {
                MessageBox.Show("Party edited succesfully");
            }
            else
            {
                MessageBox.Show("Party deleted succesfully");
            }
            this.Hide(); 
        }
    }
}
