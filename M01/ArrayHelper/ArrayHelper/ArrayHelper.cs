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
                for ( int i = 1; i <= last; i++ ) {
                    condition = ascending ? 
                        IsMore(array[i - 1], array[i]) : 
                        IsLess(array[i - 1], array[i]);
                    if (condition) {
                        SwapItem(ref array[i - 1], ref array[i]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        public bool IsMore(int left, int right)
        {
            return (left > right);
        }
        public bool IsLess(int left, int right)
        {
            return (left < right);
        }
        public void SwapItem(ref int left, ref int right)
        {
            var _temp = right;
            right = left;
            left = _temp;
        }
    }
}
