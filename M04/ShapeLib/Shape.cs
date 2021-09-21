using System;
using System.Drawing;

namespace ShapeLib
{
    public abstract class Shape
    {
        protected bool disposedValue;
        public char[,] Pixels { get; set; }
        public int Height => Pixels.GetLength(0);
        public int Width => Pixels.GetLength(1);
        public Shape()
        {
            Pixels = new char[,] { { } };
        }
        public Shape(char[,] pixels)
        {
            Pixels = pixels;
        }
    }
}
