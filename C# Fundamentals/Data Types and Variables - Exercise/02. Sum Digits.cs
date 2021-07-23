using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {

            int num1 = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            while (num1 > 0)
            {
                int digit = num1 % 10;
                sumOfDigits += digit;
                num1 /= 10;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}