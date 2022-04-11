using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>();

            for (int i = 0; i < num; i++)
            {
                productList.Add(Console.ReadLine());
            }
            productList.Sort();

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productList[i]} ");
            }
        }
    }
}
