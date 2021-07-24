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
            var regex = new Regex(@"\b(\d{2})([/]|[.]|[-])([A-Z][a-z]{2})\2([\d]{4})\b");
            string input = Console.ReadLine();
            var matchCollection = regex.Matches(input);
            foreach (Match idx in matchCollection)
            {
                string[] output = idx.Value.Split(new char[] { '-', '/', '.' })
                    .ToArray();
                string date = output[0];
                string month = output[1];
                string year = output[2];
                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }


        }


    }







}