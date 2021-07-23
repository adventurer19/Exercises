using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            //1 British Pound = 1.31 Dollars
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {

                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}