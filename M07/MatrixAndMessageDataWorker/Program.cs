using System;

namespace MatrixAndMessageDataWorker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mS = new MatrixSorterContext(SortingMethod.SumOfElements, true);
            int[,] matrix = new int[,] { { 0, -5, 2 }, { 250, 6, 8} , { 3, 10, -7 } };
            mS.SortMatrix(ref matrix);
            Show(matrix);

            Console.WriteLine("Also take a look at the MatrixSorterTests project, the remaining parts are there.");
        }

        static public void Show(int[,] array)
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
