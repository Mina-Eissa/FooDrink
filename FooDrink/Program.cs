using System;
using System.Collections.Generic;
namespace FooDrink
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, int> Items = new Dictionary<Product, int>();
            Items.Add(new Food("Pizza", "F1", 20), 2);
            Items.Add(new Food("Cripe", "F2", 35), 3);
            Items.Add(new Food("Sandwich", "F3", 22.5), 7);
            Items.Add(new Drink("tea", "D1", 5), 5);
            Items.Add(new Drink("Orange Juice", "D2", 22), 5);
            Items.Add(new Drink("Ice Coffee", "D3", 30), 7);
            Items.Add(new Drink("Milkshake", "D4", 25), 15);
            Invoice test = new Invoice(1, 1, "Mina12", Items);
            test.setDiscount(1);
            test.ShowInvoice();
            
        }
    }
}
