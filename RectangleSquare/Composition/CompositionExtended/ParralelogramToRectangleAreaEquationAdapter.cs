using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition.CompositionExtended
{
    public class ParralelogramToRectangleAreaEquationAdapter : IRectangleAreaEquation
    {
        IParralelogramAreaEquation _areaEquation;

        public ParralelogramToRectangleAreaEquationAdapter(IParralelogramAreaEquation areaEquation) {
            _areaEquation = areaEquation ?? new ParralelogramAreaEquation();
        }

        public double CalculateArea(double length, double width)
        {
            return _areaEquation.CalculateArea(length, width, Math.PI / 2);
        }
    }
}
