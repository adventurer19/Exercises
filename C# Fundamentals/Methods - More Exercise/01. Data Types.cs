using System;
using System.Linq;
using System.Collections.Generic;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            Dirty(input2, input);
        }

        public static void Dirty(string amount, string value)
        {
            if (value == "int")
            {
                int x = int.Parse(amount);
                amount = $"{x * 2}";

            }
            else if (value == "real")
            {
                double x = double.Parse(amount);
                amount = $"{x * 1.5:f2}";
            }
            else if (value == "string")
            {
                amount = $"${amount}$";
            }

            Console.WriteLine(amount);
        }
    }


}