using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            middle(line);


        }

        private static void middle(string line)
        {
            if (line.Length % 2 == 0)
            {
                Console.WriteLine($"{line[line.Length / 2 - 1]}{line[line.Length / 2]}");
            }
            else if (line.Length % 2 != 0)
            {
                Console.WriteLine(line[line.Length / 2]);
            }

        }

    }

}