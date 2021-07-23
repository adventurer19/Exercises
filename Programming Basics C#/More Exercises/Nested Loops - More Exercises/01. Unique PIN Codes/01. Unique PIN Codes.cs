using System;

namespace nestedloop_exercises
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            for (int numA = 1; numA <= num1; numA++)
            {
                for (int numB = 1; numB <= num2; numB++)
                {
                    for (int numC = 1; numC <= num3; numC++)
                    {
                        int primeSQRT = (int)Math.Floor(Math.Sqrt(numB));
                        bool IsPrime = true;
                        for (int prime = 2; prime <= primeSQRT; prime++)
                        {
                            if (numB % prime == 0) IsPrime = false;
                        }
                        if (numA % 2 == 0 && numC % 2 == 0 && IsPrime == true && numB != 1) Console.WriteLine($"{numA} {numB} {numC}");

                    }

                }
            }



        }
    }
}