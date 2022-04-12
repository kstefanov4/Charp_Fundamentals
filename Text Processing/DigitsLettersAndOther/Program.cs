using System;
using System.Collections.Generic;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();

            List<char> lettersList = new List<char>();
            List<char> digitsList = new List<char>();
            List<char> otherList = new List<char>();

            foreach (var symbol in charArray)
            {
                if (char.IsLetter(symbol))
                {
                    lettersList.Add(symbol);
                }
                else if (char.IsDigit(symbol))
                {
                    digitsList.Add(symbol);
                }
                else
                {
                    otherList.Add(symbol);
                }
            }

            printArraya(digitsList);
            printArraya(lettersList);
            printArraya(otherList);
        }

        private static void printArraya(List<char> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
