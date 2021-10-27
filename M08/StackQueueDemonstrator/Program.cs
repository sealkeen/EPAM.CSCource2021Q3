using System;
using GenericTypes;

namespace StackQueueDemonstrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var col = new GenericStackQueueCollection<int>(0);
            col.Push(1);
            col.Push(2);
            col.Push(3);

            Console.WriteLine("Straight traversal:");

            foreach (var element in col)
            {
                Console.WriteLine(element);
            }

            col.ReverseDirection();
            Console.WriteLine("\nReverse traversal:");

            foreach (var element in col)
            {
                Console.WriteLine(element);
            }

        }
    }
}
