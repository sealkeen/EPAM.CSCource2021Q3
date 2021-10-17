using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using ParserLibrary;
using System.Diagnostics;


namespace Int32ParserTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void ErrorParseTest()
        {
            var args = new string[] { "edf" };
            var serviceProvider = ConsoleApplication.Program.BuildDi(ConsoleApplication.Program.GetConfiguration());
            var parser = serviceProvider.GetRequiredService<Int32Parser>();
            ConsoleApplication.Program.RunParser(parser, ref args);
        }

        [Test]
        public void Int32ParserTest()
        {
            var serviceProvider = ConsoleApplication.Program.BuildDi(ConsoleApplication.Program.GetConfiguration());
            var parser = serviceProvider.GetRequiredService<Int32Parser>();

            var result = parser.Parse("-8765");
            Trace.WriteLine(result = parser.Parse("-8765"));
            Assert.AreEqual(-8765, result);

            Trace.WriteLine(result = parser.Parse("2222765"));
            Assert.AreEqual(2222765, result);

            Trace.WriteLine(result = parser.Parse("99999997"));
            Assert.AreEqual(99999997, result);

            Trace.WriteLine(result = parser.Parse("-987654321"));
            Assert.AreEqual(-987654321, result);

            Trace.WriteLine(result = parser.Parse("-212111210"));
            Assert.AreEqual(-212111210, result);

            Trace.WriteLine(result = parser.Parse("-012111210"));
            Assert.AreEqual(-12111210, result);

            //Assert.Pass();
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