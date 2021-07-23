using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string comand = Console.ReadLine();
                string[] line = comand.Split(' ')
                    .ToArray();
                if (comand == "End") break;
                if (line[0] == "Add")
                {
                    int x = int.Parse(line[1]);
                    nums.Add(x);
                }
                else if (line[0] == "Remove")
                {
                    int x = int.Parse(line[1]);
                    if (nums.Count >= x && x >= 0)
                    {
                        nums.RemoveAt(x);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (line[0] == "Insert")
                {
                    int x = int.Parse(line[1]);
                    int y = int.Parse(line[2]);
                    if (y <= nums.Count && y >= 0)
                    {
                        nums.Insert(y, x);

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");

                    }

                }
                else if (line[0] == "Shift" && line[1] == "left")
                {
                    int y = int.Parse(line[2]);
                    for (int i = 0; i < y; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }
                else if (line[0] == "Shift" && line[1] == "right")
                {
                    int y = int.Parse(line[2]);
                    for (int i = 0; i < y; i++)
                    {
                        nums.Insert(0, nums[nums.Count - 1]);
                        nums.RemoveAt(nums.Count - 1);
                    }

                }

            }

            Console.WriteLine(string.Join(' ', nums));
        }

        //private static void Shift(string[] line,List<int>numbers)
        //{
        //    //1 23 29 18 43 20 5
        //    //if (line[1] =="left")
        //    //{
        //    //    int y = int.Parse(line[2]);
        //    //    for (int i = 0; i < y; i++)
        //    //    {
        //    //        numbers.Add(numbers[0]);
        //    //       numbers.RemoveAt(0);
        //    //    }
        //    //}
        //    //else if(line[1] =="right")
        //    //{
        //    //    int y = int.Parse(line[2]);
        //    //    for (int i = 0; i < y; i++)
        //    //    {
        //    //        numbers.Insert(0,numbers[numbers.Count-1]);
        //    //        numbers.RemoveAt(numbers.Count-1);

        //    //    }
        //    //}
        //    //else if(line[1]== "right")
        //}
    }
}