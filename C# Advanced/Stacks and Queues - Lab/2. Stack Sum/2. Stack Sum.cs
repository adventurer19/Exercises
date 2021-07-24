using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace example
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numsStack = new Stack<int>(nums);
            string input = String.Empty;
            while ((input = Console.ReadLine()).ToUpper() != "END")
            {
                string[] parts = input.Split();
                string command = parts[0].ToUpper();
                switch (command)
                {
                    case "ADD":

                        int numOne = int.Parse(parts[1]);
                        int numTwo = int.Parse(parts[2]);
                        numsStack.Push(numOne);
                        numsStack.Push(numTwo);
                        break;
                    case "REMOVE":
                        int counter = int.Parse(parts[1]);
                        if (counter < numsStack.Count)
                        {
                            while (counter > 0)
                            {
                                counter--;
                                numsStack.Pop();

                            }
                        }
                        break;
                }
            }
            int sum = numsStack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }

    }



}