using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] wordsArray = input.Split();

            Dictionary<String, int> wordCounterMap = new Dictionary<string, int>();

            foreach (var word in wordsArray)
            {

                if (!wordCounterMap.ContainsKey(word))
                {
                    wordCounterMap.Add(word, 1);
                }
                else
                {
                    wordCounterMap[word]++;
                }
            }

            var filteredMap = wordCounterMap.Where(x => x.Value % 2 == 1).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(string.Join(" ", filteredMap.Keys));
        }
    }
}
