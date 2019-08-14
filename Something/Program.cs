using System;
using System.Collections.Generic;
using System.Linq;

namespace Something
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            #region my first reagion
            Class1 c = new Class1(5);
            c.MyProp = "Hello!";
            Console.WriteLine($"i = {c.i}, MyProp = {c.MyProp}");
            #endregion
            */
            /*

            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine($"myList[1] = {myList[1]}");
            Console.WriteLine($"myList[2] = {myList[2]}");
            Console.WriteLine($"myList.count = {myList.Count}");
            myList.Remove(2);
            myList.RemoveAt(0);
            Console.WriteLine($"myList.count = {myList.Count}");
            Console.WriteLine($"myList[0] = {myList[0]}");
            */


            MyList a = new MyList();

            a.add(5);
            a.add(10);
            a.add(10);
            a.add(10);
            a.add(10);
            a.add(10);
            a.add(10);
            a.add(10);


            a.AtIndex(0);
            a.printAll();

        }
    }
}