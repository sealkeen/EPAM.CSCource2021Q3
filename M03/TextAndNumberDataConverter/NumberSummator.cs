using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace TextAndNumberDataConverter
{
    public class NumberSummator
    {
        public string SumNumbers(string left, string right)
        {
            var leftNumberParts = GetStringSplitByReminder(left);
            var rightNumberParts = GetStringSplitByReminder(right);
            var integer = SumInts(leftNumberParts[0], rightNumberParts[0]);
            var fraction = SumInts(leftNumberParts[1], rightNumberParts[1], true);

            return integer + "." + fraction;
        }
        private int GetCountOfCertainChars(string s, char targetChar)
        {
            var count = 0;
            foreach (char ch in s)
            {
                if (ch == targetChar)
                {
                    count++;
                }
            }
            return count;
        }
        private string[] GetStringSplitByReminder(string source)
        {
            var countOfCommas = 0;
            if ((countOfCommas = GetCountOfCertainChars(source, ',') ) >= 1)
            {
                return source.Split(',').Take(2).ToArray();
            } else if ((countOfCommas = GetCountOfCertainChars(source, '.')) >= 1)
            {
                return source.Split('.').Take(2).ToArray();
            }
            return new string[] { source, "0" };
        }
        public string SumInts(string left, string right, bool fraction = false)
        {
            if (left.Length > right.Length)
            {
                right = fraction ? 
                    right.PadRight(left.Length, '0') : 
                    right.PadLeft(left.Length, '0');
            }
            else if (right.Length > left.Length)
            {
                left = fraction ?
                    left.PadRight(right.Length, '0') :
                    left.PadLeft(right.Length, '0');
            }
            
            Stack<char> result = new Stack<char>();
            char current = '0'; var pending = 0;
            for (int i = left.Length -1 ; i >= 0 ; i--)
            {
                current = (char)(left[i] - '0' + (right[i] - '0' + pending));
                if (current > 9)
                {
                    pending = 1;
                    current = (char)(current % 10);
                    result.Push((char)(current + '0'));
                    continue;
                }
                result.Push((char)(current + '0'));
                pending = 0;
            }
            return new string(result.ToArray());
        }
    }
}
