using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}