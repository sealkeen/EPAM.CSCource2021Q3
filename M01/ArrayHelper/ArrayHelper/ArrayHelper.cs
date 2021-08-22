using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
    public static class ArrayHelper
    {
        public static void BubbleSort<T>(T[] array, bool ascending = true)
        {
            //if (!(array is IComparable))
            //    return;
            var swapped = false;
            var last = array.Length - 1;
            bool condition = false;
            try {
                do {
                    swapped = false;
                    for (int i = 1; i <= last; i++) {
                        /* if this pair is out of order */
                        condition = ascending ? 
                            More(array[i - 1], array[i]) : 
                            Less(array[i - 1], array[i]);
                        if (condition) 
                        {
                            /* swap them and remember something changed */
                            Swap(ref array[i - 1], ref array[i]);
                            swapped = true;
                        }
                    }
                } while (swapped);
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public static bool More<T>(T left, T right)
        {
            return (left as IComparable).CompareTo(right) > 0;
        }
        public static bool Less<T>(T left, T right)
        {
            return (left as IComparable).CompareTo(right) < 0;
        }
        public static void Swap<T>(ref T left, ref T right)
        {
            T _temp = right;
            right = left;
            left = _temp;
        }
        public static T Sum<T>(T[,] array) where T: struct // [,] sum for two dimensional array
        {
            if (!(array is IEnumerable))
                return default(T);
            dynamic sum = default(T);
            for (int i = 0; i < array.GetLength(0); i++) 
                for (int k = 0; k < array.GetLength(1); k++) 
                    if (array[i, k].ToString()[0] != '-') 
                        sum += array[i, k];
            return sum;
        }
        public static T Sum<T>(T[][] array) where T : struct // [][] sum for array of arrays 
        {         
            if (!(array is IEnumerable))
                return default(T);
            dynamic sum = default(T);
            foreach (T[] subArray in array)
                foreach (T i in subArray)
                    if (i.ToString()[0] != '-')
                        sum += i;
            return sum;
        }
        public static bool Initialize<T>(Type type)
        {
            if (!(type is IEnumerable))
                return false;
            return true;
        }
    }
}
