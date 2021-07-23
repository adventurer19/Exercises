using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace traning_2
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger factorial = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

    }
}