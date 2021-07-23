using System;

namespace traning
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            string a = "+";
            string b = "-";
            string c = "+";
            for (int i = 1; i <= 1; i++)
            {
                Console.Write("+");
                for (int t = 1; t <= x - 2; t++)
                {
                    Console.Write(" -");

                }
                Console.Write($" +");


            }
            for (int u = 1; u <= x - 2; u++)
            {
                Console.Write($"\n|");
                for (int r = 1; r <= x - 2; r++)
                {
                    Console.Write($" -");
                }
                Console.Write($" |");

            }
            for (int i = 1; i <= 1; i++)
            {
                Console.Write("\n+");
                for (int t = 1; t <= x - 2; t++)
                {
                    Console.Write(" -");

                }
                Console.Write($" +");


            }







        }
    }
}