using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodShit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> mixSequence = new List<int>();
            int lowerCount = Math.Min(first.Count, second.Count);
            second.Reverse();
            List<int> longestSequence = second.Count < first.Count ? first.ToList() : second.ToList();
            int[] range = longestSequence.GetRange(longestSequence.Count - 2, 2).ToArray();
            for (int i = 0; i < lowerCount; i++)
            {
                mixSequence.Add(first[i]);
                mixSequence.Add(second[i]);
            }

            int lowPoint = range.Min();
            int highPoint = range.Max();
            mixSequence = mixSequence.Where(x => x > lowPoint && x < highPoint).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(' ', mixSequence));

        }


    }
}