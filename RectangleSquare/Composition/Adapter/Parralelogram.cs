using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition.CompositionExtended
{
    public class Parralelogram : IHaveArea
    {
        private IParralelogramAreaEquation _areaEquation;
        public Parralelogram(IParralelogramAreaEquation areaEquation) {
            _areaEquation = areaEquation ?? new ParralelogramAreaEquation();
        }

        public double SizeX { get; set; }

        public double SizeY { get; set; }

        public double Angle { get; set; }

        public double Area()
        {
            return _areaEquation.CalculateArea(SizeX, SizeY, Angle);
        }
    }
}
