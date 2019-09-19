using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.InterfaceInheritance
{
    public class Square : IHaveArea
    {
        public Square(double side)
        {
            SideSize = side;
        }

        public double SideSize { get; set; }

        public double Area() {
            return SideSize * SideSize;
        }
    }
}
