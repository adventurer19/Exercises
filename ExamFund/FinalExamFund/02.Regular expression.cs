using System;
using System.Text.RegularExpressions;

namespace _02.regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(U\$)([A-Z][a-z]{2,})\1(P@\$)([A-z]{5,}[\d]+)\3";
            int lines = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < lines; i++)
            {
                var text = Console.ReadLine();
                if (Regex.IsMatch(text, regex))
                {
                    count++;
                    var match = Regex.Match(text, regex);
                    var split = match.ToString()
                        .Split(new string[] { "U$", "P@$" }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"Registration was successful");
                    Console.WriteLine($"Username: {split[0]}, Password: {split[1]}");
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }

            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}