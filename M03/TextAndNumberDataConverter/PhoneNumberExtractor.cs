using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextAndNumberDataConverter
{
    public class PhoneNumberExtractor
    {
        const int MaxPhoneNumberLength = 15;
        public List<string> GetListOfPhoneNumbers(string text)
        {
            const string MatchPhonePattern = @"(\+?)(\d{1,3})([ -]?)\(?(\d{1,3})\)?([ -]?)(\d{1,3})([ -]?)(\d{2})([ -]?)(\d{2})";
            var rx = new Regex(MatchPhonePattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Matches(text);
            var noOfMatches = matches.Count;

            var result = matches.Select(match => match.Value).ToList();

            return result;
        }
    }
}
