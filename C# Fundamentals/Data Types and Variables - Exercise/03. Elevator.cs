using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {

            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            double x = Math.Ceiling(1.0 * numberOfPeople / elevatorCapacity);
            Console.WriteLine(x);

        }
    }
}