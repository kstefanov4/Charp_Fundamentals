using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> finalList = new List<int>();

            int maxLenght = Math.Max(firstList.Count, secondList.Count);
            int minLenght = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minLenght; i++)
            {
                finalList.Add(firstList[i]);
                finalList.Add(secondList[i]);
            }

            if (firstList.Count > minLenght)
            {
                for (int i = minLenght; i < maxLenght; i++)
                {
                    finalList.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = minLenght; i < maxLenght; i++)
                {
                    finalList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
