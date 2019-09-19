using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.InterfaceInheritance
{
    public class Circle : IHaveArea
    {
        public Circle(double radius) {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
