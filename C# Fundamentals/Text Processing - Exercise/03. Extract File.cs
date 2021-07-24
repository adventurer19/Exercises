using System;
using System.Linq;

namespace Project
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            string[] word = input[input.Length - 1].Split('.').ToArray();
            Console.WriteLine($"File name: {word[0]}");
            Console.WriteLine($"File extension: {word[1]}");


        }

    }

}