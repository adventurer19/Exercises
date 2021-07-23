using System;
using System.Globalization;
namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            for (int i = 1; i <= men; i++)
            {
                for (int x = 1; x <= women; x++)
                {
                    tables--;
                    if (tables < 0)
                    {
                        return;
                    }
                    Console.Write($"({i} <-> {x}) ");
                }

            }





        }
    }
}