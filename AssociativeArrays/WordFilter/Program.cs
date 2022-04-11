using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
