using System;
using System.Numerics;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            firstNum = firstNum * secondNum;

            Console.WriteLine(firstNum);
        }
    }
}
