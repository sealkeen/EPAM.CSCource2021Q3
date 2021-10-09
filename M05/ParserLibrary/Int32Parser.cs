using System;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace ParserLibrary
{
    public class Int32Parser : IDisposable
    {
        public const int MaxLengthInt32 = 10;
        public const int DigitASCIIOffset = 48;
        private const string NotAnIntegerErrorMessage = 
            "Parse() Error: The argument string source was not of integer type.";
        private const string ArgumentNullErrorMessage = "The parsing argument was null.";
        Microsoft.Extensions.Logging.ILogger _iLogger;

        public Int32Parser(ILogger<Int32Parser> iLogger)
        {
            _iLogger = iLogger;
        }

        public void Dispose()
        {
            // No unmanaged resources used in this class
        }

        public int Parse(string source) {
            CheckForNullOrEmptiness(ref source);
            var trimmed = source.Trim();
            var negative = false;
            CheckForIntegerValue(source); 
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

        public void CheckForIntegerValue(string value)
        {
            int startIndex = 0;
            if (value[0] == '-')
            {
                if (value.Length >= 2 && !char.IsDigit(value[1]))
                {
                    _iLogger.LogError(NotAnIntegerErrorMessage + " Value:" + value);
                    //throw new ArgumentException(NotAnIntegerErrorMessage); //return false;
                }
                startIndex = 1;
            }
            for (int i = startIndex; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    _iLogger.LogError(NotAnIntegerErrorMessage + " Value:" + value);
                    //throw new ArgumentException(NotAnIntegerErrorMessage); //return false;
                }
            }
        }

        public void CheckForNullOrEmptiness(ref string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                _iLogger.LogError(ArgumentNullErrorMessage);
                //throw new ArgumentNullException(ArgumentNullErrorMessage);
            }
        }
    }
}
