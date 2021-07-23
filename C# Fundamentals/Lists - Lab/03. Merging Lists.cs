using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace Fundamentals
{
    class Program
    {
        static void Main()
        {

            List<int> a1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> a2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lenght = a1.Count + a2.Count;
            List<int> result = new List<int>(a1.Count + a2.Count);
            int start = Math.Min(a1.Count, a2.Count);

            for (int i = 0; i < start; i++)
            {
                result.Add(a1[i]);
                result.Add(a2[i]);

            }
            if (a1.Count > a2.Count)
            {
                result.AddRange(calc(a1, a2));
            }
            else if (a1.Count < a2.Count)
            {
                result.AddRange(calc(a2, a1));
            }
            Console.WriteLine(string.Join(' ', result));
        }

        private static List<int> calc(List<int> a1, List<int> a2)
        {
            List<int> nums = new List<int>(a1.Count - a2.Count);
            int start = a1.Count - a2.Count;

            for (int i = a2.Count; i < a1.Count; i++)
            {
                nums.Add(a1[i]);
            }
            return nums;
        }
    }
}