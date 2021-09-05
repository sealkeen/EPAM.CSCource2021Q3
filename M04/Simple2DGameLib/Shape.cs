using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class Shape : IDisposable
    {
        public Point Position { get; set; }
        protected bool disposedValue;
        protected Color[,] _pixels;
        protected virtual bool ElementIsOutOfArea(RenderArea area) {
            if (this.Position.X < area.Position.X || this.Position.Y < area.Position.Y)
                return true;
            return false;
        }
        public virtual void Draw()
        {

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
