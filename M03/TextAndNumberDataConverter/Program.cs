using System;


namespace TextAndNumberDataConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var charDuplicator = new CharacterDuplicator();
            Console.WriteLine(charDuplicator.GetMultipliedCharatersString("How do you like this, Elon Mask?", "lask"));

            var wordLengthDetector = new WordAverageLengthDetector();
            var line = "Average word length in this line is equal to: ";
            Console.WriteLine($"\n{line}{wordLengthDetector.GetAverageLength(line)}\n");

            var numberSummator = new NumberSummator();
            var left = "12.14"; var right = "56.14";
            Console.WriteLine($"Sum of {left} and {right} is {numberSummator.SumNumbers(left, right)}\n");

            var numberExtactor = new PhoneNumberExtractor();
            var phoneNumbersFile = new PhoneNumbersFile("../../../Text.txt");
            var phoneNumbers = numberExtactor.GetListOfPhoneNumbers(phoneNumbersFile.GetAllTextData());
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                Console.WriteLine($"[{i}] {phoneNumbers[i]}");
            }
            phoneNumbersFile.WriteNumbersInFile("Numbers.txt", phoneNumbers);

            var wordOrderReverser = new WordOrderReverser();
            var wordsToReverse = "The greatest victory is that which requires no battle";
            Console.WriteLine($"\n{wordsToReverse} => {wordOrderReverser.ReverseOrder(wordsToReverse)}");

            Console.ReadKey();
        }
    }
}
