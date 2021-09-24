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
        public override void MoveLeft(RenderArea renderArea) { }
        public override void MoveUp(RenderArea renderArea) { }
        public override void MoveDown(RenderArea renderArea) { }
    }
}
