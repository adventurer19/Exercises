using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int initialHealth = 100;
            int initialBitcoins = 0;
            int currentHealt = initialHealth;
            string input = Console.ReadLine();
            string[] array = input.Split('|');
            bool iExit = false;
            for (int i = 0; i < array.Length; i++)
            {
                string room = array[i];
                string[] elements = room.Split(" ");
                if (elements[0] == "potion" && currentHealt > 0)
                {
                    int amount = int.Parse(elements[1]);
                    if (currentHealt <= 100)
                    {
                        if (currentHealt + amount <= 100)
                        {
                            Console.WriteLine($"You healed for {amount} hp.");
                            currentHealt += amount;
                        }
                        else if (currentHealt + amount > 100)
                        {
                            Console.WriteLine($"You healed for {100 - currentHealt} hp.");
                            currentHealt = 100;
                        }
                        Console.WriteLine($"Current health: {currentHealt} hp.");
                    }

                }
                else if (elements[0] == "chest")
                {
                    int coins = int.Parse(elements[1]);
                    initialBitcoins += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");

                }
                else if (elements[0] != "chest" && elements[0] != "potion")
                {
                    int attack = int.Parse(elements[1]);
                    if (currentHealt - attack > 0)
                    {
                        Console.WriteLine($"You slayed {elements[0]}.");
                    }
                    else if (currentHealt - attack <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {elements[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        iExit = true;
                        break;
                    }
                    currentHealt -= attack;

                }


            }
            if (!iExit)
            {
                Console.WriteLine($"You've made it!\nBitcoins: {initialBitcoins}\nHealth: {currentHealt}");
            }







        }


    }
}