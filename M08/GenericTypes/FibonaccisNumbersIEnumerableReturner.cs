using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public class FibonaccisNumbersIEnumerableReturner
    {
        public IEnumerable<int> GetFibonaccisNumbers<T>(int source, Comparer<int> comparer) where T : struct
        {
            double root5 = Math.Sqrt(5);
            double phi = (1 + root5) / 2;

            Console.Write("Fibonacci numbers to {0}: ", source);

            int n = 0;
            int Fn;
            var result = new List<int>();
            do
            {
                Fn = (int)((Math.Pow(phi, n) - Math.Pow(-phi, -n)) / (2 * phi - 1));
                result.Add(Fn);
                ++n;
            } while (comparer.Compare(Fn, source) < 0);

            return result;
        }
    }
}
