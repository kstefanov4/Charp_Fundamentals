﻿using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {
                Console.WriteLine(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
