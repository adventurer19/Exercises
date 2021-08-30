using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine().Split();
            var fullName = $"{cmd[0]} {cmd[1]}";
            var adress = cmd[2];
            var cmdTwo = Console.ReadLine().Split();
            var name = cmdTwo[0];
            var numberOfBeers = int.Parse(cmdTwo[1]);
            var cmdThree = Console.ReadLine().Split();
            var integer = int.Parse(cmdThree[0]);
            var doubler = double.Parse(cmdThree[1]);
            Tuple<string, string> first = new Tuple<string, string>(fullName, adress);
            Tuple<string, int> second = new Tuple<string, int>(name, numberOfBeers);
            Tuple<int, double> third = new Tuple<int, double>(integer, doubler);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);


        }
    }
}
