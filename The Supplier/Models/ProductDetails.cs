using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using The_Supplier.Models;

namespace The_Supplier.Models
{
    public class ProductDetails
    {

   public     List<Product> pro = new List<Product>();
        Product pumpkin = new Product();
        Product peper = new Product();
        Product lettuce = new Product();
        Product betroot = new Product();
        Product banana = new Product();
        Product orange = new Product();
        Product watermelon = new Product();
        Product pawpW = new Product();
        Product tomato = new Product();
        Product potatoes = new Product();
        Product RedApple = new Product();
        Product greenApple = new Product();



        public void info()
        {
            pro.Clear();
            //Pumpkin
            pumpkin.ProdName = "Pumpkin";
            pumpkin.ProdPrice = 12.00;
            pumpkin.Category = "vegetable";
            pro.Add(pumpkin);

            //Peper
            peper.ProdName = "Peper";
            peper.ProdPrice = 8.00;
            peper.Category = "Vegetable";
            pro.Add(peper);


            //lettuce
            lettuce.ProdName = "Lettuce";
            lettuce.ProdPrice = 10.00;
            lettuce.Category = "Vegetable";
            pro.Add(lettuce);

            //betroot
            betroot.ProdName = "Betroot";
            betroot.ProdPrice = 13.00;
            betroot.Category = "Vegetable";
            pro.Add(betroot);

            //banana
            banana.ProdName = "Banana";
            banana.ProdPrice = 20.00;
            banana.Category = "Fruit";
            pro.Add(banana);

            //orange 
            orange.ProdName = "Orange";
            orange.ProdPrice = 30.00;
            orange.Category = "Fruit";
            pro.Add(orange);

            //watermelon
            watermelon.ProdName = "Watermelon";
            watermelon.ProdPrice = 50.00;
            watermelon.Category = "Fruit";
            pro.Add(watermelon);
            //pawpaw
            pawpW.ProdName = "Pawpaw";
            pawpW.ProdPrice = 15.00;
            pawpW.Category = "Fruit";

            //tomato
            tomato.ProdName = "Tomato";
            tomato.ProdPrice = 15.00;
            tomato.Category = "Vegetable";
            pro.Add(tomato);
            //Potatoes

            potatoes.ProdName = "Potato";
            potatoes.ProdPrice = 60.00;
            potatoes.Category = "Vegetable";
            pro.Add(potatoes);
            //Apples
            RedApple.ProdName = "Red Apple";
            RedApple.ProdPrice = 20.00;
            RedApple.Category = "Fruits";
            pro.Add(RedApple);

            greenApple.ProdName = "Green Apple";
            greenApple.ProdPrice = 20.00;
            greenApple.Category = "fruit";
            pro.Add(greenApple);
            

        }
      public Product getinfo(string proName)
        {
            Product filter = null;
            foreach (Product item in pro)
            {
                if (item.ProdID==proName)
                {
                    //filter = proName;
                    //proName = filter;

                }
            }
            return filter;
        }
       

    }
}