using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class RenderArea
    {
        private List<Shape> _models;
        private const int _defaultWidth = 640;
        private const int _defaultHeight = 480;
        public int Width { get; set; }
        public int Height { get; set; }
        private Color[,] _pixels;
        public RenderArea(int x, int y)
        {
            Width = x >= 0? x :_defaultWidth;
            Height = y >= 0 ? y : _defaultHeight;
            _pixels = new Color[Width, Height];
        }
        private void DrawArea()
        {
            foreach (var model in _models) {
                model.Draw();
            }
        }
    }
}
