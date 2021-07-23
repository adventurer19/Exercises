using System;


namespace _06_Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPair = int.Parse(Console.ReadLine());
            var secondPair = int.Parse(Console.ReadLine());
            var firstDiff = int.Parse(Console.ReadLine());
            var secondDiff = int.Parse(Console.ReadLine());

            for (int first = firstPair; first <= firstPair + firstDiff; first++)
            {
                for (int second = secondPair; second <= secondPair + secondDiff; second++)
                {
                    double firstSqrt = (int)Math.Floor(Math.Sqrt(first));
                    double secondSqrt = (int)Math.Floor(Math.Sqrt(second));
                    bool isPrime1 = true;
                    bool isPrime2 = true;

                    for (int first1 = 2; first1 <= firstSqrt; first1++)
                    {
                        if (first % first1 == 0)
                        {
                            isPrime1 = false;
                        }
                    }
                    for (int second2 = 2; second2 <= secondSqrt; second2++)
                    {
                        if (second % second2 == 0)
                        {
                            isPrime2 = false;
                        }
                    }
                    if (isPrime1 == true && isPrime2 == true)
                    {
                        Console.WriteLine($"{first}{second}");
                    }

                }
            }

        }
    }
}