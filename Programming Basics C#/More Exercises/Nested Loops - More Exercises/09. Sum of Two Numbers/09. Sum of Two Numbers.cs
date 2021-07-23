using System;

namespace multiply_table
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int x = start; x <= end; x++)
                {
                    counter++;
                    if (i + x == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {x} = {magic})");
                        return;
                    }


                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magic}");


        }
    }
}