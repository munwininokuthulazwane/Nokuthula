using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using The_Supplier.Models;

namespace The_Supplier.Models
{
    public class Product
    {
        //private string id;

        //public Product(string id)
        //{
        //    // TODO: Complete member initialization
        //    this.id = id;
        //}
        public string ProdID { get; set; }
        public int ProdNum { get; set; }
        public string ProdName { get; set; }
        public double ProdPrice { get; set; }
        public string Category { get; set; }



    }
}