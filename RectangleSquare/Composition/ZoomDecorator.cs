using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public class ZoomDecorator : IHaveArea
    {
        IHaveArea _innerShape;

        public ZoomDecorator(IHaveArea innerShape) {
            _innerShape = innerShape;
        }

        public double Zoom { get; set; } 

        public double Area() {
            return _innerShape.Area() * Zoom;
        }
    }
}
