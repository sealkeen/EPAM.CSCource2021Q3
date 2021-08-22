using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArrayHelper;
using RectangleHelper;

namespace ArrayTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            string[] strArray = new string[5] {"5", "4", "3", "2", "1"};
            Random rnd = new Random();

            for(int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(10);

            Console.WriteLine("Random Int array:"); Show(array);
            Console.WriteLine("String Array: "); Show(strArray);

            ArrayHelper.ArrayHelper.BubbleSort<int>(array, false);
            ArrayHelper.ArrayHelper.BubbleSort<string>(strArray);

            Console.WriteLine("Random Int array sorted (Descending): "); Show(array);
            Console.WriteLine("String array sorted (Ascending): "); Show(strArray); 

            int[,] twoDimArr = new int[,] { { 1, -2 }, { 3, -4 } };
            Console.WriteLine("Two dim array: "); Show<int>(twoDimArr);

            Console.WriteLine("Two dim array sum of positives: ");
            Console.WriteLine(ArrayHelper.ArrayHelper.Sum<int>(twoDimArr));

            Console.WriteLine($"Perimeter of a rectangle 4, 5 <int>:, {RectangleHelper.RectangleHelper.Perimeter<int>(4, 5)}");
            Console.WriteLine($"Square of a rectangle 4, 5 <int>: {RectangleHelper.RectangleHelper.Square<int>(4, 5)}");

            Console.ReadKey();
        }
        static private void Show(Array array)
        {
            foreach (var e in array) {
                Console.Write(e+" ");
            }
            Console.WriteLine();
        }
        static private void Show<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int k = 0; k < array.GetLength(1); k++)
                    Console.Write(array[i, k] + " ");
                Console.WriteLine();
            }
        }
    }
}
