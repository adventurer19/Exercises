using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TupleTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var fullName = $"{firstLine[0]} {firstLine[1]}";
            var adress = firstLine[2];
            var sb = new StringBuilder();
            for (int i = 3; i < firstLine.Length; i++)
            {
                sb.Append(firstLine[i] + ' ');
            }
            var city = sb.ToString().TrimEnd();

            Threeuple<string, string, string> first = new Threeuple<string, string, string>(fullName, adress,city);
            ///
            var secondLine = Console.ReadLine().Split();
            var name = secondLine[0];
            var numberOfBeers = int.Parse(secondLine[1]);
            bool drunk = secondLine[2] == "drunk";

            Threeuple<string, int, bool> second = new Threeuple<string, int, bool>(name, numberOfBeers, drunk);
            ///
            var thirdLine = Console.ReadLine().Split();
            var nameThird = (thirdLine[0]);
            var balance = double.Parse(thirdLine[1]);
            var bankName = thirdLine[2];

            Threeuple<string, double, string> third = new Threeuple<string, double, string>(nameThird, balance, bankName);
            ///

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);


        }
    }
}
