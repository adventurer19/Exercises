using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Poly
{
    public abstract class Vehicle
    {
        private const double AIR_CONDITIONER_CAR = 0.9;
        private const double AIR_CONDITIONER_TRUCK = 1.6;
        private const double AIR_CONDITIONER_BUS = 1.4;
        private const double TANKTRUCK = 0.95;
        private double fuelConsumption;
        protected Vehicle(double quantity, double Consumption, double tankCapacity)
        {
            FuelQuantity = quantity <= tankCapacity ? quantity : 0;
            FuelConsumption = Consumption;
            TankCapacity = tankCapacity;
        }
        public double FuelConsumption
        {
            get => fuelConsumption;
            private set
            {
                if (GetType().Name == "Car")
                {
                    fuelConsumption = value+ AIR_CONDITIONER_CAR;
                }
                else if (GetType().Name == "Truck")
                {
                    fuelConsumption = value + AIR_CONDITIONER_TRUCK;
                }
                else if (GetType().Name == "Bus")
                {
                    fuelConsumption = value + AIR_CONDITIONER_BUS;
                }
            }

        }
        public double FuelQuantity { get; protected set; }
        public double TankCapacity  { get; private set; }
        public void Drive(double distance)
        {
            double neededFuel = distance * fuelConsumption;
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

        public void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            if (amount + FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            if(amount > 0 && amount + FuelQuantity <= TankCapacity)
            {
                if (GetType().Name == "Truck")
                {

                    FuelQuantity += amount*TANKTRUCK;
                }
                else
                {
                    FuelQuantity += amount;
                }
            }

        }

        public string ShowFuelLeft()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
        



    }
}
