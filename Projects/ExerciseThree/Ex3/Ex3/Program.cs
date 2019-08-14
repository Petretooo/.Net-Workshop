using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sharo", "Brown");
            Cat cat = new Cat("Maca", "Black");
            Animal cat2 = new Cat("Maca2", "White");

            dog.PrintInfo();
            cat.PrintInfo();
            cat2.PrintInfo();
            dog.makeSound();
            cat.makeSound();
            cat2.makeSound();


            Animal animal = new Animal("Human", "Black");
            animal.PrintInfo();
            animal.makeSound();

        }
    }
}
