using NUnit.Framework;
using System.Diagnostics;
using ParserLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace Int32ParserTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(new object[] { "edf" })]
        public void ErrorParseTest(string[] args)
        {
            var serviceProvider = ConsoleApplication.Program.BuildDi(ConsoleApplication.Program.GetConfiguration());
            var parser = serviceProvider.GetRequiredService<Int32Parser>();
            ConsoleApplication.Program.RunParser(parser, ref args);
        }

        [Test]
        [TestCase( "edf" )]
        [TestCase( "-8765", -8765)]
        [TestCase( "2222765", 2222765)]
        [TestCase( "99999997", 99999997)]
        [TestCase( "-987654321", -987654321)]
        [TestCase( "-212111210", -212111210)]
        [TestCase( "-012111210", -12111210)]
        public void Int32ParserTest(string source, int expected)
        {
            var serviceProvider = ConsoleApplication.Program.BuildDi(ConsoleApplication.Program.GetConfiguration());
            var parser = serviceProvider.GetRequiredService<Int32Parser>();

            int result;
            Trace.WriteLine(result = parser.Parse(source));
            Assert.AreEqual(expected, result);
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