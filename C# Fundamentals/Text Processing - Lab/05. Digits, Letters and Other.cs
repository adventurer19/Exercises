using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        List<char> numbers = new List<char>();
        List<char> chars = new List<char>();
        List<char> symb = new List<char>();
        char[] line = input.ToCharArray();
        for (int i = 0; i < input.Length; i++)
        {
            int y = Convert.ToInt32(input[i]);
            if (y >= 48 && y <= 57)
            {
                numbers.Add(input[i]);
            }
            else if ((y >= 65 && y <= 90) || (y >= 97 && y <= 122))
            {
                chars.Add(input[i]);
            }
            else if ((y >= 33 && y <= 47) ||
                     (y >= 58 && y <= 64) ||
                     (y >= 91 && y <= 96) ||
                     (y >= 123 && y <= 126))
            {
                symb.Add(input[i]);
            }

        }

        Console.WriteLine(string.Join("", numbers));
        Console.WriteLine(string.Join("", chars));
        Console.WriteLine(string.Join("", symb));


    }
}