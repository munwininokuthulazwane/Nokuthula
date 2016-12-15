using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Supplier.Models
{
    public class ShoppingCart
    {
        public string productName { get; set; }
        public string prodID { get; set; }
        public int qty { get; set; }
        public double subTotal { get; set; }
        public double total { get; set; }

       
    }
}