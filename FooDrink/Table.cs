using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    public enum State
    {
        Empty,
        Reserved,
        Busy
    }
    class Table
    {
        public Dictionary<Product, int> TableItems;
        public int TableNumber { get; set; }
        public State TableState { get; set; }
        public Person PersonID { get; set; }
        public Table() { }
        public Table(int TableNumber,Person PersonID)
        {
            this.TableNumber = TableNumber;
            this.PersonID = PersonID;
        }
        public bool IsReserved()
        {
            return TableState == State.Reserved;
        }
        public bool IsEmpty()
        {
            return TableState == State.Empty;
        }
        public void OpenTable(int TableNumber,Person PersonID)
        {
            if (IsReserved())
            {
                Console.WriteLine("This Table is reserved.\n would you open it? [y/n]");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'y')
                {
                    this.TableNumber = TableNumber;
                    this.PersonID = PersonID;
                    this.TableState = State.Busy;
                }
            }
        }
        public void addProducts(Dictionary<Product, int> Items)
        {
            
            foreach (KeyValuePair<Product, int> additionalItem in Items)
            {
                if (TableItems.ContainsKey(additionalItem.Key))
                {
                    TableItems[additionalItem.Key] += additionalItem.Value;
                }
                else
                {
                    TableItems.Add(additionalItem.Key,additionalItem.Value);
                }
            }
        }
        public void CloseTable()
        {
            this.TableItems.Clear();
            this.TableState = State.Empty;
        }
        public bool ReserveTable()
        {
            if (TableState == State.Busy)
                return false;
            else
            {
                TableState = State.Reserved;
                return true;
            }

        }
        public void DeleteItem(Product item,int amount)
        {
            if (TableItems.ContainsKey(item))
            {
                TableItems[item] -= amount;
                if (TableItems[item] <= 0)
                    TableItems.Remove(item);
            }
            else
            {
                Console.WriteLine("This item is not exist");
            }
        }
    }
}
