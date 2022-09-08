using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    public enum Department
    {
        Bar,
        Kitchen,
        Casher
    }
    class Order
    {
        public List<KeyValuePair<Product, int>> OrderItems;
        public int OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public string PersonID { get; set; }
        public Department Destination { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Order() { }
        public Order(int OrderNumber, int TableNumber, string WaiterID, Department Destination)
        {
            this.OrderNumber = OrderNumber;
            this.TableNumber = TableNumber;
            this.PersonID = WaiterID;
            this.Destination = Destination;
            this.OrderDateTime = DateTime.Now;
        }
        public void ShowOrder()
        {
            if (OrderItems.Count == 0)
            {
                Console.WriteLine("This Invoice is Empty!.");
                return;
            }
            ShowDateTime();
            ShowOrderNumber();
            ShowTableNumber();
            ShowItems();
           
        }
        public void ShowItems()
        {
            Console.WriteLine(" Item  Number  Name");
            for (int i = 1; i <= OrderItems.Count; i++)
            {
                string item = Convert.ToString(i);
                Console.Write(' ' + item);
                for (int j = item.Length; j < 6; j++)
                {
                    Console.Write(' ');
                }
                item = Convert.ToString(OrderItems[i - 1].Value);
                Console.Write(item);
                for (int j = item.Length; j < 8; j++)
                {
                    Console.Write(' ');
                }
                item = OrderItems[i - 1].Key.ProductName;
                Console.Write(item + '\n');
            }
        }
        public void ShowOrderNumber()
        {
            Console.WriteLine($"Inovice Number: {this.OrderNumber}");
        }
        public void ShowTableNumber()
        {
            Console.WriteLine($"Table: {this.TableNumber}");
        }
        public void ShowDateTime()
        {
            this.OrderDateTime = DateTime.Now;
            Console.WriteLine($"Date: { this.OrderDateTime.Year}\\{ this.OrderDateTime.Month}\\{ this.OrderDateTime.Day}\n" +
                $"Time:  { this.OrderDateTime.Hour}:{ this.OrderDateTime.Minute}");
        }
    }
}
