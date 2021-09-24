using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAndNumberDataConverter
{    public class WordOrderReverser
    {
        public string ReverseOrder(string source)
        {
            var lines = source.Split(' ').Reverse();
            return string.Join(" ", lines);
        }
    }
}
