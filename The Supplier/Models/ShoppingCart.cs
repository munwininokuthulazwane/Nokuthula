﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Supplier.Models
{
    public class ShoppingCart
    {
        public string productName { get; set; }
        public string productID { get; set; }
        public int qty { get; set; }
        public double subTotal { get; set; }
        public decimal total { get; set; }

       
    }
}