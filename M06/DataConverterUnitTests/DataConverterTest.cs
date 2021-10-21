using NUnit.Framework;
using TextAndNumberDataConverter;
using System;
using System.Diagnostics;

namespace DataConverterUnitTests
{
    public class Tests
    {
        [Test]
        [TestCase("One.Two three", 5.5)]
        [TestCase("One. three!", 4)]
        [TestCase("One. three! ,.four;", 4)]
        [TestCase("One. three! ,.four;", 4)]
        public void AverageWordLengthTest(string arg, double argResult)
        {
            //2 Second Task of M03
            var wordAverageLengthDetector = new WordAverageLengthDetector();

            double length = wordAverageLengthDetector.GetAverageLength(arg);
            Debug.WriteLine(length);
            Assert.AreEqual(length, argResult);
        }
        [Test]
        [TestCase("How do you like this, Elon Mask?", "lask", "How do you llikke thiss, Ellon Maasskk?")]
        [TestCase("first string", "st", "firsstt ssttring")]
        public void CharacterDuplicatorTest(string source, string modifier, string expected)
        {
            //3 Third Task of M03
            var charDuplicator = new CharacterDuplicator();
            var result = charDuplicator.GetMultipliedCharatersString(source, modifier);
            Debug.WriteLine(result);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("123", "456", "579")] [TestCase("1234", "4567", "5801")]
        [TestCase("0000001234", "5567", "0000006801")] [TestCase("1", "2", "3")]
        [TestCase("11", "2", "13")] 
        [TestCase("1111111111111111111111111111", "2222222222222222222222222222", "3333333333333333333333333333")]
        [TestCase("0000000000000009000000000000", "0000000000000001000000000000", "0000000000000010000000000000")]
        [TestCase("000", "000", "000")] [TestCase("099", "011", "110")]
        public void SumIntegersTest(string first, string second, string expected)
        {
            //4 Fourth Task of M03
            var nS = new NumberSummator();
            var result = nS.SumInts(first, second);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase("123.0", "456", "579.0")]
        [TestCase("123.0", "456", "579.0")]
        [TestCase("124.05", "456", "580.05")]
        [TestCase("12499999.05", "456", "12500455.05")]
        [TestCase("5555555777776.0000058", "9823755088.000000005", "5565379532864.000005805")]
        public void SumDoubleTest(string first, string second, string expected)
        {
            //4 Fourth Task of M03
            var nS = new NumberSummator();
            var result = nS.SumNumbers(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase("The greatest victory is that which requires no battle")]
        [TestCase("This is the second sentence in the method")]
        [TestCase("This third sentence follows previous, the second one")]
        public void ReverseOrderTest(string wordsToReverse)
        {
            //5 Fifth Task of M03
            var wordOrderReverser = new WordOrderReverser();
            var aWLD = new WordAverageLengthDetector();
            string result;
            Console.WriteLine($"\n{wordsToReverse} => {result = wordOrderReverser.ReverseOrder(wordsToReverse)}");

            Assert.AreEqual(wordsToReverse.Length, result.Length);
            Assert.AreEqual(aWLD.GetAverageLength(wordsToReverse),aWLD.GetAverageLength(result));
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