using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
    public class ArraySorter
    {
        public void BubbleSort(int[] array, bool ascending = true)
        {
            var swapped = false;
            var condition = false;
            for ( var last = (array.Length - 1) ; ; ) {
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
                if (!swapped) break;
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
