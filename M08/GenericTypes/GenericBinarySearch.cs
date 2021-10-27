using System;
using System.Collections.Generic;

namespace GenericTypes
{
    public class GenericBinarySearch
    {
        public static int BinarySearch<T>(T[] array, T searchFor, Comparer<T> comparer)
        {
            var high = array.Length - 1;
            var low = 0;
            int mid;
            if (array[0].Equals(searchFor))
                return 0;
            else if (array[high].Equals(searchFor))
                return high;
            else 
            {
                while (low <= high) 
                {
                    mid = (high + low) / 2;
                    if (comparer.Compare(array[mid], searchFor) == 0)
                        return mid;
                    else if (comparer.Compare(array[mid], searchFor) > 0)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                return -1;
            }
        }
    }
}
