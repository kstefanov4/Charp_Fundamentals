using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (var item in charArray)
            {
                if (item != ' ')
                {
                    if (!charMap.ContainsKey(item))
                    {
                        charMap.Add(item, 1);
                    }
                    else
                    {
                        charMap[item]++;
                    }
                }
            }

            foreach (var item in charMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
