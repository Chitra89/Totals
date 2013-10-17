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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            UtilityDetails obj = new UtilityDetails();
            obj.Show(); 
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            Listing obj = new Listing();
            obj.Show(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EstimateBill obj = new EstimateBill();
            obj.Show();
        }
    }
}
