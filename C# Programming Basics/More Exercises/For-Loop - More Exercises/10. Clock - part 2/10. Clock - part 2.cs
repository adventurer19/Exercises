using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {

            int n = 23;
            int m = 59;
            int s = 59;
            for (int i = 0; i <= n; i++)
            {
                for (int y = 0; y <= m; y++)
                {
                    for (int p = 0; p <= s; p++)
                    {
                        Console.WriteLine($"{i} : {y} : {p}");
                    }
                }


            }
        }

    }

}