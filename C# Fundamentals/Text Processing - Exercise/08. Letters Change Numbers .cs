using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace text_proc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;
            foreach (var idx in input)
            {
                char FirstChar = idx[0];
                char LastChar = idx[idx.Length - 1];
                double numberInBetween = double.Parse(idx.Substring(1, idx.Length - 2));
                if (char.IsUpper(FirstChar))
                {
                    numberInBetween /= FirstChar - 64;
                }
                else
                {
                    numberInBetween *= FirstChar - 96;
                }

                if (char.IsUpper(LastChar))
                {
                    numberInBetween -= LastChar - 64;
                }
                else
                {
                    numberInBetween += LastChar - 96;
                }

                totalSum += numberInBetween;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}