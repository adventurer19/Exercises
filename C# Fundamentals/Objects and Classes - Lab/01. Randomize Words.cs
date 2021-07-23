using System;
using System.Linq;
using System.Collections.Generic;

namespace traning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(words.Length);
                string word = words[i];
                words[i] = words[pos];
                words[pos] = word;
            }

            Console.WriteLine(string.Join('\n', words));
        }
    }
}