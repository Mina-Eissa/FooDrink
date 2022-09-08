using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    public enum Categeory
    {
        Food,
        Drink
    }
    public abstract class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public Categeory ProductCategeory { get; set; }
    }
}
