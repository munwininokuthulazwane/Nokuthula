using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Supplier.Models
{
    public class cart
    {
        public List<ShoppingCart> catDetails = new List<ShoppingCart>();
        public double total = 0.0;
        public int totalItemsInCart = 0;

        public void  carts(ShoppingCart cart)
        {
            catDetails.Add(cart);
            total += cart.subTotal;
            totalItemsInCart += cart.qty;
        }
        public List<ShoppingCart> getItems()
        {
            return catDetails;
        }

        public   double getTotal()
        {
            return total;
        }
        public void incrementQuantity(int index)
        {
            catDetails[index].qty++;
            total += catDetails[index].subTotal;
            totalItemsInCart++;
        }
    }
}