using System;
using System.Globalization;
namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int x = 1; x <= 9; x++)
                {
                    for (int y = 1; y <= 9; y++)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if (i + x == y + c && num % (i + x) == 0)
                            {
                                Console.Write($"{i}{x}{y}{c} ");
                            }
                        }
                    }
                }
            }
        }
    }
}