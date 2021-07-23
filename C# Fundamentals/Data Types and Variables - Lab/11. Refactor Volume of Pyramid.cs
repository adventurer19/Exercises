using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal heigth = decimal.Parse(Console.ReadLine());
            decimal v = length * width * heigth / 3M;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {v:f2}");
        }
    }
}