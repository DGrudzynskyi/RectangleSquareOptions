using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.BoldInheritance
{
    public class Rectangle
    {
        private double _length;
        private double _height;

        public Rectangle(double length,double height) {
            _length = length;
            _height = height;
        }

        public virtual double Length { get => _length; set {
                if (value < 0 || value > 10) {
                    throw new ArgumentOutOfRangeException();
                }
                _length = value; 
            } 
        }

        public virtual double Height { get => _height; set => _height = value; }

        public double Area()
        {
            return _length * _height;
        }
    }
}
