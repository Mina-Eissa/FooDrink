using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    class Food:Product
    {
        public Food() { }
        public Food(string ProductName,string ProductID ,double ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductID = ProductID;
            this.ProductPrice = ProductPrice;
            this.ProductCategeory = Categeory.Food;
        }
    }
}
