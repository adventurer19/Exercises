using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string line = Console.ReadLine().ToLower();
                if (line == "end") break;
                bool result = Pali(line);
                Console.WriteLine(result);
            }

        }

        private static bool Pali(string line)
        {
            int sum = 0;
            int sumtwo = 0;
            for (int i = 0; i < line.Length - 1; i++)
            {
                int x = line[i];
                sum += x;
            }
            for (int i = line.Length - 1; i > 0; i--)
            {
                int x = line[i];
                sumtwo += x;
            }
            if (sum == sumtwo) return true;
            else
            {
                return false;
            }
        }
    }

}