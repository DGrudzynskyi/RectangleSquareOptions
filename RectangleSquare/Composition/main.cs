using RectangleSquare.Composition.CompositionExtended;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public static class Main
    {
        public static void squareRectangleParralelogram() {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(new RectangleAreaEquation()));
            figures.Add(new Rectangle(new RectangleAreaEquation()));
            figures.Add(new Parralelogram(new ParralelogramAreaEquation()));

            // ситуация когда уравнение для паралелограма было известно заранее 
            // мы адаптируем его
            var rectangleAreaEquation = new ParralelogramToRectangleAreaEquationAdapter(new ParralelogramAreaEquation());
            figures.Add(new Square(rectangleAreaEquation));
        }

        public static void withNaiveZoom()
        {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(new RectangleAreaEquation()));
            figures.Add(new Rectangle(new RectangleAreaEquation()));
            figures.Add(new Parralelogram(new ParralelogramAreaEquation()));

            var squareCanBeZoomed = new ZoomDecorator(new Square(new RectangleAreaEquation()));
            figures.Add(squareCanBeZoomed);

            // использование декоратора (наивный пример) 
            squareCanBeZoomed.Zoom = 5;
        }

        public static void zoomedFigures()
        {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(new RectangleAreaEquation()));
            figures.Add(new Rectangle(new RectangleAreaEquation()));
            figures.Add(new Parralelogram(new ParralelogramAreaEquation()));

            var zoomReferences = new List<ZoomDecorator>();

            foreach (var figure in figures) {
                zoomReferences.Add(new ZoomDecorator(figure));
            }

            foreach (var figure in zoomReferences) {
                figure.Zoom = 10; // любое число
            }
        }
    }
}
