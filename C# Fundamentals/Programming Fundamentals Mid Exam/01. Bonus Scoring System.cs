using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            uint students = uint.Parse(Console.ReadLine());
            uint lectures = uint.Parse(Console.ReadLine());
            uint bonus = uint.Parse(Console.ReadLine());
            double result = 0;
            double max = double.MinValue;
            uint mostwanted = 0;
            for (int i = 0; i < students; i++)
            {
                uint attendances = uint.Parse(Console.ReadLine());
                double extra = (1.0 * attendances / lectures) * (5 + bonus);
                if (extra > max)
                {
                    max = extra;
                    result = max;
                    mostwanted = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(result)}.");
            Console.WriteLine($"The student has attended {mostwanted} lectures.");
        }


    }
}