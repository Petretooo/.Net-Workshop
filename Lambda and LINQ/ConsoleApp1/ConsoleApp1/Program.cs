using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>()
            {
                new Students()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Grade = 4m
                },
                new Students()
                {
                    FirstName = "George",
                    LastName = "Georgiev",
                    Grade = 4.5m
                },
                new Students()
                {
                    FirstName = "John",
                    LastName = "Morgan",
                    Grade = 6.0m
                },
                new Students()
                {
                    FirstName = "Stan",
                    LastName = "Gordon",
                    Grade = 3.4m
                },
                new Students()
                {
                    FirstName = "Robert",
                    LastName = "Spark",
                    Grade = 4.3m
                },
                new Students()
                {
                    FirstName = "Kevin",
                    LastName = "Abraham",
                    Grade = 5.2m
                }
        };



            var filtered = (from s in students
                            where s.Grade > 4.5m
                            select s).ToList();


            Console.WriteLine("Grade > 4,5");
            Console.WriteLine();
            foreach (Students s in filtered)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }



            filtered = students.Where(s => s.Grade < 4.5m)
                                //.Select(s => s)
                                .ToList();

            Console.WriteLine("Grade < 4,5");
            Console.WriteLine();
            foreach (Students s in filtered)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }


            List<string> names = (from s in students
                                  where s.Grade > 4.5m
                                  select s.FirstName).ToList();


            Console.WriteLine("Names: Grade > 4.5");
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
                
            }

            Console.WriteLine("Names: Grade <= 4.5m");
            Console.WriteLine();

            names = students
                .Where(s => s.Grade <= 4.5m)
                .Select(s => s.FirstName)
                .ToList();

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }





        }
    }
}
