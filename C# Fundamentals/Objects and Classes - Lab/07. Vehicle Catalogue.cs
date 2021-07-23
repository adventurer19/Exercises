using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Numerics;

namespace Classes
{

    class Program
    {

        static void Main(string[] args)
        {
            Catalog magazine = new Catalog();
            //string input = String.Empty;
            while (true)
            {
                string[] tokens = Console.ReadLine().Split('/').ToArray();
                if (tokens[0] == "end") break;
                string brand = tokens[1];
                string model = tokens[2];
                int number = int.Parse(tokens[3]);
                if (tokens[0] == "Car")
                {
                    var car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = number


                    };
                    magazine.cars.Add(car);
                }
                else if (tokens[0] == "Truck")
                {
                    var truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = number
                    };
                    magazine.trucks.Add(truck);
                }
            }

            if (magazine.cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (var iCar in magazine.cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{iCar.Brand}: {iCar.Model} - {iCar.HorsePower}hp");
                }
            }
            if (magazine.trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (var truck in magazine.trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                }

            }

        }

    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        //public Car(string aName, string aModel, int aHorsePower)
        //{
        //    this.Brand = aName;
        //    this.Model = aModel;
        //    this.HorsePower = aHorsePower;
        //}
    }
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        //public  Truck(string aName,string aModel, int aWeight)
        //{
        //    this.Brand = aName;
        //    this.Model = aModel;
        //    this.Weight = aWeight;
        //}
    }

    public class Catalog
    {
        public List<Car> cars { get; }
        public List<Truck> trucks { get; }

        public Catalog()
        {
            this.cars = new List<Car>();

            this.trucks = new List<Truck>();
        }

    }

}