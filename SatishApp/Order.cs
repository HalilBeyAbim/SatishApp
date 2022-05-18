using System;
using System.Collections.Generic;
using System.Text;

namespace SatishApp
{
    public delegate void Convert(double azn);
    class Order
    {
        public double Totalprice;
        public void Sale(Product product, int count)
        {

            double a = product.Price * count;
            Totalprice += a;
            Console.WriteLine($"TOTAL- { Math.Round(Totalprice, 2)} AZN");
        }

        public void Discount()
        {
            Predicate<double> nodiscount = Totalprice => Totalprice <= 100;
            Predicate<double> discount10 = Totalprice => Totalprice > 100 && Totalprice < 200;
            Predicate<double> discount20 = Totalprice => Totalprice >= 200;
            if (nodiscount(Totalprice))
            {
                Console.WriteLine($"Not have discount -  {Math.Round(Totalprice, 2)}");
            }
            if (discount10(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 0.1;
                Console.WriteLine($" 10 % discount -  {Math.Round(Totalprice, 2)}");
            }
            if (discount20(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 0.2;
                Console.WriteLine($" 20 % discount -  {Math.Round(Totalprice, 2)}");
            }

        }
    }
}
