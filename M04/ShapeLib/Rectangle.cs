using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public Rectangle() 
        {

        }
        public Rectangle(char[,] rectangleArray) : base()
        {
            Pixels = rectangleArray;
        }
        public int Perimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
