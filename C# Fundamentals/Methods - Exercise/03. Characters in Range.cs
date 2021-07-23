using System;
using System.Linq;
using System.Text;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string result = $"{distance(start, end)}";
            Console.WriteLine(result);

            static StringBuilder distance(char start, char end)
            {
                StringBuilder text = new StringBuilder();
                var line = text;
                if (start < end)
                {
                    for (int i = start + 1; i <= end - 1; i++)
                    {
                        text.Append(Convert.ToChar(i) + " ");

                    }
                    line = text;
                }
                else if (start > end)
                {
                    for (int i = end + 1; i < start; i++)
                    {
                        text.Append(Convert.ToChar(i) + " ");
                    }
                    line = text;

                }
                else
                {
                    line = text.Append(start);
                }
                return line;
            }
        }

    }
}