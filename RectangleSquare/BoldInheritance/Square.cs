using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.BoldInheritance
{
    public class Square : Rectangle
    {
        private double _length;
        private double _height;

        public Square(double side) : base(side, side)
        {
        }

        public new double Length
        {
            get => _length;
            set => SetSize(value);
        }

        public new double Height
        {
            get => _height;
            set => SetSize(value);
        }

        public void SetSize(double size) {
            _length = size;
            _height = size;
        }
    }
}
