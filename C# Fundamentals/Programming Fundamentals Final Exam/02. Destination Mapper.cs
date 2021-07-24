using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            var regex = new Regex(@"(\=|\/)([A-Z]{1}[A-z]{2,})\1");
            List<string> destinations = new List<string>();
            var matches = regex.Matches(places);
            int sum = 0;

            foreach (Match index in matches)
            {
                string clean = index.ToString().Substring(1, index.Length - 2);
                sum += clean.Length;
                destinations.Add(clean);
            }




            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }


}