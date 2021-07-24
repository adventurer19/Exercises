using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            int lastPositionIndex = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Love!") break;
                string[] line = command.Split(' ').ToArray();
                if (line[0] == "Jump")
                {
                    lastPositionIndex += int.Parse(line[1]);
                    // 0 1 2 4 5 
                    if (lastPositionIndex >= numbers.Length)
                    {
                        lastPositionIndex = 0;
                    }

                    if (numbers[lastPositionIndex] == 0)
                    {
                        Console.WriteLine($"Place {lastPositionIndex} already had Valentine's day.");
                    }
                    else
                    {
                        numbers[lastPositionIndex] -= 2;
                        if (numbers[lastPositionIndex] == 0)
                        {
                            Console.WriteLine($"Place {lastPositionIndex} has Valentine's day.");
                        }
                    }
                }


            }
            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0) counter++;
            }

            if (numbers.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }


    }
}