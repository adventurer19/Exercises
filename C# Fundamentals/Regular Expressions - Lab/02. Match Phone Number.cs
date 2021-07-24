using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace example
{
    class Program
    {
        static void Main()
        {

            var regex = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");
            string phones = Console.ReadLine();
            var matches = regex.Matches(phones);
            var matchPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));

        }


    }







}