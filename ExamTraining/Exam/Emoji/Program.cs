using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = Console.ReadLine();
            var digit = @"[\d]";
            var array = Regex.Matches(line, digit).Select(x => int.Parse(x.ToString())).ToArray();
            int threshold = Sum(array);
            var patter = @"(:{2}|\*{2})([A-Z]{1}[a-z]{2,})\1";
            var matches = Regex.Matches(line, patter).Select(x => x.ToString()).ToArray();
            Console.WriteLine();
            var validEmojiList = Validation(matches, threshold);
            Print(threshold,matches.Length,validEmojiList);


        }

        private static void Print(int threshold, int amount, List<string> validEmojiList)
        {
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{amount} emojis found in the text. The cool ones are:");
            validEmojiList.ForEach(x=>Console.WriteLine(x));
        }


        private static List<string> Validation(string[] matches, int threshold)
        {
            var list = new List<string>();
            foreach (var item in matches)
            {
                int counter = 0;
                var word = item.Substring(2, item.Length - 4);
                foreach (var chars in word)
                {
                    
                    counter += chars;
                    
                }
                if (counter > threshold)
                {
                    list.Add(item);
                }

            }

            return list;
        }


        private static int Sum(int[] array)
        {
            int x = 1;
            foreach (var item in array)
            {
                x *= item;
            }

            return x;
        }
    }
}
