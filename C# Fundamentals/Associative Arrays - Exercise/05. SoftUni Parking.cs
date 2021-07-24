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
            var register = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "register")
                {
                    if (register.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else
                    {
                        register.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (register.ContainsKey(input[1]))
                    {
                        register.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }

            foreach (var idx in register)
            {
                Console.WriteLine($"{idx.Key} => {idx.Value}");
            }
        }
    }
}