using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Product
    {

        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }


        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;

        }


        public override string ToString()
        {
            return $"\nName: {name}" +
                   $"\nPrice: {price}" +
                   $"Amount: {amount}"; 
        }

    }
}
