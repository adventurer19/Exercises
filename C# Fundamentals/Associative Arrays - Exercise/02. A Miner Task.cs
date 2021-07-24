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
            int counter = 0;
            var book = new Dictionary<string, int>();
            string resource = String.Empty;
            int quantity = 0;
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    resource = input;
                }
                else if (counter % 2 == 0)
                {
                    counter = 0;
                    quantity = int.Parse(input);
                    FillingTheBook(book, resource, quantity);
                }
            }

            foreach (var index in book)
            {
                Console.WriteLine($"{index.Key} -> {index.Value}");
            }
        }

        private static void FillingTheBook(Dictionary<string, int> book, string key, int value)
        {
            if (!book.ContainsKey(key))
                book.Add(key, value);
            else
                book[key] += value;
        }
    }

}