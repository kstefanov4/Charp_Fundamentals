using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = arrNum[0];
            int offSet = arrNum[1];

            while (numList.Contains(bomb))
            {
                int indexBomb = numList.IndexOf(bomb);

                int left = Math.Max(0, indexBomb - offSet);
                int right = Math.Min(numList.Count - 1, indexBomb + offSet);

                for (int i = right; i >= left; i--)
                {
                    numList.RemoveAt(i);
                }
            }
            int sum = 0;
            foreach (var num in numList)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
