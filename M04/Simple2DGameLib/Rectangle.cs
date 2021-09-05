using System;
using System.Collections.Generic;
using System.Text;

namespace Simple2DGameLib
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override void Draw()
        {
        }
        public override bool ElementIsOutOfArea(RenderArea area)
        {
            if ((this.Position.X < area.Position.X || this.Position.Y < area.Position.Y)
                ||
                (this.Position.X+Width > area.Width || this.Position.Y+Height > area.Height) 
                )
                return true;
            return false;
        }
    }
}
