using System;
using System.Collections.Generic;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < num; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = parts[0];
                double fuelAmount = double.Parse(parts[1]);
                double fuelConsumptionFor1km = double.Parse(parts[2]);
                if (allCars.Find(x => x.Model == model) == null)
                {
                    allCars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km));
                }

            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parts = input.Split().ToArray();
                string command = parts[0];
                string model = parts[1];
                double amount = double.Parse(parts[2]);
                var currentCar = allCars.Find(x => x.Model == model);
                currentCar.Calc(amount);
                input = Console.ReadLine();



            }
            allCars.ForEach(x => Console.WriteLine(x));




        }

    }

    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km = fuelConsumptionFor1Km;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public double DistanceTraveled { get; set; }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
        }

        public void Calc(double amountKm)
        {
            double neededFuel = amountKm * FuelConsumptionFor1km;
            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                DistanceTraveled += amountKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

    }






}