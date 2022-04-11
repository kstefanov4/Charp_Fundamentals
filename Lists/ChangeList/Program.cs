using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArray = input.Split();
                string command = commandArray[0];
                int num = int.Parse(commandArray[1]);

                switch (command)
                {
                    case "Delete":
                        numList.RemoveAll(x => x == num);
                        break;

                    case "Insert":
                        int index = int.Parse(commandArray[2]);
                        numList.Insert(index, num);
                        break;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numList));

        }
    }
}
