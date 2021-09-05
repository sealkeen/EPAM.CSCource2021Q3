using System;
using System.Collections.Generic;
using System.Text;

namespace Simple2DGameLib
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void Draw(RenderArea renderArea)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int k = 0; k < Height; k++)
                {
                    renderArea._pixels[this.Position.X+i, this.Position.Y+k] = ' ';
                }
            }
        }
        public Rectangle() 
        {
            _pixels = null;
            Height = 0;
            Width = 0;
        }
        public Rectangle(char[,] rectangleArray) 
        {
            _pixels = rectangleArray;
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
