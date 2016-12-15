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
            total += (cart.qty * cart.subTotal);
            totalItemsInCart += cart.qty;
        }
        public List<ShoppingCart> getItems()
        {
            return catDetails;
        }

        //public   double getTotal(double price,int qty)
        //{

        //    total = price * qty;
        //    return total;
        //}
        public void incrementQuantity(int index)
        {
            ShoppingCart item = catDetails[index];
            item.qty++;
            item.total = item.subTotal * item.qty;
            total += item.subTotal;
            
            catDetails[index] = item;
        }
    }
}