﻿using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char newChar = (char)(input[i] + 3);
                sb.Append(newChar);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
