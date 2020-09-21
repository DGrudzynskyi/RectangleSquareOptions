using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleSquare.Composition
{
    class ZoomFeature
    {
        private int currentZoom;
        private List<ZoomDecorator> figures;

        public ZoomFeature() {
            this.currentZoom = 1;
            this.figures = new List<ZoomDecorator>();
        }

        public IHaveArea ReceiveFigure(IHaveArea figure) {
            var decoratedFigure = new ZoomDecorator(figure);
            decoratedFigure.Zoom = this.currentZoom;
            this.figures.Add(decoratedFigure);
            return decoratedFigure;
        }

        public void Zoom(int zoomLevel) { 
            foreach(var figure in figures){
                figure.Zoom = zoomLevel;
            }
            this.currentZoom = zoomLevel;
        }
    }
}
