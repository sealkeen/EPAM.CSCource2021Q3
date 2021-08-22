using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleHelper
{
    public class RectangleCalculator
    {
        public int Square(int width, int height)
        {
            return (width * height);
        }
        public int Perimeter(int width, int height)
        {
            return (width + height) * 2;
        }
    }
}
