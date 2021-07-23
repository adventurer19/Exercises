using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double min = double.MinValue;
            string output = "";
            for (int i = 0; i < num; i++)
            {

                string nameOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double v = Math.PI * Math.Pow(radius, 2) * height;
                if (v >= min)
                {
                    min = v;
                    output = nameOfKeg;
                }

            }
            Console.WriteLine(output);

        }
    }
}