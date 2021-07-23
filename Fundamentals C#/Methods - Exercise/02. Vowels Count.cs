using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string output = $"{small(text)}";
            Console.WriteLine(output);

        }
        private static int small(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char x = Convert.ToChar(text[i]);
                switch (x)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        counter++;
                        break;
                    default:
                        break;
                }

            }
            return counter;



        }

    }
}