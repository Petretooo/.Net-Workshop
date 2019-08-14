using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Cat: Animal
    {
        public Cat(string name, string color) : base(name,color)
        {
           
        }

        public override void makeSound()
        {
            Console.WriteLine("Myau");
        }

    }
}
