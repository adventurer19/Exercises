using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            var state = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < state.Length; i++)
            {
                for (int j = state[i]; j < 4; j++)
                {
                    if (number == 0)
                    {
                        break;

                    }
                    state[i] += 1;
                    number--;
                }

            }
            string wagon = string.Join(' ', state);
            string empty = "The lift has empty spots!";
            string full = $"There isn't enough space! {number} people in a queue!";
            if (number == 0 && state.All(x => x == 4))
            {
                Console.WriteLine(wagon);
            }
            else
            {
                Console.WriteLine(state.Any(x => x < 4) ? $"{empty} \n{wagon}" : $"{full} \n{wagon}");
            }

        }
    }



}