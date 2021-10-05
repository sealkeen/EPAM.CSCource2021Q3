using System;
using System.Text.RegularExpressions;
namespace ParserLibrary
{
    public class Int32Parser
    {
        public const int MaxLengthInt32 = 10;
        public const int DigitASCIIOffset = 48;
        public int Parse(string source) {
            var trimmed = source.Trim();
            var negative = false;
            if ( !Regex.IsMatch(source, @"-?\d{1,10}" )) // {-9999999999 : 9999999999}
                throw new ArgumentException("Parse() Error: The argument string source was not of integer type.");
            if ( trimmed[0] == '-' )
            {
                negative = true;
                trimmed = trimmed.Substring(1);
            }
            
            var result = 0;
            var lastIndex = trimmed.Length - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                var power = (lastIndex - i);
                var value  = trimmed[i] - DigitASCIIOffset;
                var tenInPower = Math.Pow(10, power);
                result += (int)(value * tenInPower);
            }

            if (negative)
                result *= -1;

            return result;
        }
    }
}
