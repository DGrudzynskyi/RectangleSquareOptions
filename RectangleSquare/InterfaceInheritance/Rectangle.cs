using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.InterfaceInheritance
{
    public class Rectangle : IHaveArea
    {
        public Rectangle(double length,double height) {
            Length = length;
            Height = height;
        }

        public double Length { get; set; }

        public double Height { get; set; }

        public double Area()
        {
            return Length * Height;
        }
    }
}
