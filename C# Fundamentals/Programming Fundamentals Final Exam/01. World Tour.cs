using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] part = input.Split(":").ToArray();
                if (part[0] == "Add Stop")
                {
                    int index = int.Parse(part[1]);
                    string givenString = part[2];
                    if (index >= 0 && index < line.Length)
                    {
                        line = line.Insert(index, givenString);
                    }
                }
                else if (part[0] == "Remove Stop")
                {
                    int start = int.Parse(part[1]);
                    int end = int.Parse(part[2]);
                    bool valid = start >= 0 && start < line.Length && end >= 0 && end < line.Length;
                    if (valid)
                    {
                        int counter = end - start + 1;
                        line = line.Remove(start, counter);
                    }

                }
                else if (part[0] == "Switch")
                {
                    string oldString = part[1];
                    string newString = part[2];
                    if (line.Contains(oldString))
                    {
                        line = line.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(line);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {line}");
        }
    }


}