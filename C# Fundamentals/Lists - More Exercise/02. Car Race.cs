using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _01m_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    int x = input[i] - '0';
                    numbers.Add(x);
                }
                else
                {
                    nonNumbers.Add(input[i]);
                }

            }
            string word = new string(nonNumbers.ToArray());
            StringBuilder result = GetResult(numbers, word);
            Console.WriteLine(result);
        }
        private static StringBuilder GetResult(List<int> nums, string input)
        {

            StringBuilder resultString = new StringBuilder();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > input.Length)
                {
                    nums[i] = input.Length;
                }
                if (i % 2 == 0)
                {
                    string parts = input.Substring(0, nums[i]);
                    resultString.Append(parts);
                    input = input.Remove(0, nums[i]);
                }
                else if (i % 2 != 0)
                {
                    input = input.Remove(0, nums[i]);
                }

            }

            return resultString;
        }
    }
}