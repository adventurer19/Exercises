using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using Console = System.Console;


namespace Classes
{


    class Program
    {

        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var idx in numbers)
            {
                if (counts.ContainsKey(idx))
                {
                    counts[idx]++;
                }
                else
                {
                    counts.Add(idx, 1);
                }
            }

            foreach (var idxCount in counts)
            {
                if (idxCount.Value % 2 != 0)
                    Console.Write($"{idxCount.Key} ");

            }

        }


    }

}