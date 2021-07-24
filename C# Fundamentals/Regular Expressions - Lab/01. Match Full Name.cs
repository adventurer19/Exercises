using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;

namespace example
{
    class Program
    {
        static void Main()
        {
            // var regex = new Regex(@"(\b[A-Z]{1}[a-z]+\s{1}[A-Z]{1}[a-z]+)");
            var regex = new Regex(@"\b([A-Z][a-z]+[\s][A-Z][a-z]+)\b");
            string input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (Match idx in matches)
            {
                Console.Write($"{idx.Value} ");
            }

            Console.WriteLine();
        }


    }







}