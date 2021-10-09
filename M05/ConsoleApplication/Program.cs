using System;
using ParserLibrary;
using NLog;
using NLog.Targets;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Xml;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog.Extensions.Logging;

namespace ConsoleApplication
{
    public class Program
    {
        public static readonly NLog.Logger ClassLogger = NLog.LogManager.GetCurrentClassLogger();
        private static string logfileName = 
            $"{Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar}log.txt";
        public static void Main(string[] args)
        {
            try 
            {
                InitializeLogger();
                var config = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory()) //From NuGet Package Microsoft.Extensions.Configuration.Json
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();

                var servicesProvider = BuildDi(config);
                using (servicesProvider as IDisposable)
                {
                    var parser = servicesProvider.GetRequiredService<Int32Parser>();

                    RunParser(parser, ref args);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                ClassLogger.Error(ex.Message);
            }
            finally
            {      // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                LogManager.Shutdown();
            }
        }
        public static void RunParser(Int32Parser parser, ref string[] args)
        {
            AddArgument(ref args, "-814");
            AddArgument(ref args, "edf");
            
            foreach (var value in args)
            {
                Console.WriteLine("Value Parsed: {0}", parser.Parse(value));
            }
        }
        private static void AddArgument(ref string[] args, string argument)
        {
            Array.Resize(ref args, args.Length + 1);
            args.SetValue(argument, args.Length - 1);
        }
        public static NLog.Config.LoggingConfiguration InitializeLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = logfileName };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            
            config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logconsole);
            config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logfile);
            NLog.LogManager.Configuration = config;
            return config;
        }

        public static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
            .SetBasePath(System.IO.Directory.GetCurrentDirectory()) //From NuGet Package Microsoft.Extensions.Configuration.Json
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
        }

        public static IServiceProvider BuildDi(IConfiguration config)
        {
            return new ServiceCollection()
               .AddTransient<Int32Parser>() // Int32Parser is the custom class
               .AddLogging(loggingBuilder =>
               {
                    // configure Logging with NLog
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Error);
                    loggingBuilder.AddNLog(config);
               })
               .BuildServiceProvider();
        }
    }
}
