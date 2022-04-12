using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputArray = Console.ReadLine().ToCharArray();
            Console.Write(inputArray[0]);

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] != inputArray[i-1])
                {
                    Console.Write(inputArray[i]);
                }
            }
        }
    }
}
