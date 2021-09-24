using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
    //TODO: Choose a single right name for the class (v)
    public class ArrayHelper
    {
        public void BubbleSort(int[] array, bool ascending = true)
        {
            var condition = false;
            for (int i = 0; i < array.Length - 1; i++) 
            {
                for ( int j = 0 ; j < (array.Length - i - 1) ; j++ ) 
                {
                    condition = ascending ? 
                        IsMore( array[j], array[j+1] ) : IsLess(array[j], array[j+1]);
                    if (condition) 
                    {
                        SwapItem(ref array[j], ref array[j+1]);
                    }
                }
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
