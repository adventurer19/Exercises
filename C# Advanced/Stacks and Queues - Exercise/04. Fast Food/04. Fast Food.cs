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

            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queOrders = new Queue<int>(orders);
            Console.WriteLine(queOrders.Max());
            while (queOrders.Count > 0)
            {
                int x = queOrders.Peek();
                if (quantity - x >= 0)
                {
                    quantity -= x;
                    queOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            string result = queOrders.Count >= 1 ? $"Orders left: {string.Join(" ", queOrders)}" : "Orders complete";
            Console.WriteLine(result);

        }
    }



}