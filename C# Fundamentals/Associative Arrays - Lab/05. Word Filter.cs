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
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<string> result = input
                .Where(x => x.Length % 2 == 0)
                .ToList();
            result.ForEach(t => Console.WriteLine(t));
        }


    }

}