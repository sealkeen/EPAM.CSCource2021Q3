using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixAndMessageDataWorker
{
    public class MatrixSorterByMinElement : AbstractMatrixSorter
    {
        public MatrixSorterByMinElement(bool ascending = true) : base(ascending)
        {

        }
        public override void SortMatrix(ref int[,] matrix)
        {
            int[] rows = new int[matrix.GetLength(0)];
            ArraySummator aS = new ArraySummator();
            var rowsSum = aS.GetMinimumElements(matrix);
            if (matrix.GetLength(0) > 1)
            {
                for (int i = 0; i < rowsSum.Length - 1; i++)
                {
                    for (int rI = 0; rI < (rowsSum.Length - i - 1); rI++)
                    {
                        if (SwapItems(ref rowsSum, rI + 1, rI))
                        {
                            SwapMatrixRows(ref matrix, rI + 1, rI);
                        }
                    }
                }
            }
        }
    }
}
