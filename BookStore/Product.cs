using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Product
    {
        public int srno { get; set; }
        public string Item { get; set; }
        public float MRP { get; set; }
        public int qty { get; set; }
        public float Rate { get; set; }
        public float Scheme { get; set; }
        public float Amt { get; set; }
    }
}
