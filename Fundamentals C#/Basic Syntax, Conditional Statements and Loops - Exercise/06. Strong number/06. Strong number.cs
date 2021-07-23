using System;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        int sum = 0;
        int original = num;
        while (num != 0)
        {
            int lastDiggit = num % 10;

            int factorial = 1;
            for (int i = lastDiggit; i >= 1; i--)
            {
                factorial *= i;
            }
            sum += factorial;

            num /= 10;

        }
        if (original == sum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }


    }
}