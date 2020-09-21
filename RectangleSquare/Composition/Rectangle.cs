using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public class Rectangle : IHaveArea
    {
        private IRectangleAreaEquation _areaEquation;

        public Rectangle(
            IRectangleAreaEquation areaEquation = null) {

            _areaEquation = areaEquation ?? new RectangleAreaEquation();

        }

        public double Length { get; set; }

        public double Height { get; set; }

        public double Area()
        {
            return _areaEquation.CalculateArea(Length, Height);
        }
    }
}
