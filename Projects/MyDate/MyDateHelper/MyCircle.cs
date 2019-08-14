using System;
using System.Collections.Generic;
using System.Text;

namespace MyDateHelper
{
    class MyCircle: Shape
    {
        public double radius { get; set; }

        public MyCircle(double radius, string name, string color) : base(name, color)
        {
            this.radius = radius;
        }

        public override double GetPerimeter()
        {
            return  (Math.PI * this.radius * 2);
        }


    }
}
