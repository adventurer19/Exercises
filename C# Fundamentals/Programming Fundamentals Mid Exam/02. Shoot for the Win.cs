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
            int[] shots = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string line = String.Empty;
            int counter = 0;
            while (((line = Console.ReadLine()) != "End"))
            {

                int number = int.Parse(line);
                if (number > shots.Length - 1)
                {
                    continue;
                }
                if (shots[number] == -1)
                {
                    continue;
                }

                int shotTarget = shots[number];
                shots[number] = -1;
                counter++;
                for (int i = 0; i < shots.Length; i++)
                {
                    if (shotTarget < shots[i] && shots[i] != -1)
                    {
                        shots[i] -= shotTarget;
                    }
                    else if (shotTarget >= shots[i] && shots[i] != -1)

                    {
                        shots[i] += shotTarget;
                    }

                }

                // Console.WriteLine(string.Join(' ',shots));
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(' ', shots)}");
        }
    }
}