using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Dog : Animal
    {


        public Dog(string name, string color) : base(name, color)
        {
            
        }


        public override void makeSound()
        {
            Console.WriteLine("What's up Nigga");
        }

    }
}
