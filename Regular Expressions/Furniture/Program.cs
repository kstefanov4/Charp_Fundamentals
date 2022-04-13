using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<furniture>\w+)<<(?<price>[0-9]+\.?[0-9]*)!(?<quontity>[0-9]+)";

            string input = Console.ReadLine();
            List<string> furnitureList = new List<string>();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, regex);

                foreach (Match match in matches)
                {
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quontity = int.Parse(match.Groups["quontity"].Value);
                    furnitureList.Add(furniture);
                    totalPrice += price * quontity;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            furnitureList.ForEach(e => Console.WriteLine(e));
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
