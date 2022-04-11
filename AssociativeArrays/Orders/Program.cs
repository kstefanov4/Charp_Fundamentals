using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> priceMap = new Dictionary<string, double>();
            Dictionary<string, int> quantityMap = new Dictionary<string, int>();

            while (input != "buy")
            {
                string product = input.Split()[0];
                double price = double.Parse(input.Split()[1]);
                int quantity = int.Parse(input.Split()[2]);

                priceMap[product] = price;

                if (!quantityMap.ContainsKey(product))
                {
                    quantityMap.Add(product, quantity);
                }
                else
                {
                    quantityMap[product] += quantity;
                }


                input = Console.ReadLine();
            }

            foreach (var item in priceMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * quantityMap[item.Key]:f2}");
            }
        }
    }
}
