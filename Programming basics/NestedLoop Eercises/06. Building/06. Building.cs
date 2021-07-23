using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {

            int floor = int.Parse(Console.ReadLine());
            int roomsPerFloars = int.Parse(Console.ReadLine());

            for (int currentflooor = floor; currentflooor > 0; currentflooor--)
            {
                for (int numApartments = 0; numApartments < roomsPerFloars; numApartments++)
                {
                    if (currentflooor == floor)
                    {
                        Console.Write($"L{currentflooor}{numApartments} ");
                        continue;
                    }
                    else if (currentflooor % 2 == 0)
                    {
                        Console.Write($"O{currentflooor}{numApartments} ");

                    }
                    else
                    {
                        Console.Write($"A{currentflooor}{numApartments} ");

                    }


                }
                Console.WriteLine();
            }





        }

    }
}