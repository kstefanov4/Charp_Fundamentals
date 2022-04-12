using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split("\\");

            string word = inputArray[inputArray.Length - 1];
            string[] lastWord = word.Split('.');
            string fileName = lastWord[0];
            string extension = lastWord[1];

            Console.WriteLine("File name: " + fileName);
            Console.WriteLine("File extension: " + extension);
        }
    }
}
