using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Simple2DGameLib
{
    class Circle : Shape
    {
        int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override void Draw(RenderArea renderArea)
        {
            throw new NotImplementedException();
        }
    }
}
