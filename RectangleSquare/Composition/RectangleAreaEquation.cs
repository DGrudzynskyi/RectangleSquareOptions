using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public class RectangleAreaEquation : IRectangleAreaEquation
    {
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
