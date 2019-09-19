using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.InterfaceInheritance
{
    public class Ellipse : IHaveArea
    {
        public Ellipse(double radiusHorizontal, double radiusVertical) {
            RadiusHorizontal = radiusHorizontal;
            RadiusVertical = RadiusVertical;
        }

        public double RadiusHorizontal { get; set; }

        public double RadiusVertical { get; set; }

        public double Area() {
            return Math.PI * RadiusVertical * RadiusHorizontal;
        }
    }
}
