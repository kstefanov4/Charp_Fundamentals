using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(", ");

            foreach (var input in inputArray)
            {
                if (isValid(input))
                {
                    Console.WriteLine(input);
                }
            }
        }

        private static bool isValid(string input)
        {
            if (input.Length < 3 || input.Length > 16)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
