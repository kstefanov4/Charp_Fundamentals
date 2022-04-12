using System;
using System.Text;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannerWordsArray = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannerWordsArray)
            {
                string cryptedWord = getCryptedWord(word);
                text = text.Replace(word, cryptedWord);
            }
            Console.WriteLine(text);
        }

        private static string getCryptedWord(string word)
        {
            string banWord = "";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                sb.Append("*");
            }
            banWord = sb.ToString();
            return banWord;
        }
    }
}
