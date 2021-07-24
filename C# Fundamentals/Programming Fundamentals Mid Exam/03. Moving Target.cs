using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split().ToArray();
            int index = int.Parse(parts[1]);
            if (parts[0] == "Shoot")
            {
                int power = int.Parse(parts[2]);
                if (index >= 0 && index < numbers.Count)
                {
                    numbers[index] -= power;
                    if (numbers[index] <= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                }
            }
            else if (parts[0] == "Add")
            {
                int value = int.Parse(parts[2]);
                if (index >= 0 && index < numbers.Count)
                {
                    numbers.Insert(index, value);
                }
                else
                {
                    Console.WriteLine("Invalid placement!");
                }
            }
            else if (parts[0] == "Strike")
            {
                int radius = int.Parse(parts[2]);
                int start = index - radius;
                int end = index + radius;
                if (start >= 0 && end < numbers.Count)
                {
                    numbers.RemoveRange(start, radius * 2 + 1);
                }
                else
                {
                    Console.WriteLine($"Strike missed!");
                }
            }
        }
        Console.WriteLine(string.Join("|", numbers));

    }
}