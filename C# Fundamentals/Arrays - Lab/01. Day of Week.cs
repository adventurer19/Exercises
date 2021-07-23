using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };
            if (input <= 0 || input > daysOfWeek.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                for (int i = 0; i <= daysOfWeek.Length; i++)
                {
                    if (input == i)
                    {
                        Console.WriteLine(daysOfWeek[i - 1]);
                    }
                }
            }

        }
    }
}