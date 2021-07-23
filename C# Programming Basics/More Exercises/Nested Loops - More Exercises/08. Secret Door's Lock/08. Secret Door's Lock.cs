using System;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOne = int.Parse(Console.ReadLine());
            int maxNumberTwo = int.Parse(Console.ReadLine());
            int maxNumberThree = int.Parse(Console.ReadLine());
            for (int x1 = 1; x1 <= maxNumberOne; x1++)
            {
                for (int x2 = 1; x2 <= maxNumberTwo; x2++)
                {
                    for (int x3 = 1; x3 <= maxNumberThree; x3++)
                    {
                        if (x1 % 2 == 0 && x3 % 2 == 0)
                        {
                            bool isPrime1 = true;
                            int sqrt = (int)(Math.Sqrt(x2));
                            for (int y = 2; y <= sqrt; y++)
                            {
                                if (x2 % y == 0)
                                {
                                    isPrime1 = false;

                                }

                            }
                            if (isPrime1 == true && x2 != 1) Console.WriteLine($"{x1} {x2} {x3}");
                        }


                    }
                }
            }
        }
    }
}