using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //var day = int.Parse(Console.ReadLine());

            string country = Console.ReadLine();
            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}