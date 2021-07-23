using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            if (a >= 97) Console.WriteLine($"lower-case");
            else Console.WriteLine($"upper-case");

        }
    }
}