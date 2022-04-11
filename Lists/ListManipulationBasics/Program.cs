using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArray = input.Split();
                string command = inputArray[0];
                int number = int.Parse(inputArray[1]);

                switch (command)
                {
                    case "Add":
                        numList.Add(number);
                        break;
                    case "Remove":
                        numList.Remove(number);
                        break;
                    case "RemoveAt":
                        numList.RemoveAt(number);
                        break;
                    case "Insert":
                        int index = int.Parse(inputArray[2]);
                        numList.Insert(index, number);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
