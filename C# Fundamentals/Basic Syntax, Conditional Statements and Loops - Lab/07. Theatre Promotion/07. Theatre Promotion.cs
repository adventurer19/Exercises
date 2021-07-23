using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {


            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (day)
            {
                case "Weekday":
                    if (0 <= age && age <= 18)
                    {
                        sum += 12;
                    }
                    else if (18 < age && age <= 64)
                    {
                        sum += 18;
                    }
                    else if (64 < age && age <= 122)
                    {
                        sum += 12;
                    }
                    break;
                case "Weekend":
                    if (0 <= age && age <= 18)
                    {
                        sum += 15;
                    }
                    else if (18 < age && age <= 64)
                    {
                        sum += 20;
                    }
                    else if (64 < age && age <= 122)
                    {
                        sum += 15;
                    }
                    break;
                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        sum += 5;
                    }
                    else if (18 < age && age <= 64)
                    {
                        sum += 12;
                    }
                    else if (64 < age && age <= 122)
                    {
                        sum += 10;
                    }
                    break;
                default:

                    Console.WriteLine("Error!");
                    break;
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
                Console.WriteLine("{0}$", sum);

        }
    }
}
