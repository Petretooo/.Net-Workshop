using System;

namespace MyDateHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle c = new MyCircle(3, "A", "WHITE");
            MyTriangle b = new MyTriangle(3,5,6 ,"B", "WHITE");
            MyRectangle d = new MyRectangle(3, 5, "D", "WHITE");

            Console.WriteLine(c.GetPerimeter());
            Console.WriteLine(b.GetPerimeter());
            Console.WriteLine(d.GetPerimeter());


        }
    }
}
