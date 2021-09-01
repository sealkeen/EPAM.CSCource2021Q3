using System;
using ParserLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //NLog nLog = new NLog();
            var parser = new Int32Parser();

            Console.WriteLine(parser.Parse("-8765"));

            Console.ReadKey();
        }
    }
}
