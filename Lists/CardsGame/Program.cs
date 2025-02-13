﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isEmpty = false;

            while (!isEmpty)
            {

                if (firstList[0] > secondList[0])
                {
                    firstList.Add(firstList[0]);
                    firstList.Add(secondList[0]);
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }
                else if (firstList[0] < secondList[0])
                {
                    secondList.Add(secondList[0]);
                    secondList.Add(firstList[0]);
                    secondList.RemoveAt(0);
                    firstList.RemoveAt(0);

                }
                else if (firstList[0] == secondList[0])
                {
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }

                if (firstList.Count == 0 || secondList.Count == 0)
                {
                    isEmpty = true;
                }

            }

            int sum = 0;
            if (firstList.Count == 0)
            {
                foreach (var num in secondList)
                {
                    sum += num;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                foreach (var num in firstList)
                {
                    sum += num;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
