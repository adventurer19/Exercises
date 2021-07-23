using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int takenspace = 0;
            int space = width * lenght * height;
            while (input != "Done")
            {
                int numBoxes = int.Parse(input);


                takenspace += numBoxes;
                space -= numBoxes;
                if (space <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();


            }
            if (input == "Done")
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }


        }

    }
}
