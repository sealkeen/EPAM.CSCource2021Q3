using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleHelper
{
    public class RectangleCalculator
    {
        public int GetSquare(int width, int height)
        {
            return (width * height);
        }
        public int GetPerimeter(int width, int height)
        {
            return (width + height) * 2;
        }
    }
}
