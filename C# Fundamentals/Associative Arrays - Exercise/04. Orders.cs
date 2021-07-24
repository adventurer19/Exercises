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
            var byPrice = new Dictionary<string, decimal>();
            var byQuantity = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "buy") break;
                var input = GetValue(line);
                if (byPrice.ContainsKey(input.Item1))
                {
                    byPrice[input.Item1] = input.Item2;
                    byQuantity[input.Item1] += input.Item3;
                }
                else
                {
                    byPrice.Add(input.Item1, input.Item2);
                    byQuantity.Add(input.Item1, input.Item3);
                }

            }

            foreach (var idx in byPrice)
            {
                Console.WriteLine($"{idx.Key} -> {idx.Value * byQuantity[idx.Key]}");
            }

        }

        private static (string, decimal, int) GetValue(string input)
        {
            string[] tokens = input.Split(' ').ToArray();
            string product = tokens[0];
            decimal price = decimal.Parse(tokens[1]);
            int quantity = int.Parse(tokens[2]);
            return (product, price, quantity);



        }
    }
}

//var weapons = new Dictionary<string, int>
//{
//    {"shards", 0},
//    {"fragments",0},
//    {"motes",0}

//};
//var junk = new Dictionary<string, int>();

////Shadowmourne - requires 250 Shards;
////Valanyr - requires 250 Fragments;
////Dragonwrath - requires 250 Motes;

//while (true)
//{
//    string input = Console.ReadLine();
//    bool Exit = weapons.Any(x => x.Value >= 250);
//    if (Exit) break;
//    string[] tokens = input.    


//}