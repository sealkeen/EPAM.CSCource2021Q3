using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleHelper
{
    public class RectangleHelper
    {
        public static T Square<T>(T width, T height) where T : struct
        {
            dynamic square = width;
            square *= height;
            return square;
        }
        public static T Perimeter<T>(T width, T height) where T : struct
        {
            dynamic perimeter = width;
            perimeter += height;
            perimeter *= 2;
            return perimeter;
        }
    }
}
