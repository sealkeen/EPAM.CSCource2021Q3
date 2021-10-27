using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixAndMessageDataWorker
{
    public class MatrixSorterByMaxElement : AbstractMatrixSorter
    {
        public MatrixSorterByMaxElement(bool ascending = true) : base(ascending)
        {
            
        }
        public override void SortMatrix(ref int[,] matrix)
        {
            int[] rows = new int[matrix.GetLength(0)];
            ArraySummator aS = new ArraySummator();
            var rowsSum = aS.GetMaximumElements(matrix);
            if (matrix.GetLength(0) > 1)
            {
                for (int i = 0; i < rowsSum.Length - 1; i++)
                {
                    for (int rI = 0; rI < (rowsSum.Length - i - 1); rI++)
                    {
                        if (SwapItems(ref rowsSum, rI, rI + 1))
                        {
                            SwapMatrixRows(ref matrix, rI, rI + 1);
                        }
                    }
                }
            }
        }
    }
}
