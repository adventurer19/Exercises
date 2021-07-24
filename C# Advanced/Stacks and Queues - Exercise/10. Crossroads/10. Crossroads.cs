using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Advance
{

    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string currentCar = String.Empty;
            int initual = greenLight;
            int carInside = 0;
            int passedCars = 0;
            bool crash = false;
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    while (greenLight > 0 && cars.Count > 0)
                    {
                        string passedCar = cars.Dequeue();
                        if (passedCar.Length <= greenLight)
                        {
                            //cars.Dequeue();
                            passedCars++;
                            greenLight -= passedCar.Length;
                            continue;
                        }
                        else if (greenLight < passedCar.Length)
                        {
                            carInside = passedCar.Length - greenLight;
                            //currentCar = cars.Dequeue();
                            currentCar = passedCar;
                            break;
                        }
                    }
                    greenLight = initual;
                    if (carInside > freeWindow)
                    {
                        crash = true;
                        break;
                    }
                    else if (carInside != 0)
                    {
                        passedCars++;
                    }
                }
                input = Console.ReadLine();
            }

            if (crash)
            {
                int index = freeWindow + 1;
                Console.WriteLine($"A crash happened!");
                Console.WriteLine($"{currentCar} was hit at {currentCar.Substring(index, 1)}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}