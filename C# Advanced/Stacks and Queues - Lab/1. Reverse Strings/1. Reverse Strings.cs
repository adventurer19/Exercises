using System;
using System.Collections.Generic;


namespace example
{
    class Program
    {
        static void Main()
        {

            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> charStack = new Stack<char>();
            foreach (var idx in input)
            {
                charStack.Push(idx);
            }
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }

            Console.WriteLine();
        }

    }



}