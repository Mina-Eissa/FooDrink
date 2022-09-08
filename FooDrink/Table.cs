using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    

    class Table
    {
        public List<KeyValuePair<Product, int>> TableItems;
        public int TableNumber { get; set; }
        public bool TableState { get; set; }
        public string WaiterID { get; set; }
        private int FindProductNameByLower_Bound(List<KeyValuePair<Product, int>> L, Product val)
        {
            if (L[L.Count - 1].Key.ProductName.CompareTo(val.ProductName) > 0)
                return L.Count;
            int Left = 0, Right = L.Count, ans = 0;
            while (Left <= Right)
            {
                int Mid = (Left + Right) >> 1;
                int CompareVal = L[Mid].Key.ProductName.CompareTo(val.ProductName);
                if (CompareVal >= 0)
                {
                    Right = Mid - 1;
                    ans = Mid;
                }
                else
                {
                    Left = Mid + 1;
                }
            }
            return ans;
        }

    }
}
