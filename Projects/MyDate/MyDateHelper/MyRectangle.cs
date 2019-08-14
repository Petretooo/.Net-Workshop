using System;
using System.Collections.Generic;
using System.Text;

namespace MyDateHelper
{
    class MyRectangle: Shape
    {
        public double a { get; set; }
        public double b { get; set; }

        public MyRectangle(double a, double b, string name, string color) : base(name, color)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetPerimeter()
        {
            return (a+b) * 2;
        }
    }
}
