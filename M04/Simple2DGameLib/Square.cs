using System;
using System.Collections.Generic;
using System.Text;

namespace Simple2DGameLib
{
    class Square : Rectangle
    {
        public Square(int side) 
        {
            Height = side;
            Width = side;
        }

        public override void Draw()
        {
            
        }
    }
}
