using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public class Square : IHaveArea
    {
        private IRectangleAreaEquation _areaEquation;

        public Square(double sideSize, IRectangleAreaEquation areaEquation = null)
        {
            SideSize = sideSize;
            _areaEquation = areaEquation ?? new RectangleAreaEquation();
        }

        public double SideSize { get; set; }

        public double Area()
        {
            return _areaEquation.CalculateArea(SideSize, SideSize);
        }
    }
}

