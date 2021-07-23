using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;


namespace Classes
{
    class Vehicle
    {
        //{typeOfVehicle} {model} {color} {horsepower}
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }

        class Program
        {

            static void Main(string[] args)
            {
                List<Vehicle> Catalog = new List<Vehicle>();
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "End") break;
                    string[] parts = input.Split(" ").ToArray();
                    //{typeOfVehicle} {model} {color} {horsepower}
                    string type = Upper(parts[0]);
                    string model = parts[1];
                    string color = parts[2];
                    double hpower = double.Parse(parts[3]);
                    var car = new Vehicle(type, model, color, hpower);
                    Catalog.Add(car);

                }

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Close the Catalogue") break;
                    foreach (var idx in Catalog)
                    {
                        if (idx.Model == input)
                            Console.WriteLine(idx);
                    }


                }



                double carsAvg = CalcAvgHp(Catalog, "Car");
                double truckAvg = CalcAvgHp(Catalog, "Truck");

                Console.WriteLine($"Cars have average horsepower of: {carsAvg:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {truckAvg:f2}.");
            }

            private static double CalcAvgHp(List<Vehicle> catalog, string type)
            {
                double hp = 0;
                int counter = 0;
                foreach (var idxVehicle in catalog)
                {
                    if (idxVehicle.Type == type)
                    {
                        counter++;
                        hp += idxVehicle.Horsepower;
                    }
                }

                if (counter == 0 || hp == 0) return 0;
                return hp / counter;
            }
        }
        public static string Upper(string aInput)
        {

            char[] a = aInput.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

    }
}