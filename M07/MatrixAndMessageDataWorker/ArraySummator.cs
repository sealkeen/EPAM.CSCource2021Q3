using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MatrixAndMessageDataWorker
{
    public class ArraySummator
    {
        public int[] GetArraySum(int[,] array)
        {
            var sums = new int[array.GetLength(0)];
            if (array.GetLength(1) == 0)
            {
                return sums;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    //if (array[i, k] > 0)
                    {
                        sums[i] += array[i, k];
                    }
                }
            }
            return sums;
        }
        public int[] GetMaximumElements(int[,] array)
        {
            var maximums = new int[array.GetLength(0)];
            if (array.GetLength(1) == 0)
            {
                return maximums;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                maximums[i] = array[i, 0];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, k] > maximums[i])
                    {
                        maximums[i] = array[i, k];
                    }
                }
            }
            return maximums;
        }
        public int[] GetMinimumElements(int[,] array)
        {
            var minimums = new int[array.GetLength(0)];
            if (array.GetLength(1) == 0)
            {
                return minimums;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                minimums[i] = array[i, 0];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, k] < minimums[i])
                    {
                        minimums[i] = array[i, k];
                    }
                }
            }
            return minimums;
        }
    }

}
