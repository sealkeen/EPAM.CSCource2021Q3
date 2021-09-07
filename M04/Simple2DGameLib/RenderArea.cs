using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Simple2DGameLib
{
    public class RenderArea : Rectangle, IEnumerable<Shape>
    {
        private List<Shape> _elements;
        private const int _defaultWidth = 13;
        private const int _defaultHeight = 70;
        public Shape this[int index] 
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
            _elements = new List<Shape>();
        }
        public RenderArea(int width, int height)
        {
            _pixels = new Char[width, height];
            for (int i = 0; i < Width; i++)
            {
                for (int k = 0; k < Height; k++)
                {
                    _pixels[i, k] = '.';
                }
            }
        }
        public override void Draw(RenderArea renderArea)
        {
            foreach (var element in _elements)
            {
                element.Draw(this);
            }

            for (int k = 0; k < Width; k++)
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.Write(_pixels[k, i]);
                }
                Console.WriteLine();
            }
        }
        public bool AddElement(Shape element)
        {
            if (element.ElementIsOutOfArea(this)) {
                return false;
            }
            _elements.Add(element);
            return true;
        }

        public IEnumerator<Shape> GetEnumerator()
        {
            foreach (var element in _elements)
            {
                yield return element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
