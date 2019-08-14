using System;
using System.Collections.Generic;
using System.Text;

namespace MyDateHelper
{


   abstract class Shape
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Shape(string name, string color)
        {
            this.Color = color;
            this.Name = name;
        }

        abstract public double GetPerimeter();


    }
}
