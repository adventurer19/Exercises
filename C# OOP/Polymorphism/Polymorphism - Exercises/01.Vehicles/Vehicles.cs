using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicles
    {

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; private set; }
        

        protected Vehicles(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

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

        public abstract void Refueling(double liters);
      
        public abstract double AirCondition();


        //driving //refueling 
    }
}
