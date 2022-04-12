using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string word = Console.ReadLine();

            int indexOf = 0;
            int wordLenght = keyWord.Length;

            while (indexOf != -1)
            {
                indexOf = word.IndexOf(keyWord);
                if (indexOf == -1)
                {
                    break;
                }
                word = word.Remove(indexOf, wordLenght);
            }
            Console.WriteLine(word);
        }
    }
}
