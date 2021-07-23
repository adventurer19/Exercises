using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            for (int i = 0; i < num; i++)
            {
                char x = char.Parse(Console.ReadLine());
                sumOfChars += (int)x;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}