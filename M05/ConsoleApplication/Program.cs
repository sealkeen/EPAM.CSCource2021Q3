using System;
using ParserLibrary;
using NLog;

namespace ConsoleApplication
{
    class Program
    {
        public static Logger NLogger { get ; set ; }

        private static void InitializeLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "log.txt" };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;
        }

        static void Main(string[] args)
        {
	    InitializeLogger();
            var parser = new Int32Parser();
            try
            {
                Console.WriteLine(parser.Parse("-8765"));
            }
            catch (ArgumentException ex)
            {
                NLogger.Error(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
