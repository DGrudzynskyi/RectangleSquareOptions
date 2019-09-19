using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.AbstractClassInheritance
{
    public abstract class AbstractRectangle
    {
        protected double _length;
        protected double _height;

        public double Area()
        {
            return _length * _height;
        }
    }
}
