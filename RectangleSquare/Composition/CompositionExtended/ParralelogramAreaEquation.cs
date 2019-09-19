using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition.CompositionExtended
{
    public class ParralelogramAreaEquation : IParralelogramAreaEquation
    {
        public double CalculateArea(double sizeX, double sizeY, double angle)
        {
            return sizeX * sizeY * Math.Sin(angle);
        }
    }
}
