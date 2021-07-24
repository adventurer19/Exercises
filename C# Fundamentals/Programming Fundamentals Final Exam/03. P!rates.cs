using System;
using System.Collections.Generic;
using System.Linq;

namespace P_irates
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var book = new Dictionary<string, int[]>();
            TakeData(line, book);
            line = Console.ReadLine();
            Events(line, book);
            Print(book);

        }

        private static void Print(Dictionary<string, int[]> book)
        {
            if (book.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                var sorted = book.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key)
                    .ToDictionary(t => t.Key, t => t.Value);
                Console.WriteLine($"Ahoy, Captain! There are {sorted.Count} wealthy settlements to go to:");
                foreach (var city in sorted)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
        }

        private static void Events(string line, Dictionary<string, int[]> book)
        {
            while (line != "End")
            {

                var token = line.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var operation = token[0];
                var town = token[1];
                if (!book.ContainsKey(town)) continue;
                var population = int.Parse(token[2]);
                int gold = 0;
                if (token.Length == 4)
                {
                    gold = int.Parse(token[3]);
                }
                else
                {
                    gold = population;
                }

                switch (token[0])
                {
                    case "Plunder":
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                        book[town][0] -= population;
                        book[town][1] -= gold;
                        bool vanish = book[town][0] <= 0 || book[town][1] <= 0;
                        if (vanish)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            book.Remove(town);
                        }
                        break;
                    case "Prosper":
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }

                        book[town][1] += gold;
                        Console.WriteLine(
                            $"{gold} gold added to the city treasury. {town} now has {book[town][1]} gold.");
                        break;
                }

                line = Console.ReadLine();
            }
        }

        private static void TakeData(string line, Dictionary<string, int[]> book)
        {
            while (line != "Sail")
            {
                var token = line.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var city = token[0];
                int population = int.Parse(token[1]);
                int gold = int.Parse(token[2]);
                if (!book.ContainsKey(city))
                {
                    book.Add(city, new int[2] { population, gold });
                }
                else
                {
                    book[city][0] += population;
                    book[city][1] += gold;
                }

                line = Console.ReadLine();
            }
        }
    }
}
