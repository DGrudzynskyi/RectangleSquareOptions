using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public class Rectangle : IHaveArea //, ICanBeDrawn
    {
        private IRectangleAreaEquation _areaEquation;

        public Rectangle(
            double length, 
            double height, 
            IRectangleAreaEquation areaEquation = null) {
            // ICanBeDrawn

            Length = length;
            Height = height;
            _areaEquation = areaEquation ?? new RectangleAreaEquation();

        }

        public double Length { get; set; }

        public double Height { get; set; }

        public double Area()
        {
            return _areaEquation.CalculateArea(Length, Height);
        }

        /*
         public void Draw(Graphics g){
             _drawStrategy.draw(g);
         }
         */
    }
}
