using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace example
{
    class Program
    {
        static void Main()
        {
            string input = String.Empty;
            Queue<string> names = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n", names));
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }



            }

            Console.WriteLine($"{names.Count} people remaining.");

        }


    }



}