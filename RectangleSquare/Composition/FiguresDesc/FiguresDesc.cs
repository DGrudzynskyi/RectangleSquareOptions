using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition.FiguresDesc
{
    class FiguresDesc
    {
        private List<IHaveArea> figures = new List<IHaveArea>();
        private ZoomFeature zoom;

        public void Run() {
            this.zoom = new ZoomFeature();

            var processCommands = true;

            while (processCommands) {
                processCommands = ReceiveCommand();
            }
        }

        
        /// <summary>
        /// функция которая читает команды И отрабатывает каждую из них.
        /// В соответствии с принципом OpenClosed каждая из комманд должна отрабатываться независимо 
        /// а здесь нужна фабрика данных отработчиков вместо свича
        /// </summary>
        /// <returns></returns>
        private bool ReceiveCommand() {
            Console.WriteLine("Enter command.('S'=enter square, 'R'=rectange,'Z'=zoom all figures,'P'=print arear, 'Q'=stop this!");

            var newLine = Console.ReadLine().ToLowerInvariant();
            IHaveArea figure = null;
            switch (newLine) {
                // обрабатываем ввод квадрата
                case "s":
                    Console.WriteLine("enter size");
                    var size = int.Parse(Console.ReadLine());

                    var square = new Square(new RectangleAreaEquation());
                    square.SideSize = size;

                    figure = square;
                    break;
                // обрабатываем ввод прямоугольника
                case "r":
                    Console.WriteLine("enter X size");
                    var xSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Y size");
                    var ySize = int.Parse(Console.ReadLine());

                    var rect = new Rectangle(new RectangleAreaEquation());
                    rect.Length = xSize;
                    rect.Height = ySize;

                    figure = rect;
                    break;
                // обрабатываем зум
                case "z":
                    Console.WriteLine("enter zoom factor");
                    var zoom = int.Parse(Console.ReadLine());
                    this.zoom.Zoom(zoom); // >_< never do this boys
                    break;
                // выводим текущуб общую площадь
                case "p":
                    Console.WriteLine("total consumed area:");
                    var totalArea = 0d;
                    foreach(var fig in this.figures)
                    {
                        totalArea += fig.Area();
                    }
                    Console.WriteLine(totalArea);
                    break;
                // выйти из программы
                case "q":
                    return false;
            }

            // если фигура была сформирована текущей командой - завернуть её в Zoom фичу и добавить в список фигур
            if (figure != null)
            {
                var zoomableFigure = this.zoom.ReceiveFigure(figure);
                figures.Add(zoomableFigure);
            }

            return true;
        }
    }
}
