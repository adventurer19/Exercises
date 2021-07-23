using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace Fundamentals
{
    class Program
    {
        static void Main()
        {
            string values = Console.ReadLine();
            List<int> items = values.Split(' ').Select(int.Parse).ToList();
            int boundry = items.Count;
            for (int i = 0; i < boundry / 2; i++)
            {
                items[i] += items[items.Count - 1];
                items.RemoveAt(items.Count - 1);



            }
            Console.WriteLine(string.Join(' ', items));


        }
    }
}