using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace Fundamentals
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> output = new List<string>(number);
            for (int i = 0; i < number; i++)
            {
                output.Add(Console.ReadLine());

            }
            output.Sort();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}.{output[i]}");

            }


        }
    }
}