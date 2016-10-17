using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Supplier.Models;




namespace The_Supplier.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product prod = new Product()
            {
                ProdID = "",
                ProdName = "",
                ProdPrice =0.0,
                Category = ""
            };

            return View();
        }
        
    }
}