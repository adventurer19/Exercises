using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;



namespace Classes
{


    class Program
    {

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var counts = new Dictionary<string, List<string>>();
            List<string> synonyms = new List<string>();
            for (int i = 0; i < num; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, new List<string>() { synonym });
                }
                else
                {
                    counts[word].Add(synonym);
                }
            }

            foreach (var idx in counts)
            {
                Console.WriteLine($"{idx.Key} - {string.Join(", ", idx.Value)}");
            }

        }


    }

}