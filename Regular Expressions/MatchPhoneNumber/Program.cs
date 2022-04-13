using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([- ])2\1[\d]{3}\1[\d]{4}\b";
            string input = Console.ReadLine();

            MatchCollection matchedNumbers = Regex.Matches(input, regex);

            var matched = matchedNumbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matched));
        }
    }
}
