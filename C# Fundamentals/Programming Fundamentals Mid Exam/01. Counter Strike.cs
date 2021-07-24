using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int battles = 0;
            bool exitResult = false;
            while (true)
            {
                string distance = Console.ReadLine();
                if (distance == "End of battle")
                {
                    exitResult = true;
                    break;
                }
                int y = int.Parse(distance);
                if (initialEnergy < y)
                {
                    break;
                }

                initialEnergy -= y;
                battles++;
                if (battles % 3 == 0)
                {
                    initialEnergy += battles;
                }
                //"End of battle"
            }

            if (exitResult)
            {
                Console.WriteLine($"Won battles: {battles}. Energy left: {initialEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {battles} won battles and {initialEnergy} energy");
            }

        }
    }
}