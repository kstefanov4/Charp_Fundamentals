using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> numDic = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numDic.ContainsKey(number))
                {
                    numDic[number] = 1;
                }
                else
                {
                    numDic[number]++;
                }
            }

            foreach (var num in numDic)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
