using System;
using ConsoleApp.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the number of products :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Product #{i} data :");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char state = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Price");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                if (state == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (state == 'u')
                {
                    Console.WriteLine("Manufacture date: (dd/MM/yyyy) ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                    
                }
                else 
                {
                    Console.WriteLine("Customs free : $ ");
                    double customsFree = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFree));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS : ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
