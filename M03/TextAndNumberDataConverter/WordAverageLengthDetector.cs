using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TextAndNumberDataConverter
{
    public class WordAverageLengthDetector
    {
        public double GetAverageLength(string source)
        {
            var words = new string(source.Where(c => !char.IsPunctuation(c)).ToArray()).Split(" ");
            var wordLengthQueue = from string word in words select word.Length;
            var wordLengths = 0.0;
            foreach (var length in wordLengthQueue)
            {
                wordLengths += length;
            }

            return wordLengths /= wordLengthQueue.Count();
        }
    }
}
