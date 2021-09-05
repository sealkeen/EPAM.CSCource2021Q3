using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class RenderArea : Rectangle
    {
        private List<Shape> _elements;
        private const int _defaultWidth = 71;
        private const int _defaultHeight = 30;
        private Char[,] _pixels;
        public RenderArea(int x, int y)
        {
            Width = x >= 0? x :_defaultWidth;
            Height = y >= 0 ? y : _defaultHeight;
            _pixels = new Char[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int k = 0; k < Height; k++) {
                    _pixels[i, k] = ' ';
                }
            }
        }
        private void DrawArea()
        {
            foreach (var model in _elements) {
                model.Draw();
            }
        }
        public bool AddElement(Shape element)
        {
            if (element.ElementIsOutOfArea(this)) {
                return false;
            }
            _elements.Add(element);
            return true;
        }
    }
}
