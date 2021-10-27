using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixAndMessageDataWorker
{
    public class MatrixSorterContext
    {
        private AbstractMatrixSorter sorter;

        public MatrixSorterContext(SortingMethod sortingMethod, bool ascending = true)
        {
            if (sortingMethod == SortingMethod.SumOfElements)
                sorter = new MatrixSorterBySum(ascending);
            else if (sortingMethod == SortingMethod.MaximumElement)
                sorter = new MatrixSorterByMaxElement(ascending);
            else if (sortingMethod == SortingMethod.MinimumElement)
                sorter = new MatrixSorterByMinElement(ascending);
        }

        public void SortMatrix(ref int[,] matrix)
        {
            sorter.SortMatrix(ref matrix);
        }
    }
}
