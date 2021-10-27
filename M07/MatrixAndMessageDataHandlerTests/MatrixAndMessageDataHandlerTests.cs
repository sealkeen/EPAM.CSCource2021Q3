using NUnit.Framework;
using MatrixAndMessageDataWorker;
using System.Diagnostics;
using System.Collections.Generic;

namespace MatrixAndMessageDataHandlerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        public int[,] CreateNewMatrix(int[,] source)
        {
            int[,] newMatrix = new int[source.GetLength(0), source.GetLength(1)];
            Copy(source, newMatrix);
            return newMatrix;
        }

        public void Copy(int[,] source, int[,] dest)
        {
            for (int h = 0; h < source.GetLength(0); h++)
            {
                for (int w = 0; w < source.GetLength(1); w++)
                {
                    dest[h, w] = source[h, w];
                }
            }
        }

        public IEnumerable<int[,]> GetTestMatrix()
        {
            yield return (new int[,] { { 9, 8, 7 }, { 3, 2, 1 }, { 6, 5, 4 } });
            yield return (new int[,] { { 9, 8, 7 }, { 3, 2, 1 }, { 6, 5, 4 } });
            yield return (new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 }, { 10, 11, 12 } });
            yield return (new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 }, { 10, 11, 12 } });
            yield return (new int[,] { { 25, 30, 35, 40 }, { 10, 15, 20, 25 }, { 0, 5, 10, 15 },
                { -300, -295, -290, -285 }, { -60, -45, -30, -15 }, { 21, 22, 23, 24 } });
            yield return (new int[,] { { 25, 30, 35, 40 }, { 10, 15, 20, 25 }, { 0, 5, 10, 15 },
                { -300, -295, -290, -285 }, { -60, -45, -30, -15 }, { 21, 22, 23, 24 } });
        }

        [Test]
        public void MatrixSumSortTest()
        {
            var asc = false; //2 times - for ascending false and for ascending true
            foreach (int[,] matrix in GetTestMatrix())
            {
                var mS = new MatrixSorterContext(SortingMethod.SumOfElements, asc);
                int[,] newMatrix = CreateNewMatrix(matrix);
                Program.Show(matrix); mS.SortMatrix(ref newMatrix);
                Debug.WriteLine(""); Program.Show(newMatrix);
                Assert.AreNotEqual(matrix, newMatrix);
                Debug.WriteLine("_______________");
                asc = true;
            }
        }

        [Test]
        public void MatrixMinElementSortTest()
        {
            bool asc = false; //2 times - for ascending false and for ascending true
            foreach (int[,] matrix in GetTestMatrix())
            {
                var mS = new MatrixSorterContext(SortingMethod.MinimumElement, asc);
                int[,] newMatrix = CreateNewMatrix(matrix);
                Program.Show(matrix); mS.SortMatrix(ref newMatrix);
                Debug.WriteLine(""); Program.Show(newMatrix);
                Assert.AreNotEqual(matrix, newMatrix);
                Debug.WriteLine("_______________");
                asc = true;
            }
        }

        [Test]
        public void MatrixMaxElementSortTest()
        {
            bool asc = false; //2 times - for ascending false and for ascending true
            for (int i = 0; i < 2; i++)
            {
                foreach (int[,] matrix in GetTestMatrix())
                {
                    var mS = new MatrixSorterContext(SortingMethod.MaximumElement, asc);
                    int[,] newMatrix = CreateNewMatrix(matrix);
                    Program.Show(matrix); mS.SortMatrix(ref newMatrix);
                    Debug.WriteLine(""); Program.Show(newMatrix);
                    Assert.AreNotEqual(matrix, newMatrix);
                    Debug.WriteLine("_______________");
                    asc = true;
                }
            }
        }

        [SetUpFixture]
        public class SetupTrace
        {
            [OneTimeSetUp]
            public void StartTest()
            {
                Trace.Listeners.Add(new ConsoleTraceListener());
            }

            [OneTimeTearDown]
            public void EndTest()
            {
                Trace.Flush();
            }
        }
    }
}