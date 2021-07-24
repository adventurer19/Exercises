using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Project
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<char> array = input.ToCharArray().ToList();
            List<char> result = new List<char>();
            for (int i = 1; i < array.Count; i++)
            {

                if (array[i] != array[i - 1])
                {
                    result.Add(array[i]);
                }
            }
            result.Insert(0, array[0]);
            Console.WriteLine(string.Join("", result));

        }
    }
}