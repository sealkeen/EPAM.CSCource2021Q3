using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class Shape : IDisposable
    {
        public Point Position { get; set; }

        public const int Step = 1;
        protected bool disposedValue;
        protected char[,] _pixels;
        public int Width => _pixels.GetLength(0);
        public int Height => _pixels.GetLength(1);
        public virtual bool ElementIsOutOfArea(RenderArea area)
        {
            if (this.Position.X < area.Position.X || this.Position.Y < area.Position.Y)
            {
                return true;
            }
            return false;
        }
        public virtual void Draw(RenderArea renderArea)
        {
            this.Draw(renderArea);
        }

        public void MoveRight(RenderArea renderArea)
        {
            if (renderArea.Height > (this.Position.X + Height + Step - 1))
            {
                this.Position += new Size(Step, 0);
            }
        }
        public void MoveLeft()
        {
            if ((Position.X - Step) >= 0)
            {
                this.Position += new Size(-Step, 0);
            }
        }
        public void MoveUp()
        {
            if ((Position.Y - Step) >= 0)
            {
                this.Position += new Size(0, -Step);
            }
        }
        public void MoveDown(RenderArea renderArea)
        {
            if (renderArea.Width > (Position.Y + Width + Step - 1 ))
            {
                this.Position += new Size(0, Step);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Shape()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
