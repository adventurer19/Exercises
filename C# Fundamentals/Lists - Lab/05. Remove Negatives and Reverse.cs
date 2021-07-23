using System;
using System.Linq;
using System.Collections.Generic;


namespace Fundamentals
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).Where(n => n >= 0).Reverse().ToList();
            if (input.Count == 0)
            { Console.WriteLine("empty"); }
            else
            {
                Console.WriteLine(string.Join(' ', input));

            }


        }
    }
}