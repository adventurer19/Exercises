using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var languagePlusName = new Dictionary<string, List<string>>();
        var namePlusGrade = new Dictionary<string, List<double>>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exam finished") break;
            string[] parts = input.Split('-');
            //"{username}-{language}-{points}" 
            if (parts[1] == "banned")
            {
                ////"{username}-banned". 
                string name = parts[0];
                namePlusGrade.Remove(name);
            }
            else
            {
                string name = parts[0];
                string type = parts[1];
                double grade = double.Parse(parts[2]);
                if (!languagePlusName.ContainsKey(type)) // C++ GOSHO 6:00 csharp nqmame obache gosho ima veche ocenka c++/6:00 
                {
                    languagePlusName.Add(type, new List<string>());
                    languagePlusName[type].Add(name);
                    if (!namePlusGrade.ContainsKey(name))
                    {
                        namePlusGrade.Add(name, new List<double>());
                    }
                    namePlusGrade[name].Add(grade);
                }
                else
                {
                    if (!namePlusGrade.ContainsKey(name))
                    {
                        namePlusGrade.Add(name, new List<double>());
                    }
                    languagePlusName[type].Add(name);
                    namePlusGrade[name].Add(grade);
                }
            }
        }
        Console.WriteLine($"Results:");
        foreach (var idx in namePlusGrade
            .OrderByDescending(x => x.Value.Max()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{idx.Key} | {idx.Value.Max()}");
        }
        Console.WriteLine($"Submissions:");
        foreach (var idx in languagePlusName
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key))

        {
            Console.WriteLine($"{idx.Key} - {idx.Value.Count}");
        }



    }
}