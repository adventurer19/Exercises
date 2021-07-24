using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrol = new Queue<int>();
            var distance = new Queue<int>();
            int[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }
            int currentFuel;
            var petrolCopy = new Queue<int>();
            var distanceCopy = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                currentFuel = petrol.Peek();
                petrolCopy = new Queue<int>(petrol);
                distanceCopy = new Queue<int>(distance);
                for (int x = 0; x < n; x++)
                {
                    if (distanceCopy.Peek() <= currentFuel)
                    {
                        currentFuel -= distanceCopy.Peek();
                        if (x == n - 1)
                        {
                            Console.WriteLine(i);
                            return;
                        }
                    }
                    else
                    {
                        break;
                    }
                    petrolCopy.Enqueue(petrolCopy.Dequeue());
                    distanceCopy.Enqueue(distanceCopy.Dequeue());
                    currentFuel += petrolCopy.Peek();
                }
                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
                // Run Garbage Collector to reduce used memory for taking test 2
                GC.Collect();
            }
        }
    }
}