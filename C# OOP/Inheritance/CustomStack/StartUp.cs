using System;
using System.Collections.Generic;
using CustomRandomList;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var array = new string[]
            {
                "Rufus", "Bear", "Dakota", "Fido",
                "Vanya", "Samuel", "Koani", "Volodya",
                "Prince", "Yiska"

            };
            var names = new StackOfStrings();
            names.AddRange(array);
            while (!names.IsEmpty())
            {
                Console.WriteLine(names.Pop());
            }
            





        }
    }
}
