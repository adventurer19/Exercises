using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");

        }
    }
}