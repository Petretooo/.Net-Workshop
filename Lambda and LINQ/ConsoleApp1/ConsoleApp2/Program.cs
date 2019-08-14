using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n1.Add Product" +
                              $"\n2.Delete Product" +
                              $"\n3.Get all products where amount == 0" +
                              $"\n4.Get sum of all products prices" +
                              $"\n5.Print all" +
                              $"0.Exit");

            int digit = int.Parse(Console.ReadLine());



            List<Product> products = new List<Product>();


            while (digit != 0)
            {
                if (digit == 1)
                {
                    string name = Console.ReadLine();
                    double price = double.Parse(Console.ReadLine());
                    int amount = int.Parse(Console.ReadLine());
                    Product p = new Product(name, price, amount);
                    products.Add(p);

                }
                else if (digit == 2)
                {

                    string deleteName = Console.ReadLine();

                    var d = (from s in products
                             where s.name.Equals(deleteName)
                             select s).FirstOrDefault();
                    if (products.Contains(d))
                    {
                        products.Remove(d);
                    }


                }
                else if (digit == 3)
                {
                    var filtered = products.Where(s => s.amount == 0)
                                        .ToList();

                    Console.WriteLine("Amount == 0");
                    Console.WriteLine();
                    foreach (Product s in filtered)
                    {
                        Console.WriteLine(s);
                        Console.WriteLine();
                    }

                }
                else if (digit == 4)
                {
                    var filtered = (from s in products
                                   select s.amount * s.price).ToList();

                    foreach (double s1 in filtered)
                    {
                        Console.WriteLine(s1);
                    }

                }
                else if(digit == 5)
                {
                    products.ForEach(i => Console.WriteLine(i));
                }

                Console.WriteLine($"\n1.Add Product" +
                  $"\n2.Delete Product" +
                  $"\n3.Get all products where amount == 0" +
                  $"\n4.Get sum of all products prices" +
                  $"\n5.Print all" +
                  $"0.Exit");

                digit = int.Parse(Console.ReadLine());


            }
        }
    }
}
