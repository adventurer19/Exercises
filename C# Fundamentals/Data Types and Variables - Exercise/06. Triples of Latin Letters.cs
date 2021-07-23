using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 97; i < num + 97; i++)
            {

                for (int j = 97; j < num + 97; j++)
                {

                    for (int k = 97; k < num + 97; k++)
                    {
                        Console.WriteLine($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)}");


                    }
                }
            }
        }
    }
}