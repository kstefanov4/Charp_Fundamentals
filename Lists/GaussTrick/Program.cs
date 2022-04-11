using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int lenght = numList.Count / 2;

            for (int i = 0; i < lenght; i++)
            {
                int sum = numList[i] + numList[numList.Count - 1];
                numList.RemoveAt(i);
                numList.Insert(i, sum);
                numList.RemoveAt(numList.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
