using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int intValue;
            float floatValue;
            char charValue;
            bool boolValue;

            while (word != "END")
            {
                if (int.TryParse(word, out intValue))
                {
                    Console.WriteLine($"{word} is integer type");
                }
                else if (float.TryParse(word, out floatValue))
                {
                    Console.WriteLine($"{word} is floating point type");
                }
                else if (char.TryParse(word, out charValue))
                {
                    Console.WriteLine($"{word} is character type");
                }
                else if (bool.TryParse(word, out boolValue))
                {
                    Console.WriteLine($"{word} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{word} is string type");

                }
                word = Console.ReadLine();
            }


        }
    }
}