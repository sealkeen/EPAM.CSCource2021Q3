using System;
using System.Collections.Generic;
using System.Text;

namespace Simple2DGameLib
{
    class Obstacle : GameElement
    {
        public Obstacle(char[,] pixels) : base(pixels)
        {
            
        }

        public override void MoveRight(RenderArea renderArea) { }
        public override void MoveLeft() { }
        public override void MoveUp() { }
        public override void MoveDown(RenderArea renderArea) { }
    }
}
