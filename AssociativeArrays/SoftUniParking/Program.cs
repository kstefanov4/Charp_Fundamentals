using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingMap = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string command = input.Split()[0];
                string name = input.Split()[1];

                switch (command)
                {                   
                    case "register":
                        string licence = input.Split()[2];
                        if (parkingMap.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkingMap[name]}");
                        }
                        else
                        {
                            parkingMap.Add(name, licence);
                            Console.WriteLine($"{name} registered {licence} successfully");
                        }
                        break;
                    case "unregister":
                        if (!parkingMap.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            parkingMap.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var item in parkingMap)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
