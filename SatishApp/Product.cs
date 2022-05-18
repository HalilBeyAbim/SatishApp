using System;
using System.Collections.Generic;
using System.Text;

namespace SatishApp
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;

        }
    }
}
