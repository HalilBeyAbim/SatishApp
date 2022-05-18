using System;

namespace SatishApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Tie = new Product("Tie", 30.5, 300);
            Product Shoes = new Product("Shoes", 199.0, 500);
            Product Pant = new Product("Pant", 250.99, 500);
            Product Shirt = new Product("Shirt", 150.5, 1000);
            Console.WriteLine("\nDamat Tween Menu");
            Order or = new Order();
            int selection;
            int selection2;
            do
            {
                Console.WriteLine("\nPlease choose selection");
                Console.WriteLine("1 - Tie");
                Console.WriteLine("2 - Shoes");
                Console.WriteLine("3 - Pant");
                Console.WriteLine("4- Shirt");
                Console.WriteLine("0 - Shoping end");
                selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please enter the number of products");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(Tie, selection2);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the number of products");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(Shoes, selection2);
                        break;
                    case 3:
                        Console.WriteLine("Please enter the number of products");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(Pant, selection2);
                        break;
                    case 4:
                        Console.WriteLine("Please enter the number of products");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(Shirt, selection2);
                        break;
                    case 0:
                        or.Discount();
                        break;


                    default:
                        break;
                }


            } while (selection!=0);
        }
    
    }
}
