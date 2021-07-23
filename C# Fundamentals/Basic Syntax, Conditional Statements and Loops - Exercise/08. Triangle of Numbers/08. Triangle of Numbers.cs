using System;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int rows = 1; rows <= num; rows++)
        {
            for (int cols = 1; cols < rows; cols++)
            {
                Console.Write($"{rows} ");
            }
            Console.WriteLine($"{rows}");

        }



    }
}