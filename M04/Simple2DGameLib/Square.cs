using System;
using System.Collections.Generic;
using System.Text;

namespace Simple2DGameLib
{
    class Square : Rectangle
    {
        public Square(int side) 
        {
            _pixels = new char[side, side];
        }

        public override void Draw(RenderArea renderArea)
        {
            throw new NotImplementedException();
        }
    }
}
