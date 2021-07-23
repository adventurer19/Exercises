using System;

namespace blq_blq
{
    class Program
    {
        static void Main(string[] args)
        {
            string favbook = Console.ReadLine();
            string nextbook = Console.ReadLine();

            int counter = 1;

            while (nextbook != "No More Books")
            {
                if (favbook == nextbook)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    break;
                }


                nextbook = Console.ReadLine();
                counter += 1;

            }
            if (nextbook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter - 1} books.");


            }




        }

    }
}