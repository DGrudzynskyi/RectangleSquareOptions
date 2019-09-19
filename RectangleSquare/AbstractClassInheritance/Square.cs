using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.AbstractClassInheritance
{
    public class Square : AbstractRectangle
    {
        public Square(double side)
        {
            SetSize(side);
        }

        public void SetSize(double size) {
            _length = size;
            _height = size;
        }
    }
}
