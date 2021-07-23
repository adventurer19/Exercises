using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            bool[] field = new bool[size];
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var index in array)
            {
                if (index < 0 || index >= field.Length) { continue; }
                field[index] = true;
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end") break;
                string[] input = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(input[0]);
                string position = input[1];
                int lenght = int.Parse(input[2]);
                if (index < 0 || index >= field.Length || !field[index]) { continue; }
                field[index] = false;
                while (true)
                {
                    if (position == "right")
                    {
                        index += lenght;
                    }
                    else
                    {
                        index -= lenght;
                    }

                    if (index >= field.Length || index < 0)
                    { break; }


                    if (!field[index])
                    {
                        field[index] = true;
                        break;
                    }
                }



            }
            foreach (var cell in field)
            {
                if (cell)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }

        }
    }
}