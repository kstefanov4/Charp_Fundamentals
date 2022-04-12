using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();

            string firstWord = inputArray[0];
            string secondWord = inputArray[1];

            int sum = getSumOfAllChar(firstWord, secondWord);
            Console.WriteLine(sum);
        }

        private static int getSumOfAllChar(string firstWord, string secondWord)
        {
            int sum = 0;
            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            int maxLenght = Math.Max(firstWord.Length, secondWord.Length);
            string longestWord = "";

            if (firstWord.Length == maxLenght)
            {
                longestWord = firstWord;
            }
            else
            {
                longestWord = secondWord;
            }

            for (int i = 0; i < minLenght; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }
            for (int i = minLenght; i < maxLenght; i++)
            {
                sum += longestWord[i];
            }

            return sum;

        }
    }
}
