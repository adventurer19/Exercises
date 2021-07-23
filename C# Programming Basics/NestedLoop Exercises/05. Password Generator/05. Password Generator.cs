using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= n; x++)
                {
                    for (int y = 97; y < 97 + l; y++)
                    {
                        for (int a = 97; a < 97 + l; a++)
                        {
                            for (int j = 1; j <= n; j++)
                            {
                                if (j > x && j > i) Console.Write($"{i}{x}{Convert.ToChar(y)}{Convert.ToChar(a)}{j} ");
                            }

                        }
                    }


                }

            }






        }

    }
}