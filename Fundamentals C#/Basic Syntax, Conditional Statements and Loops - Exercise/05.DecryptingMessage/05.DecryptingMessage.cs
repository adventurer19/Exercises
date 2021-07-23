using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string sumMessage = "";

            for (int i = 0; i < lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int value = input + key;

                char message = (char)value;
                sumMessage += message;
            }
            Console.WriteLine(sumMessage);
        }
    }
}