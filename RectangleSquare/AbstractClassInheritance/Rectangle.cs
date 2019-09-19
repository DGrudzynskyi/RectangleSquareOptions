using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.AbstractClassInheritance
{
    public class Rectangle : AbstractRectangle
    {
        public Rectangle(double length,double height) {
            _length = length;
            _height = height;
        }

        public double Length { get => _length; set => _length = value; }

        public double Height { get => _height; set => _height = value; }
    }
}
