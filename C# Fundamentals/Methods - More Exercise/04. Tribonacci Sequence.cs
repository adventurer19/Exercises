using System;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            if (num <= 0) return;
            int[] result = new int[num];
            result[0] = 1;
            for (int i = 1; i < num; i++)
            {
                if (i > 2)
                {
                    result[i] = result[i - 3] + result[i - 2] + result[i - 1];
                    continue;

                }
                else
                {
                    result[i] = i;
                }

            }

            Console.WriteLine(string.Join(" ", result));

        }


    }
}