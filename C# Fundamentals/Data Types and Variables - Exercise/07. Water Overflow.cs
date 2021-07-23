using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int liters = 0;
            for (int i = 0; i < num; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (liters + x > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    liters += x;

                }
            }
            Console.WriteLine(liters);


        }
    }
}