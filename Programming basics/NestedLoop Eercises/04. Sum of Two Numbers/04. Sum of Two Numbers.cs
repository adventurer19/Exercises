using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1 + x2 + x3 = n
            //23,24,20

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            bool escape = false;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    int result = num1 + num2;
                    if (magic == result)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magic})");
                        escape = true;
                        break;

                    }

                }
                if (escape)
                {

                    break;
                }
            }
            if (!escape)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");

            }



        }

    }
}