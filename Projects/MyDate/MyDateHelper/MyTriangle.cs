using System;
using System.Collections.Generic;
using System.Text;

namespace MyDateHelper
{
    class MyTriangle: Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public MyTriangle(double a, double b, double c, string name, string color) : base(name, color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }



        public override double GetPerimeter()
        {
            return a + b + c;
        }
    }
}
