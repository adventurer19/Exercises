using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            while (true)
            {
                string xline = Console.ReadLine();
                string[] line = xline.Split();
                if (xline == "3:1") break;
                if (line[0] == "merge")
                {
                    int startIndex = int.Parse(line[1]);
                    int endIndex = int.Parse(line[2]);
                    if (startIndex < 0) startIndex = 0;
                    if (startIndex >= input.Count || endIndex <= 0)
                    {
                        continue;

                    }
                    //if (endIndex < 0) endIndex = 0;
                    if (endIndex >= input.Count) endIndex = input.Count - 1;
                    if (startIndex < endIndex)
                    {
                        List<string> elements = new List<string>(endIndex + 1);
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.Add(input[i]);

                        }

                        string concat = String.Concat(elements);
                        input.Insert(startIndex, concat);
                        input.RemoveRange(startIndex + 1, elements.Count);
                    }
                }
                else
                {
                    int ind = int.Parse(line[1]);
                    int partitions = int.Parse(line[2]);
                    string current = input[ind];
                    input.RemoveAt(ind);
                    int partitionSize = current.Length / partitions;
                    List<string> substrings = new List<string>();
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = current.Substring(i * partitionSize, partitionSize);
                        substrings.Add(substring);
                    }

                    string last = current.Substring((partitions - 1) * partitionSize);
                    substrings.Add(last);
                    input.InsertRange(ind, substrings);
                }
            }

            Console.WriteLine(string.Join(' ', input));

        }


    }
}