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
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Queue<string> names = new Queue<string>(input);
            int number = int.Parse(Console.ReadLine());
            while (names.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    string name = names.Dequeue();
                    names.Enqueue(name);
                }

                string removalName = names.Dequeue();
                Console.WriteLine($"Removed {removalName}");
            }

            Console.WriteLine($"Last is {names.Dequeue()}");


        }
    }



}