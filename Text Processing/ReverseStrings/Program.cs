using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] charArray = input.ToCharArray();
                List<char> charList = new List<char>();

                foreach (var char1 in charArray)
                {
                    charList.Add(char1);
                }

                charList.Reverse();
                StringBuilder sb = new StringBuilder();
                foreach (var reversedChar in charList)
                {
                    sb.Append(reversedChar);
                }
                string reverseWord = sb.ToString();
                Console.WriteLine(input + " = " + reverseWord);
                input = Console.ReadLine();
            }
        }
    }
}
