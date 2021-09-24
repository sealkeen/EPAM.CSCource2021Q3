using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAndNumberDataConverter
{
    public class CharacterDuplicator
    {
        public string GetMultipliedCharatersString(string source, string modifier)
        {
            var sB = new StringBuilder();
            var modifiers = modifier.Split(' ');
            foreach (var ch in source) 
            {
                if (modifiers.Any(x => x.Contains(ch)))
                {
                    sB.Append(ch);
                }
                sB.Append(ch);
            }

            return sB.ToString();
        }
    }
}
