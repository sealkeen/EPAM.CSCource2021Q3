using System;
using System.Collections.Generic;
using System.Text;
using ShapeLib;
using System.Drawing;

namespace Simple2DGameLib
{
    public class GameElement : Shape
    {
        public Point Position { get; set; }
        public const int Step = 1;
        public GameElement(char [,] pixels) : base(pixels)
        {

        }
        public virtual void MoveRight(RenderArea renderArea)
        {
            if (renderArea.Width > (this.Position.X + this.Width + Step - 1))
            {
                this.Position += new Size(Step, 0);
            }
        }
        public virtual void MoveLeft(RenderArea renderArea)
        {
            if ((this.Position.X - Step) >= 0)
            {
                this.Position += new Size(-Step, 0);
                for (int y = this.Position.Y; y < Position.Y + Height; y++)
                {
                    renderArea.Pixels[y, Position.X+Width] = RenderArea.FillingSpaceChar;
                }
            }
        }
        public virtual void MoveUp(RenderArea renderArea)
        {
            if ((this.Position.Y - Step) >= 0)
            {
                this.Position += new Size(0, -Step);
            }
        }
        public virtual void MoveDown(RenderArea renderArea)
        {
            if (renderArea.Height > (this.Position.Y + this.Height + Step - 1))
            {
                this.Position += new Size(0, Step);
            }
        }
    }
}
