using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace text_proc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            //abv>1>1>2>2asdasd
            int bombPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    bombPower += input[i + 1] - '0';
                    result.Append(input[i]);
                }
                else if (bombPower > 0)
                {
                    bombPower--;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);






        }
    }
}