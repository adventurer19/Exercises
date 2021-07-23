using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;



namespace Classes
{


    class Program
    {

        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<int> sorted = num.OrderByDescending(x => x).ToList();

            if (sorted.Count < 3)
                sorted.ForEach(x => Console.Write(x + " "));
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }

            }

        }


    }

}