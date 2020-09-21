using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.BoldInheritance
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public override double Length
        {
            get => base.Length;
            set {
                if (value < 4 || value > 6)
                {
                    throw new ArgumentOutOfRangeException();
                }
                SetSize(value);
            }
        }

        public override double Height
        {
            get => base.Height;
            set => SetSize(value);
        }

        public void SetSize(double size) {
            base.Length = size;
            base.Height = size;
        }
    }
}
