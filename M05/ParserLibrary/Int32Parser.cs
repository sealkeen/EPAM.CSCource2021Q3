using System;
using System.Text.RegularExpressions;
namespace ParserLibrary
{
    public class Int32Parser
    {
        private const int _maxLengthInt32 = 10;
        private const int digitASCIIOffset = 48;
        public int Parse(string source) {
            var trimmed = source.Trim();
            var negative = false;
            if ( !Regex.IsMatch(source, @"-?\d{1,10}" )) // {-9999999999 : 9999999999}
                throw new ArgumentException();
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
                var value  = trimmed[i] - digitASCIIOffset;
                var tenInPower = Math.Pow(10, power);
                result += (int)(value * tenInPower);
            }

            if (negative)
                result *= -1;

            return result;
        }
    }
}
