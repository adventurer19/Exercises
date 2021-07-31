using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipes = new SortedDictionary<int, string>()
            {
                {25,"Bread"},
                {50,"Cake"},
                {75,"Pastry"},
                {100,"Fruit Pie"}

            };
            var allProducts = new SortedDictionary<string, int>();
            Fill(recipes, allProducts);
            var lineOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var lineTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var que = new Queue<int>(lineOne);
            var stack = new Stack<int>(lineTwo);
            while (que.Count>0 && stack.Count>0)
            {
                int value = que.Peek() + stack.Peek();
                if (recipes.ContainsKey(value))
                {
                    que.Dequeue();
                    stack.Pop();
                    string product = recipes[value];
                    allProducts[product]++;
                }
                else
                {
                    que.Dequeue();
                    stack.Push(stack.Pop()+3);
                }

            }

            bool cookedAll = allProducts.All(x => x.Value != 0);
            Console.WriteLine(cookedAll ? "Wohoo! You succeeded in cooking all the food!" :
            "Ugh, what a pity! You didn't have enough materials to cook everything.");
            Console.WriteLine(que.Count <= 0 ? "Liquids left: none" : $"Liquids left: {string.Join(", ", que)}");
            Console.WriteLine(stack.Count <= 0 ? "Ingredients left: none" : $"Ingredients left: {string.Join(", ",stack)}");
            foreach (var item in allProducts)
            {

                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
        }

        private static void Fill(SortedDictionary<int, string> recipes, SortedDictionary<string, int> allProducts)
        {
            foreach (var item in recipes)
            {
                allProducts.Add(item.Value, 0);
            }
        }
    }
}
