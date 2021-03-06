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
            var array = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }

            var arraySorter = new ArrayHelper.ArrayHelper();
            Console.WriteLine("Random Int array:"); Show(array);
            arraySorter.BubbleSort(array, true);
            Console.WriteLine("Random Int array sorted (Descending): "); Show(array);

            var twoDimArr = new int[,] { { 3, -2 }, { 7, -4 } };
            Console.WriteLine("Two dim array: "); Show(twoDimArr);

            var arraySummator = new ArraySummator();
            Console.WriteLine("Two dim array sum of positives: ");
            Console.WriteLine(arraySummator.GetArraySum(twoDimArr));

            var rectangleCalc = new RectangleCalculator();
            Console.WriteLine($"Perimeter of a rectangle 4, 5 <int>:, {rectangleCalc.GetPerimeter(4, 5)}");
            Console.WriteLine($"Square of a rectangle 4, 5 <int>: {rectangleCalc.GetSquare(4, 5)}");

            Console.ReadKey();
        }
        static private void Show(Array array)
        {
            foreach (var item in array) 
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        static private void Show(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
