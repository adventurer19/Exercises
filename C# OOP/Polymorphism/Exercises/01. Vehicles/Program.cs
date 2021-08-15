using System;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            var line = LineRead();
            var car = new Car(double.Parse(line[1]), double.Parse(line[2]));
            line = LineRead();
            var truck = new Truck(double.Parse(line[1]), double.Parse(line[2]));
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                line = LineRead();
                // line[0]= cmd
                // line [1] = type 
                // line [2] = value;

                var value = double.Parse(line[2]);
                switch (line[0])
                {
                    case "Drive":
                        if (line[1] is "Car")
                        {
                            car.Driving(value);
                        }
                        else if (line[1] is "Truck")
                        {
                            truck.Driving(value);
                        }
                        break;
                    case "Refuel":
                        if (line[1] is "Car")
                        {
                            car.Refueling(value);
                        }
                        else if (line[1] is "Truck")
                        {
                            truck.Refueling(value);
                        }
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");

        }

        private static string[] LineRead()
        {
            return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
