using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
using System.Xml;

namespace example
{
    class Program
    {
        static void Main()
        {
            List<Plant> plants = new List<Plant>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plant = input[0];
                int rarity = int.Parse(input[1]);
                if (plants.Find(x => x.plant == plant) == null)
                {
                    plants.Add(new Plant
                    {
                        plant = plant,
                        rarity = rarity
                    });
                }
                else
                {
                    var curPlant = plants.Find(x => x.plant == plant);
                    curPlant.rarity = rarity;

                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Exhibition") break;
                string[] tokens = line.Split(new char[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string x = tokens[0];
                string plant = tokens[1];
                if (plants.Exists(x => x.plant == plant))
                {
                    var curPlannt = plants.Find(x => x.plant == plant);
                    if (x == "Rate")
                    {
                        int rate = int.Parse(tokens[2]);
                        curPlannt.rating.Add(rate);
                    }
                    else if (x == "Update")
                    {
                        int rate = int.Parse(tokens[2]);
                        // var curPlannt = plants.Find(x => x.plant == plant);
                        curPlannt.rarity = rate;
                    }
                    else if (x == "Reset")
                    {
                        // var curPlannt = plants.Find(x => x.plant == plant);
                        curPlannt.rating.Clear();
                    }


                }
                else
                {
                    Console.WriteLine("error");
                }


            }

            Console.WriteLine($"Plants for the exhibition:");
            var sorted = plants.OrderByDescending(x => x.rarity).ThenByDescending(x => x.Avg).ToList();
            sorted.ForEach(x => Console.WriteLine(x));

        }


    }




    class Plant
    {
        public string plant { get; set; }
        public int rarity { get; set; }
        public List<double> rating { get; set; }

        public double Avg => calc();

        public Plant()
        {
            rating = new List<double>();
        }

        public double calc()
        {
            double x = 0;
            if (rating.Count > 0)
            {
                x = rating.Average();
            }

            return x;

        }

        public override string ToString()
        {
            return $"- {plant}; Rarity: {rarity}; Rating: {Avg:f2}";

        }
    }







}