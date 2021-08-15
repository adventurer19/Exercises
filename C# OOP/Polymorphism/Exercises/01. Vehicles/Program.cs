using System;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            var car = new Car(double.Parse(line[1]), double.Parse(line[2]));
            line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            var truck = new Truck(double.Parse(line[1]), double.Parse(line[2]));
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
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
    }
}
