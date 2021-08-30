using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //var line = int.Parse(Console.ReadLine());
            //var list = new List<string>();
            //for (int i = 0; i < line; i++)
            //{
            //    var input = double.Parse(Console.ReadLine());
            //    list.Add(input);
            //}
            //var box = new Box<double>(list);
            //var indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            //    .ToArray();
            //box.Swap(list,indexes[0],indexes[1]);
            //Console.WriteLine(box);
            var line = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < line; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box = new Box<double>(list);
            var elementToCompare = double.Parse(Console.ReadLine());
            var resultCount = box.Count(list, elementToCompare);
            Console.WriteLine(resultCount);

        }
    }
}
