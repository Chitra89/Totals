using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   public class BillReport
    {
        public int Bill_No {get; set;}
        public string date { get; set; }
        public string partyName { get; set; }
        public string paymentType { get; set; }
        public List<Product> productList {get; set;}// new List<Product>();
        public float Add_Discount { get; set; }
        public float cash_received { get; set; }
    }
}
