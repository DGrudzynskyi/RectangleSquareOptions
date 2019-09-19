using RectangleSquare.Composition.CompositionExtended;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    public static class Main
    {
        public static void main() {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(4, new RectangleAreaEquation()));
            figures.Add(new Rectangle(4, 5, new RectangleAreaEquation()));
            figures.Add(new Parralelogram(new ParralelogramAreaEquation()));

            // ситуация когда уравнение для паралелограма было известно заранее 
            // мы адаптируем его
            var rectangleAreaEquation = new ParralelogramToRectangleAreaEquationAdapter(new ParralelogramAreaEquation());
            figures.Add(new Square(4, rectangleAreaEquation));
        }

        public static void mainWithNaiveZoom()
        {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(4, new RectangleAreaEquation()));
            figures.Add(new Rectangle(4, 5, new RectangleAreaEquation()));
            figures.Add(new Parralelogram(new ParralelogramAreaEquation()));

            var squareCanBeZoomed = new ZoomDecorator(new Square(4, new RectangleAreaEquation()));
            figures.Add(squareCanBeZoomed);

            // использование декоратора (наивный пример) 
            squareCanBeZoomed.Zoom = 5;
        }

        public static void sceneWithNaiveZoom()
        {
            var figures = new List<IHaveArea>();

            figures.Add(new Square(4, new RectangleAreaEquation()));
            figures.Add(new Rectangle(4, 5, new RectangleAreaEquation()));
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
