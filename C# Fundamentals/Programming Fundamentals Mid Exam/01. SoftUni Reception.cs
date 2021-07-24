using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int pplPerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                pplPerHour += x;

            }
            int clients = int.Parse(Console.ReadLine());
            int hours = 0;
            while (clients > 0)
            {
                hours++;
                if (hours % 4 != 0)
                {
                    clients -= pplPerHour;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }



    }
}