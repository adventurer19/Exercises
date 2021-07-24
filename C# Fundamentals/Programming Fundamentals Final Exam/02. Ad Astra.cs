using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace example
{
    class Program
    {
        static void Main()
        {
            List<Pianist> all = new List<Pianist>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("|").ToArray();
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                all.Add(new Pianist(piece, composer, key));
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Stop") break;
                string[] parts = line.Split("|").ToArray();
                string x = parts[0];
                if (x == "Add")
                {
                    string piece = parts[1];
                    string composer = parts[2];
                    string key = parts[3];
                    if (all.Find(x => x.piece == piece) == null)
                    {
                        all.Add(new Pianist(piece, composer, key));
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (x == "Remove")
                {
                    string piece = parts[1];
                    var pianist = all.Find(x => x.piece == piece);
                    if (pianist == null)
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        all.Remove(pianist);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }
                else if (x == "ChangeKey")
                {
                    string piece = parts[1];
                    string newKey = parts[2];
                    var pianist = all.Find(x => x.piece == piece);
                    if (pianist == null)
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pianist.key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }

                }
            }

            var sorted = all.OrderBy(x => x.piece).ThenBy(x => x.composer).ToList();
            sorted.ForEach(x => Console.WriteLine(x));

        }

        class Pianist
        {
            public Pianist(string piece, string composer, string key)
            {
                this.piece = piece;
                this.composer = composer;
                this.key = key;
            }
            public string piece { get; set; }
            public string composer { get; set; }
            public string key { get; set; }


            public override string ToString()
            {
                return $"{piece} -> Composer: {composer}, Key: {key}";
            }
        }


    }













}