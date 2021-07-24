using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regexDigit = new Regex(@"[\d]");
            var regex = new Regex(@"(\:{2}|\*{2})(?<word>[A-Z]{1}[a-z]{2,})\1");
            var matches = regex.Matches(text);
            var matchesDigit = regexDigit.Matches(text);
            List<string> valid = matches.Select(x => x.ToString()).ToList();
            List<string> numbers = matchesDigit.Select(x => x.ToString()).ToList();
            List<int> nums = numbers.Select(x => int.Parse(x)).ToList();
            var filteredList = new List<string>();
            int threshhold = 1;
            foreach (var idx in nums)
            {
                threshhold *= idx;
            }
            foreach (var idx in valid)
            {
                int amount = 0;
                string little = idx.Substring(2, idx.Length - 4);
                for (int i = 0; i < little.Length; i++)
                {
                    amount += little[i];
                }
                if (amount >= threshhold)
                {
                    filteredList.Add(idx);
                }

            }
            Console.WriteLine($"Cool threshold: {threshhold}");
            Console.WriteLine($"{valid.Count} emojis found in the text. The cool ones are:");
            foreach (var idx in filteredList)
            {
                Console.WriteLine(idx);
            }
        }
    }




}