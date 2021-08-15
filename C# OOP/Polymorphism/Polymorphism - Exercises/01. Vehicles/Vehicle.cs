using System;

namespace Vehicles
{
    public abstract class Vehicle
    {

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; private set; }
        

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public abstract void Refueling(double liters);

        public abstract double AirCondition();

        public  void Driving(double distance)
        {
            var amount = AirCondition() * distance + FuelConsumption * distance;
            if (this.FuelQuantity >= amount)
            {
                FuelQuantity -= amount;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

      
        
    }
}
