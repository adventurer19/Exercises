using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            int commands = int.Parse(Console.ReadLine());
            //List <int> input = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();
            List<string> names = new List<string>();
            for (int i = 0; i < commands; i++)
            {
                string line = Console.ReadLine();
                string[] x = line.Split(' ');
                if (x.Length == 3)
                {


                    if (!names.Contains(x[0]))
                    {
                        names.Add(x[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{x[0]} is already in the list!");
                    }
                }
                else
                {
                    if (!names.Contains(x[0])) Console.WriteLine($"{x[0]} is not in the list!");
                    else
                    {
                        names.Remove(x[0]);

                    }

                }
            }

            Console.WriteLine(string.Join('\n', names));
        }


    }

}