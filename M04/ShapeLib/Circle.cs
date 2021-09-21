using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ShapeLib
{
    class Circle : Shape
    {
        int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public Circle(int radius, char symbol)
        {
            Radius = radius;
            Pixels = new char[radius * 2, radius * 2];
            for (int w = 0; w < radius * 2; w++)
            {
                for (int h = 0; h < radius * 2; w++)
                {
                    
                }
            }
        }
    }
}
