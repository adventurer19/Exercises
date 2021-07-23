using System;
using System.Linq;
using System.Collections.Generic;
namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] initialNumbers = new int[numbers.Count];

            numbers.CopyTo(initialNumbers);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    bool areEqual = Enumerable.SequenceEqual(numbers, initialNumbers);

                    if (!areEqual)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }

                    return;
                }

                string[] tokens = command.Split();
                string firstWordFromCommand = tokens[0];
                switch (firstWordFromCommand)
                {
                    case "Add":
                        int number1 = int.Parse(tokens[1]);
                        numbers.Add(number1);
                        break;
                    case "Remove":
                        int number2 = int.Parse(tokens[1]);
                        numbers.Remove(number2);
                        break;
                    case "RemoveAt":
                        int number3 = int.Parse(tokens[1]);
                        numbers.RemoveAt(number3);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains":
                        int number = int.Parse(tokens[1]);

                        string contains = numbers.Any(x => x == number) ? "Yes" : "No such number";

                        Console.WriteLine(contains);

                        break;
                    case "PrintEven":

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));

                        break;
                    case "PrintOdd":

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));

                        break;
                    case "GetSum":

                        Console.WriteLine(string.Join(" ", numbers.Sum()));

                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number4 = int.Parse(tokens[2]);
                        if (condition == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < number4)));
                        }
                        if (condition == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number4)));
                        }
                        if (condition == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number4)));
                        }
                        if (condition == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number4)));
                        }
                        break;
                }
            }
        }
    }
}