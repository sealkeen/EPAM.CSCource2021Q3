using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
    public class ArraySummator
    {
        public int GetArraySum(int[,] array)
        {
            var sum = 0;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int k = 0; k < array.GetLength(1); k++) {
                    if (array[i, k] > 0) {
                        sum += array[i, k];
                    }
                }
            }
            return sum;
        }
    }
}
