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
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                bool result = true;
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (parts[0] == "TakeOdd")
                {
                    input = GetThePwd(input);
                }
                else if (parts[0] == "Cut")
                {
                    int index = int.Parse(parts[1]);
                    int length = int.Parse(parts[2]);
                    input = input.Remove(index, length);

                }
                else if (parts[0] == "Substitute")
                {
                    string Substring = parts[1];
                    string Substitude = parts[2];
                    if (!input.Contains(Substring))
                    {
                        result = false;
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        input = input.Replace(Substring, Substitude);
                    }
                }
                if (result) Console.WriteLine(input);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");

        }
        private static string GetThePwd(string input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    output.Append(input[i]);
                }
            }
            return output.ToString();
        }
    }


}