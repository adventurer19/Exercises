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
            int number = int.Parse(Console.ReadLine());
            //string pattern = @"(?<valid>[?=@]{1}[?=#]{1,}[A-z]{1}[a-zA-Z\d]*[?<=@]{1}[?<=#]{1,})";
            // var regex = new Regex(@"(?<valid>[?=@]{1}[?=#]{1,}[A-z]{1}[a-zA-Z\d]*[?<=@]{1}[?<=#]{1,})");
            var regex = new Regex(@"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
            Regex digit = new Regex(@"\d");
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["barcode"].Value;
                    var digitMatch = digit.Matches(name);
                    string output = digitMatch.Count <= 0 ? "00" : string.Join("", digitMatch);
                    Console.WriteLine($"Product group: {output}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }




        }
    }


}