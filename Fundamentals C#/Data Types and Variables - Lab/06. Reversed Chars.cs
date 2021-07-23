using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            decimal outputNumber = inputNumber / 1000M;
            Console.WriteLine($"{outputNumber:f2}");

        }
    }
}