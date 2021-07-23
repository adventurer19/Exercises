using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodShit
{
    class Program
    {
        static void Main(string[] args)
        {
            double saving = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> defaultDrums = drumSet.ToList();
            string input = String.Empty;
            int[] drums = drumSet.ToArray();
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);
                for (int i = 0; i < drums.Length; i++)
                {
                    if (drums[i] - power <= 0)
                    {
                        double cost = defaultDrums[i] * 3;
                        if (cost <= saving)
                        {
                            saving -= cost;
                            drums[i] = defaultDrums[i];
                        }
                        else
                        {
                            drums[i] = 0;
                        }
                    }
                    else
                    {
                        drums[i] -= power;
                    }
                }

            }

            drumSet = drums.Where(x => x != 0).ToList();
            Console.WriteLine(string.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {saving:f2}lv.");
        }


    }
}