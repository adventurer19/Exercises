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
            var book = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] line = Console.ReadLine().
                    Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (line[0] == "End") break;
                for (int i = 0; i < line.Length; i += 2)
                {
                    line[i].Trim(); // key
                    line[i + 1].Trim(); // value
                    if (book.ContainsKey(line[i]))
                    {
                        if (!book[line[i]].Contains(line[i + 1]))
                        {
                            book[line[i]].Add(line[i + 1]);
                            continue;
                        }
                    }
                    else
                    {
                        var newList = new List<string>();
                        newList.Add(line[i + 1]);
                        book.Add(line[i], newList);
                    }
                }

            }

            book = book.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var idx in book)
            {
                Console.WriteLine($"{idx.Key}");
                foreach (var idx1 in idx.Value)
                {
                    Console.WriteLine($"-- {idx1}");
                }
            }
            //"{companyName} -> {employeeId}".

        }
    }
}