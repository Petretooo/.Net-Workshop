using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }


        public Animal(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }


        public virtual void makeSound()
        {
            Console.WriteLine("No sound");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}");
            makeSound();
        }

    }
}
