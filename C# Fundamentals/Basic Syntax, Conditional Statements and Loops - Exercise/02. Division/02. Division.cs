using System;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int x = 0;
        bool exit = false;
        //2, 3, 6, 7, 10
        if (num % 10 == 0)
        {
            x = 10;
            exit = true;
        }
        else if (num % 7 == 0)
        {
            x = 7;
            exit = true;

        }
        else if (num % 6 == 0)
        {
            x = 6;
            exit = true;

        }
        else if (num % 3 == 0)
        {
            x = 3;
            exit = true;

        }
        else if (num % 2 == 0)

        {
            x = 2;
            exit = true;

        }
        if (exit)
        {
            Console.WriteLine($"The number is divisible by {x}");
        }
        else
        {
            Console.WriteLine($"Not divisible");
        }
    }
}