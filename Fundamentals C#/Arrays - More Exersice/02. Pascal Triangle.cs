using System;
using System.Linq;

namespace _321
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] startArray = new int[] { 1 };
            for (int i = 0; i < rows; i++)
            {
                if (i != 0)
                {
                    int[] endArray = new int[startArray.Length + 1];
                    endArray[0] = 1;
                    endArray[endArray.Length - 1] = 1;
                    for (int j = 1; j < endArray.Length - 1; j++)
                    {
                        endArray[j] = startArray[i - j] + startArray[j];
                    }
                    startArray = endArray;
                    Console.WriteLine(string.Join(' ', endArray));
                }
                else
                {
                    Console.WriteLine(1);
                }

            }


        }
    }
}