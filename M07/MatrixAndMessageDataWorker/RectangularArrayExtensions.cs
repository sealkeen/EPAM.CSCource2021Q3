using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixAndMessageDataWorker
{
    public static class RectangularArrayExtensions
    {
        public static IEnumerable<T> Cast<T>(this T[,] source)
        {
            foreach (T item in source)
            {
                yield return item;
            }
        }
    }
}
