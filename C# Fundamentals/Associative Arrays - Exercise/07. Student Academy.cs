using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var book = new Dictionary<string, List<double>>();
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            if (book.ContainsKey(input))
            {
                book[input].Add(grade);
            }
            else
            {
                var grades = new List<double>();
                grades.Add(grade);
                book.Add(input, grades);

            }
        }

        var sorted = book.Where(x => x.Value.Average() >= 4.50)
            .OrderByDescending(x => x.Value.Average())
            .ToDictionary(t => t.Key, t => t.Value);
        foreach (var idx in sorted)
        {
            Console.WriteLine($"{idx.Key} -> {idx.Value.Average():f2}");
        }

    }
}