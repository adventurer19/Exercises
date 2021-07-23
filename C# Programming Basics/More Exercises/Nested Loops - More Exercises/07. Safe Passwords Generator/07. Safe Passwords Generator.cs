using System;

namespace nestedloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxnumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int A = 35;
            int B = 64;

            for (int i = 1; i <= a; i++)
            {

                for (int x = 1; x <= b; x++)
                {
                    counter++;
                    if (counter <= maxnumber)
                    {
                        Console.Write($"{Convert.ToChar(A)}{Convert.ToChar(B)}{i}{x}{Convert.ToChar(B)}{Convert.ToChar(A)}|");
                    }
                    A++;
                    B++;
                    if (A > 55) A = 35;
                    if (B > 96) B = 64;



                }


            }

        }
    }
}