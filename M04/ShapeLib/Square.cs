using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    class Square : Rectangle
    {
        public Square(int side)
        {
            Pixels = new char[side, side];
        }
    }
}
