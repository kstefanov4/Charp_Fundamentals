using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> userMap = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string company = input.Split(" -> ")[0];
                string userID = input.Split(" -> ")[1];

                if (!userMap.ContainsKey(company))
                {
                    userMap.Add(company,new List<string>());

                }
                if (!userMap[company].Contains(userID))
                {
                    userMap[company].Add(userID);
                }

                input = Console.ReadLine();
            }

            foreach (var user in userMap)
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
