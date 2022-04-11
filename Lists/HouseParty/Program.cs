using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleList = new List<string>();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                string cmd = input[1];

                if (cmd == "is" && input[2] != "not")
                {
                    if (peopleList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        peopleList.Add(name);
                    }
                }
                else
                {
                    if (peopleList.Contains(name))
                    {
                        peopleList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (var item in peopleList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
