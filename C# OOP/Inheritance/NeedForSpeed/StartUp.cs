using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sport = new RaceMotorcycle(100, 200);
            Console.WriteLine(sport.Fuel);
            sport.Drive(50);
            Console.WriteLine(sport.Fuel);
        }
    }
}
