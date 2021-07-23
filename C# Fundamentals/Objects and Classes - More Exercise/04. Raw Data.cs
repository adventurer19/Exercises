using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace example
{
    class Program
    {
        static void Main()
        {
            List<Car> allCars = new List<Car>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] parts = Console.ReadLine().Split().ToArray();
                string name = parts[0];
                int EngineSpeed = int.Parse(parts[1]);
                int EnginePower = int.Parse(parts[2]);
                int CargoWeight = int.Parse(parts[3]);
                string CargoType = parts[4];
                if (allCars.Find(x => x.Name == name) == null)
                {
                    allCars.Add(new Car(name, EngineSpeed, EnginePower, CargoWeight, CargoType));
                }
            }

            string last = Console.ReadLine();
            if (last == "fragile")
            {
                List<Car> cars = allCars.Where(x => x.CargoType == "fragile" && x.CargoWeight < 1000).ToList();
                cars.ForEach(x => Console.WriteLine(x.Name));
            }
            else if (last == "flamable")
            {
                List<Car> cars = allCars.Where(x => x.CargoType == "flamable" && x.EnginePower > 250).ToList();
                cars.ForEach(x => Console.WriteLine(x.Name));
            }

        }

    }

    class Car
    {
        public Car(string name, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Name = name;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public string Name { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

    }





}