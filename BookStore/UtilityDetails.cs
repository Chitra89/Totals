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
    public partial class UtilityDetails : Form
    {
        public UtilityDetails()
        {
            InitializeComponent();
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            CustomerManipulation obj = new CustomerManipulation("A"); obj.Show(); 
        }

        private void btnEditParty_Click(object sender, EventArgs e)
        {
            CustomerManipulation obj = new CustomerManipulation("E"); obj.Show();
        }

        private void btnDeleteParty_Click(object sender, EventArgs e)
        {
            CustomerManipulation obj = new CustomerManipulation("D"); obj.Show();
        }
    }
}
