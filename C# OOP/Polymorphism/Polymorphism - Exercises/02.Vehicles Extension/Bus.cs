using System;

namespace _02.Poly
{
    public class Bus:Vehicle
    {
        public Bus(double Consumption, double quantity, double tankCapacity) : base(Consumption, quantity, tankCapacity)
        {
        }

        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * (FuelConsumption - 1.4);
            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }
    }
}
