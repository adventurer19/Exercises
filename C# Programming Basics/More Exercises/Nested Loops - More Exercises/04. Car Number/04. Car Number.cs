using System;
using System.Globalization;
namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                for (int x = start; x <= end; x++)
                {
                    for (int r = start; r <= end; r++)
                    {
                        for (int y = start; y <= end; y++)
                        {
                            if (i % 2 == 0 && i > y && y % 2 != 0 && (x + r) % 2 == 0)
                            {
                                Console.Write($"{i}{x}{r}{y} ");
                            }
                            else if (i % 2 != 0 && i > y && y % 2 == 0 && (x + r) % 2 == 0)
                            {
                                Console.Write($"{i}{x}{r}{y} ");
                            }
                        }
                    }
                }

            }




        }
    }
}