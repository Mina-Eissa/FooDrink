using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    class Invoice
    {
         
         public Dictionary<Product,int> InvoiceItems;
        public int InvoiceNumber { get; set; }
        public int TableNumber { get; set; }
        public string PersonID { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public Invoice() {
            this.Discount = 0;
        }
        public Invoice(int InvoiceNumber,int TableNumber,string WaiterID, Dictionary<Product, int> Items)
        {
            this.InvoiceNumber = InvoiceNumber;
            this.TableNumber = TableNumber;
            this.PersonID = WaiterID;
            this.InvoiceItems = Items;
            this.Discount = 0;
        }
        public void CalculateTotal()
        {
            Total = 0;
            foreach(KeyValuePair<Product, int> Item in InvoiceItems)
            {
                Total += Item.Key.ProductPrice * Item.Value;
            }
            Total -= Total * (Discount / 100);
        }
        public void ShowInvoice()
        {
            if (InvoiceItems.Count == 0)
            {
                Console.WriteLine("This Invoice is Empty!.");
                return;
            }
            ShowDateTime();
            ShowInvoiceNumber();
            ShowTableNumber();
            ShowItems();
            ShowTotal();
            ShowDiscount();
        }
        public void ShowInvoiceNumber()
        {
            Console.WriteLine($"Inovice Number: {this.InvoiceNumber}");
        }
        public void ShowItems()
        {
            Console.WriteLine(" Item  Number  Name");
            int i = 1;
            foreach(KeyValuePair<Product,int> Item in InvoiceItems)
            {
                string item = Convert.ToString(i++);
                Console.Write(' ' + item);
                for (int j = item.Length; j < 6; j++)
                {
                    Console.Write(' ');
                }
                item = Convert.ToString(Item.Value);
                Console.Write(item);
                for (int j = item.Length; j < 8; j++)
                {
                    Console.Write(' ');
                }
                item = Item.Key.ProductName;
                Console.Write(item + '\n');
            }
        }
        public void ShowTableNumber()
        {
            Console.WriteLine($"Table: {this.TableNumber}");
        }
        public void ShowDateTime()
        {
            this.InvoiceDateTime = DateTime.Now;
            Console.WriteLine($"Date: { this.InvoiceDateTime.Year}\\{ this.InvoiceDateTime.Month}\\{ this.InvoiceDateTime.Day}\n" +
                $"Time:  { this.InvoiceDateTime.Hour}:{ this.InvoiceDateTime.Minute}");
        }
        public void ShowTotal()
        {
            CalculateTotal();
            Console.WriteLine($"Total : {this.Total} $");
        }
        public void ShowDiscount()
        {
            Console.WriteLine($"Discount : {this.Discount} %");
        }
        public void setDiscount(double Discount)
        {
            this.Discount = Discount;
        }
    }
}
