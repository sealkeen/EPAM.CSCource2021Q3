using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
    public class ArraySummator
    {
        public int Sum(int[,] array)
        {
            var sum = 0;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int k = 0; k < array.GetLength(1); k++) {
                    if (array[i, k] > 0) 
                        sum += array[i, k];
                }
            }
            return sum;
        }
    }
    public class ArraySorter
    {
        public void BubbleSort(int[] array, bool ascending = true)
        {
            var last = array.Length - 1;
            var swapped = false;
            var condition = false;
            try {
                do {
                    swapped = false;
                    for (int i = 1; i <= last; i++) {
                        condition = ascending ? 
                            More(array[i - 1], array[i]) : 
                            Less(array[i - 1], array[i]);
                        if (condition) {
                            Swap(ref array[i - 1], ref array[i]);
                            swapped = true;
                        }
                    }
                } while (swapped);
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public bool More(int left, int right)
        {
            return (left > right);
        }
        public bool Less(int left, int right)
        {
            return (left < right);
        }
        public void Swap(ref int left, ref int right)
        {
            var _temp = right;
            right = left;
            left = _temp;
        }
    }
}
