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
            var x = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] parts = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (parts[0] == "end") break;
                if (x.ContainsKey(parts[0]))
                {
                    x[parts[0]].Add(parts[1]);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(parts[1]);
                    x.Add(parts[0], list);
                }
            }

            x = x.OrderByDescending(t => t.Value.Count)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var idx in x)
            {
                Console.WriteLine($"{idx.Key}: {idx.Value.Count}");
                foreach (var j in idx.Value.OrderBy(t => t))
                {
                    Console.WriteLine($"-- {j}");
                }
            }
        }
    }
}