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

        double total = 0.0;
   
      

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
            List<ShoppingCart> myList = Session["Prof"] as List<ShoppingCart>;



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

            if (Session["Prof"] == null)
            {
                Session["Prof"] = cart;
            }
            bool found = false;
            int indexOfFound = -1;
            for (int i = 0; i < cart.getItems().Count; i++)
            {
                ShoppingCart p = cart.getItems()[i];
                if (p.prodID.Equals(ProdId, StringComparison.Ordinal))
                {
                    found = true;
                    indexOfFound = i;
                    


                    
                   break; 
                }
            }


                if (found)
                {
                    ShoppingCart product = new ShoppingCart();
                    cart.incrementQuantity(indexOfFound);

                   
                }
                else
                {
                    
                    ShoppingCart product = new ShoppingCart();

                    Product item = prodetails.getinfo(ProdId);
                    product.prodID = item.ProdID;
                    product.productName = item.ProdName;
                    product.qty = 1;
                    product.subTotal = item.ProdPrice;
                  
                    cart.carts(product);

                    ViewBag.cart = cart.catDetails.Count();

                    Session["Prof"] = cart.catDetails;
                    total += (product.qty * item.ProdPrice);

                }
               // orderTotal += (item.Count * item.Product.Price);
               
           

            return View("Product");
        }

  
      
     
        public ActionResult Delete(string prodId)
        {
            List<ShoppingCart> myList = Session["Prof"] as List<ShoppingCart>;
            var item = myList.SingleOrDefault(x => x.prodID == prodId);
            if (item != null)

                //total=total -Convert.ToDouble(item.subTotal);
                myList.Remove(item);
           // else
            //{
               // total =  product.qty* Convert.ToDouble(item.subTotal);
                //Session["total"] = total;
            //}
            return RedirectToAction("Cart", "Home");
        }




    }
}