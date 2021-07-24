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

            int integer = int.Parse(Console.ReadLine());
            Stack<int> queInt = new Stack<int>();
            for (int i = 0; i < integer; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                while (true)
                {
                    if (numbers[0] == 1)
                    {
                        queInt.Push(numbers[1]);
                    }
                    else if (numbers[0] == 2)
                    {
                        if (queInt.Count > 0)
                        {
                            queInt.Pop();

                        }

                    }
                    else if (numbers[0] == 3)
                    {
                        if (queInt.Count > 0)
                        {
                            Console.WriteLine(queInt.Max());

                        }
                    }
                    else if (numbers[0] == 4)
                    {
                        if (queInt.Count > 0)
                        {
                            Console.WriteLine(queInt.Min());

                        }
                    }

                    break;
                }

            }
            Console.WriteLine(string.Join(", ", queInt));


        }
    }



}