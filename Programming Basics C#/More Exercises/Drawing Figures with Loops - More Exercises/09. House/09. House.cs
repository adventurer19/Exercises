using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            int l = 1;
            int j = 1;
            for (int K = (n + 1) / 2; K > 0; K--)
            {
                for (int dash = K + 1; dash > 2; dash--)
                {
                    Console.Write("-");
                }
                if (n % 2 != 0)
                {
                    for (int stars = l; stars > 0; stars--)
                    {
                        //if (l >n) break;
                        Console.Write("*");
                    }
                    // if (l<n)
                    l += 2;

                }
                else if (n % 2 == 0)
                {
                    for (int stars = j; stars > 0; stars--)
                    {
                        //if (j > n) break;
                        Console.Write("**");
                    }
                    // if (j < n) 
                    j++;
                }
                for (int dash = K + 1; dash > 2; dash--)
                {

                    Console.Write("-");
                }
                Console.WriteLine();
            }
            for (int i = n / 2; i > 0; i--)
            {
                for (int walls = 0; walls < 1; walls++)
                {
                    Console.Write("|");
                }
                for (int stars = n - 2; stars > 0; stars--)
                {
                    Console.Write("*");
                }
                for (int walls = 0; walls < 1; walls++)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }



        }
    }
}