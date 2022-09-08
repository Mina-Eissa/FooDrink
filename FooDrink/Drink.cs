using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    class Drink:Product
    {
        public Drink() { }
        public Drink(string ProductName, string ProductID, double ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductID = ProductID;
            this.ProductPrice = ProductPrice;
            this.ProductCategeory = Categeory.Drink;
        }
    }
}
