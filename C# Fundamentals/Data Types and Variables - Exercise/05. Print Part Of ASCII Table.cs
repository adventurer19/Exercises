﻿using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                char a = (char)i;
                Console.Write($"{a} ");

            }

        }
    }
}