using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Supplier.Models
{
    public class cart
    {
        public List<ShoppingCart> catDetails = new List<ShoppingCart>();

        public void  carts(ShoppingCart cart)
        {
            catDetails.Add(cart);
        }
    }
}