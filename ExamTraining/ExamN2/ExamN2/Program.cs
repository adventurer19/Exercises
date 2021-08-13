using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace ExamN2
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexPattern = @"(@#+)([A-Z][a-zA-Z0-9]{4,}[A-Z])@#+";
            var barcodeAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i <barcodeAmount; i++)
            {
                var item = Console.ReadLine();
                if (Regex.IsMatch(item, regexPattern))
                {
                    var line = new string(item.Where(x => char.IsDigit(x)).ToArray());
                    if (string.IsNullOrWhiteSpace(line)) line = "00";
                    {
                        Console.WriteLine($"Product group: {line}");
                    }
                }
                else Console.WriteLine($"Invalid barcode");
              
            }
            
        }
    }
}
