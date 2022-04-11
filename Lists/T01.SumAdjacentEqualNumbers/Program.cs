using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numList = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i] == numList[i + 1])
                {
                    double sum = numList[i] + numList[i + 1];
                    numList.RemoveAt(i + 1);
                    numList.RemoveAt(i);
                    numList.Insert(i, sum);
                    i = -1;

                }
            }

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
