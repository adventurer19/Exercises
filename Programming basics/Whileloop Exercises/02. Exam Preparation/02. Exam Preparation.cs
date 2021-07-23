using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int tolerance = int.Parse(Console.ReadLine());
                int counter = 0;
                int fails = 0;
                string lastbook = "";
                double sum = 0;

                string text = Console.ReadLine();
                while (text != "Enough")
                {
                    double num = double.Parse(Console.ReadLine());
                    if (num <= 4.00)
                    {

                        fails++;
                        if (fails >= tolerance)
                        {
                            Console.WriteLine($"You need a break, {fails} poor grades.");
                            return;
                        }
                    }
                    counter++;
                    sum += num;
                    lastbook = text;
                    text = Console.ReadLine();
                }
                double average = sum / counter;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastbook}");
            }
        }

    }
}