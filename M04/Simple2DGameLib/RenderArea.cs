using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class RenderArea : Rectangle
    {
        private List<Shape> _models;
        private const int _defaultWidth = 71;
        private const int _defaultHeight = 30;
        private Char[,] _pixels;
        public RenderArea(int x, int y)
        {
            Width = x >= 0? x :_defaultWidth;
            Height = y >= 0 ? y : _defaultHeight;
            _pixels = new Char[Width, Height];
        }
        private void DrawArea()
        {
            foreach (var model in _models) {
                model.Draw();
            }
        }
    }
}
