using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            //1 British Pound = 1.31 Dollars
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422f);
            ulong hours = (ulong)(days * 24);
            ulong minutes = (ulong)(hours * 60);
            //1	1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}