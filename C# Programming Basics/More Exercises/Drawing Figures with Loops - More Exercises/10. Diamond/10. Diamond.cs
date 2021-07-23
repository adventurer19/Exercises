using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int starter = 0;
            int dashstart = (n - 1) / 2;
            int dashstarttwo = (n - 1) / 2;
            int jokerend = 0;
            int middledashend = 1;
            int jokerdash = 0;
            int middlecounter = 1;
            if (n % 2 == 0) starter = 1;
            else if (n % 2 != 0) starter = 0;
            for (int startrows = starter; startrows < n; startrows++)
            {
                for (int dash = dashstart; dash > 0; dash--)
                {
                    Console.Write("-");
                }
                dashstart--;
                for (int dash = dashstart; dash < -1; dash++)
                {
                    Console.Write("-");
                }
                for (int stars = 1; stars > 0; stars--)
                {
                    Console.Write("*");
                    if ((n % 2 == 0 && startrows == 1) || (n % 2 == 0 && startrows == n - 1)) Console.Write("*");
                }

                if (n - 2 > middledashend && startrows != 0 && (n % 2 == 0 && startrows > 1 && startrows < n - 1))
                // if (n - 2 > middledashend && startrows != 0  && (n % 2 == 0 && startrows > 1 && startrows < n - 1))
                {
                    middledashend += 2;
                    jokerend = middledashend;
                }
                else
                {
                    jokerend -= 2;
                }
                for (int middle = 1; middle < jokerend; middle++)
                {
                    Console.Write("-");

                }
                if (n % 2 != 0 && startrows >= 1 && startrows < n - 1)
                {
                    if (n - 2 >= middlecounter)
                    {
                        middlecounter += 2;
                        jokerdash = middlecounter;
                    }
                    else if (middlecounter > n - 2)
                    {
                        jokerdash -= 2;
                    }

                    for (int middle = 2; middle < jokerdash; middle++)
                    {
                        Console.Write("-");

                    }

                }
                if (startrows > 1 && startrows < n - 1 && n % 2 == 0)
                {
                    for (int stars = 1; stars > 0; stars--)
                    {
                        Console.Write("*");
                    }
                }
                else if (startrows >= 1 && startrows < n - 1 && n % 2 != 0)
                {
                    for (int stars = 1; stars > 0; stars--)
                    {
                        Console.Write("*");
                    }

                }
                for (int dash = dashstarttwo; dash > 0; dash--)
                {
                    Console.Write("-");
                }
                dashstarttwo--;
                for (int dash = dashstarttwo; dash < -1; dash++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}