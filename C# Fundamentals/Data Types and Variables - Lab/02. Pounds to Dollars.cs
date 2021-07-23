using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            //1 British Pound = 1.31 Dollars
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            decimal dollars = inputNumber * 1.31M;
            Console.WriteLine($"{dollars:f3}");

        }
    }
}