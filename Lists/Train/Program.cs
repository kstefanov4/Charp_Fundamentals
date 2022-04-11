using System;
using System.Collections.Generic;
using System.Linq;

namespace Train

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArray = input.Split();

                if (inputArray.Length > 1)
                {
                    wagonList.Add(int.Parse(inputArray[1]));
                }
                else
                {
                    int passengers = int.Parse(inputArray[0]);
                    for (int i = 0; i < wagonList.Count; i++)
                    {
                        if (wagonList[i] + passengers <= maxCapacity)
                        {
                            wagonList[i] = wagonList[i] + passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagonList));

        }
    }
}
