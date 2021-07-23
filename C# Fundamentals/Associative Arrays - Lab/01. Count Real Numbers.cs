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
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var idxNumber in numbers)
            {
                if (counts.ContainsKey(idxNumber))
                {
                    counts[idxNumber]++;
                }
                else
                {
                    counts.Add(idxNumber, 1);
                }
            }

            foreach (var idx in counts)
            {
                Console.WriteLine($"{idx.Key} -> {idx.Value}");
            }


        }


    }

}