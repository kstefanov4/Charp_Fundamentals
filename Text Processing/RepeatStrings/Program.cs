using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();

            foreach (var word in inputArray)
            {
                printWord(word);
            }
        }

        private static void printWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word);
            }
        }
    }
}
