using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 3, 9, 24, 25, 13, 2 };
            int[] indx = new int[] { 1,1,3,2,5,4,4};
            var r = data
                .OrderBy(o => o % 3)
                .ThenBy(o => o / 5)
                .Last();

            Console.WriteLine(r);


        }
    }
}
