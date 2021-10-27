using System;

namespace ReversePolishCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpc = new ReversePolishCalculator();
            Console.WriteLine(rpc.CalculateExpression("5 1 2 + 4 * + 3"));
            Console.ReadKey();
        }
    }
}
