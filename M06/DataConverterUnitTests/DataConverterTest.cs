using NUnit.Framework;
using TextAndNumberDataConverter;
using System;
using System.Diagnostics;

namespace DataConverterUnitTests
{
    public class Tests
    {
        [Test]
        public void AverageWordLengthTest()
        {
            //2 Second Task of M03
            var wordAverageLengthDetector = new WordAverageLengthDetector();

            var length = wordAverageLengthDetector.GetAverageLength("One.Two three");
            Debug.WriteLine(length);
            Assert.AreEqual(length, 5.5);

            length = wordAverageLengthDetector.GetAverageLength("One. three!");
            Assert.AreEqual(length, 4);

            length = wordAverageLengthDetector.GetAverageLength("One. three! ,.four;");
            Assert.AreEqual(length, 4);

            length = wordAverageLengthDetector.GetAverageLength("One. three! ,.four;");
            Assert.AreEqual(length, 4);
        }
        [Test]
        public void CharacterDuplicatorTest()
        {
            //3 Third Task of M03
            var charDuplicator = new CharacterDuplicator();
            var result = charDuplicator.GetMultipliedCharatersString("How do you like this, Elon Mask?", "lask");
            Debug.WriteLine(result);
            Assert.AreEqual("How do you llikke thiss, Ellon Maasskk?", result);

            result = charDuplicator.GetMultipliedCharatersString("first string", "st");
            Debug.WriteLine(result);
            Assert.AreEqual("firsstt ssttring", result);
        }

        [Test]
        public void SumIntegersTest()
        {
            //4 Fourth Task of M03
            var nS = new NumberSummator();
            var result = nS.SumInts("123", "456");
            Assert.AreEqual(result, "579");

            result = nS.SumInts("1234", "4567");
            Assert.AreEqual(result, "5801");

            result = nS.SumInts("0000001234", "5567");
            Assert.AreEqual(result, "0000006801");

            result = nS.SumInts("1", "2");
            Assert.AreEqual(result, "3");

            result = nS.SumInts("11", "2");
            Assert.AreEqual(result, "13");

            result = nS.SumInts("1111111111111111111111111111", "2222222222222222222222222222");
            Assert.AreEqual(result, "3333333333333333333333333333");

            result = nS.SumInts("0000000000000009000000000000", "0000000000000001000000000000");
            Assert.AreEqual(result, "0000000000000010000000000000");

            result = nS.SumInts("000", "000");
            Assert.AreEqual(result, "000");

            result = nS.SumInts("099", "011");
            Assert.AreEqual(result, "110");
        }

        [Test]
        public void SumDoubleTest()
        {
            //4 Fourth Task of M03
            var nS = new NumberSummator();
            var result = nS.SumNumbers("123.0", "456");
            Assert.AreEqual(result, "579.0");

            result = nS.SumNumbers("123.0", "456");
            Assert.AreEqual(result, "579.0");

            result = nS.SumNumbers("124.05", "456");
            Assert.AreEqual(result, "580.05");

            result = nS.SumNumbers("12499999.05", "456");
            Assert.AreEqual(result, "12500455.05");

            result = nS.SumNumbers("5555555777776.0000058", "9823755088.000000005");
            Assert.AreEqual(result, "5565379532864.000005805");
        }
        [Test]
        public void ReverseOrderTest()
        {
            //5 Fifth Task of M03
            var wordOrderReverser = new WordOrderReverser();
            var wordsToReverse = "The greatest victory is that which requires no battle";
            Debug.WriteLine($"\n{wordsToReverse} => {wordOrderReverser.ReverseOrder(wordsToReverse)}");

            wordsToReverse = "This is the second sentence in the method";
            Debug.WriteLine($"\n{wordsToReverse} => {wordOrderReverser.ReverseOrder(wordsToReverse)}");

            wordsToReverse = "This third sentence follows previous, the second one";
            Debug.WriteLine($"\n{wordsToReverse} => {wordOrderReverser.ReverseOrder(wordsToReverse)}");
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