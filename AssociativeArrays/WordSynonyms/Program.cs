using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymsMap = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (!synonymsMap.ContainsKey(key))
                {
                    synonymsMap.Add(key, new List<string>());
                }

                synonymsMap[key].Add(value);

            }

            foreach (var item in synonymsMap)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
