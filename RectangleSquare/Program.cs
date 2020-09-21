using RectangleSquare.BoldInheritance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var desc = new Composition.FiguresDesc.FiguresDesc();
            desc.Run();

            /*
             * немного о ковариантности
             * 
            // присваивание ковариантно
            var square = new Square(4);
            Rectangle rect = square;

            // присваивание не может быть контрвариантно
            var rect2 = new Rectangle(4,2);
            Square square2 = rect2;
            // потому что у родительского класса нет метода SetSize, если бы было контрвариантно - получили бы ошибку рантайма
            square2.SetSize(4);

            IEnumerable<Square> squareEnum = new List<Square>();
            IEnumerable<Rectangle> rectEnum = squareEnum;

            List<Square> squareList = new List<Square>();
            List<Rectangle> rectList = squareList;

            Action<Rectangle> rectAct = (Rectangle rect) =>
            {
            };

            Action<Square> tt = rectAct;
            */
        }
    }
}
