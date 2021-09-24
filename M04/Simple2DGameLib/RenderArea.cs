using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ShapeLib;

namespace Simple2DGameLib
{
    public class RenderArea : GameElement
    {
        private List<GameElement> _elements;
        private const int _defaultWidth = 13;
        private const int _defaultHeight = 70;
        public const char FillingSpaceChar = '.';
        public GameElement this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return _elements[index];
                }
                else
                    throw new IndexOutOfRangeException("Index cannot be less than zero.");
            }
        }
        public RenderArea() : this(_defaultWidth, _defaultHeight)
        {
            _elements = new List<GameElement>();
        }
        public RenderArea(int width, int height) : base(new char[_defaultWidth, _defaultHeight])
        {
            Pixels = new Char[width, height];
            for (int i = 0; i < Height; i++)
            {
                for (int k = 0; k < Width; k++)
                {
                    Pixels[i, k] = FillingSpaceChar;
                }
            }
        }
        public void EraseArea()
        {
            for (int k = 0; k < Height; k++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Pixels[k, i] = ' ';
                }
            }
        }
        public void Draw()
        {
            //EraseArea();
            foreach (var element in _elements)
            {
                DrawElement(element);
            }

            for (int k = 0; k < Height; k++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Console.Write(Pixels[k, i]);
                }
                Console.WriteLine();
            }
        }
        public bool AddElement(GameElement element)
        {
            if (ElementIsOutOfArea(element)) {
                return false;
            }
            _elements.Add(element);
            return true;
        }

        public void DrawElement(GameElement shape)
        {
            for (int i = 0; i < shape.Height; i++)
            {
                for (int k = 0; k < shape.Width; k++)
                {
                    this.Pixels[shape.Position.Y + i, shape.Position.X + k] = shape.Pixels[i, k];
                }
            }
        }
        public bool ElementIsOutOfArea(GameElement element)
        {
            if ((element.Position.X < this.Position.X || element.Position.Y < this.Position.Y)
                ||
                (element.Position.X + Width > this.Width || element.Position.Y + Height > this.Height)
                )
                return true;
            return false;
        }

    }
}
