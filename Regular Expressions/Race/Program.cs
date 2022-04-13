using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameRegex = @"[A-Za-z]";
            string runRegex = @"[0-9]";

            string[] racers = Console.ReadLine().Split(", ");
            Dictionary<string, int> raceMap = new Dictionary<string, int>();
            foreach (var racer in racers)
            {
                raceMap.Add(racer, 0);
            }

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection nameMatcher = Regex.Matches(input, nameRegex);
                StringBuilder name = new StringBuilder();
                int km = 0;

                foreach (Match letter in nameMatcher)
                {
                    name.Append(letter.Value);
                }

                MatchCollection runMatcher = Regex.Matches(input, runRegex);
                foreach (Match kmRun in runMatcher)
                {
                    km += int.Parse(kmRun.Value);
                }

                if (raceMap.ContainsKey(name.ToString()))
                {
                    int currentKM = raceMap[name.ToString()];
                    raceMap[name.ToString()] = km + currentKM;
                }

                input = Console.ReadLine();
            }

            Dictionary<string,int> result = raceMap.OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x=>x.Key,v=>v.Value);
            var winners = result.Keys.ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }
    }
}
