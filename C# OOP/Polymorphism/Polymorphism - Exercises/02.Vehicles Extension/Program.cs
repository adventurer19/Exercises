using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Poly
{
    public class Program
    {
        static void Main(string[] args)
        {
            var allVehicles = new Dictionary<string, Vehicle>();
            for (int i = 0; i < 3; i++)
            {
                var cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                double a1 = double.Parse(cmd[1]);
                double a2 = double.Parse(cmd[2]);
                double a3 = double.Parse(cmd[3]);
                Vehicle item;
                if (cmd[0] == "Car")
                {
                    item = new Car(a1, a2, a3);
                }
                else if (cmd[0] == "Truck")
                {
                    item = new Truck(a1, a2, a3);
                }
                else
                {
                    item = new Bus(a1, a2, a3);
                }
                allVehicles.Add(cmd[0],item);
            }

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = cmd[0];
                var typeOfVehicle = cmd[1];
                var amount =double.Parse(cmd[2]);
                switch (command)
                {
                    case"Refuel":
                        switch (typeOfVehicle)
                        {
                            case"Car":
                                allVehicles[cmd[1]].Refuel(amount);
                                break;
                            case "Truck":
                                allVehicles[cmd[1]].Refuel(amount);
                                break;
                            case "Bus":
                                allVehicles[cmd[1]].Refuel(amount);
                                break;
                        }
                        break;
                    case"Drive":
                        switch (typeOfVehicle)
                        {
                            case "Car":
                                allVehicles[cmd[1]].Drive(amount);
                                break;
                            case "Truck":
                                allVehicles[cmd[1]].Drive(amount);
                                break;
                            case "Bus":
                                allVehicles[cmd[1]].Drive(amount);
                                break;
                        }
                        break;
                    case"DriveEmpty":
                        var bus = (Bus)allVehicles["Bus"];
                        bus.DriveEmpty(amount);
                        break;

                }
            }

            foreach (var item in allVehicles.Values)
            {
                Console.WriteLine(item.ShowFuelLeft());
            }

        }
    }
}
