using System;
using System.Collections.Generic;
using System.Linq;


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var stringTires = StringTires(line);
            line = Console.ReadLine();
            var listOfEngines = ListOfEngines(line);
            line = Console.ReadLine();
            var listCars = ListCars(line, stringTires, listOfEngines);
            var special = Special(listCars);
            special.ForEach(t=>Console.WriteLine(t));
        }

        

        private static List<Car> Special(List<Car> listCars)
        {
            var special = new List<Car>();
            foreach (var item in listCars)
            {
                double sum = 0;
                foreach (var idx in item.Tires)
                {
                    sum += idx.Pressure;
                }

                bool tirePressure = sum >= 9 && sum <= 10;
                bool yearEngine = item.Year >= 2017 && item.Engine.HorsePower > 330;
                if (yearEngine && tirePressure)
                {
                    item.Drive(0.2);
                    special.Add(item);
                }
            }

            return special;
        }

        private static List<Car> ListCars(string line, List<string> stringTires, List<Engine> listOfEngines)
        {
            var listCars = new List<Car>();
            while (line != "Show special")
            {
                var tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQua = double.Parse(tokens[3]);
                double fuelCons = double.Parse(tokens[4]);
                int engineIdx = int.Parse(tokens[5]);
                int tiresIdx = int.Parse(tokens[6]);
                var tireArray = stringTires[tiresIdx].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var arrayTires = ArrayTires(tireArray);
                var currentCar = new Car(make, model, year, fuelQua, fuelCons, listOfEngines[engineIdx], arrayTires);
                listCars.Add(currentCar);
                line = Console.ReadLine();
            }

            return listCars;
        }

        private static Tire[] ArrayTires(string[] tireArray)
        {
            List<Tire> listOfTires = new List<Tire>();
            for (int i = 0; i < tireArray.Length; i += 2)
            {
                var curTire = new Tire(int.Parse(tireArray[i]), double.Parse(tireArray[i + 1]));
                listOfTires.Add(curTire);
            }

            var arrayTires = listOfTires.ToArray();
            return arrayTires;
        }

        private static List<Engine> ListOfEngines(string line)
        {
            var listOfEngines = new List<Engine>();
            while (line != "Engines done")
            {
                var tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);
                var currentEngine = new Engine(horsePower, cubicCapacity);
                listOfEngines.Add(currentEngine);
                line = Console.ReadLine();
            }

            return listOfEngines;
        }

        private static List<string> StringTires(string line)
        {
            List<string> stringTires = new List<string>();
            while (line != "No more tires")
            {
                stringTires.Add(line);
                line = Console.ReadLine();
            }

            return stringTires;
        }
    }
}
