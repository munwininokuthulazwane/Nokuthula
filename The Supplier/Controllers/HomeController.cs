using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Supplier.Models;

namespace The_Supplier.Controllers
{
    public class HomeController : Controller
    {
        public static ProductDetails prodetails = new ProductDetails();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Catalogue()
        {
            return View();
        }
        public ActionResult ProductDetails(string ProdID)
        {
            prodetails.info();
            return View(prodetails.getinfo(ProdID));
        }
        public ActionResult fullDetails()
        {
            prodetails.info();
            return View(prodetails.pro);
        }
    }
}