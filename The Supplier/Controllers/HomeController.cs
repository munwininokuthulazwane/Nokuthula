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
        static cart cart = new cart();
         public ShoppingCart shoping = new ShoppingCart();
         Product[] prod = new Product[50];
        static int record = 0;

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

        public ActionResult shoppingCart()
        {
            return View();
        }
        public ActionResult Cart()
        {
            List<ShoppingCart> myList = Session["products"] as List<ShoppingCart>;



            return View(myList);
        }
        public ActionResult ProductDetails(string ProdID)
        {
            prodetails.info();
            return View(prodetails.getinfo(ProdID));
        }
        public ActionResult fullDetails()
        {            prodetails.info();

            return View(prodetails.pro);
        }
        public ActionResult addtocart(string ProdId)
        {


            prod[record] = prodetails.getinfo(ProdId);

            shoping.productName = prod[record].ProdName;
            shoping.qty = 1;
            shoping.subTotal = prod[record].ProdPrice;
            shoping.total = 0;

            
 
                // Session["cart"] = cart;
                //shoping.qty = 1;
                cart.carts(shoping);

                ViewBag.cart = cart.catDetails.Count();

                Session["products"] = cart.catDetails;
                //ViewBag.shopping = addtocart(ProdId);
                record++;
            



            return View("Product");

        }




    }
}