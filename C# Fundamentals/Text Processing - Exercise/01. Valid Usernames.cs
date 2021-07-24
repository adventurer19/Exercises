using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split(", ").ToArray();
        // List<string> results = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            char[] chars = input[i].ToCharArray();
            bool exit = false;
            bool validLenght = chars.Length >= 3 && chars.Length <= 16;
            for (int j = 0; j < chars.Length; j++)
            {
                char x = chars[j];
                if (!char.IsLetterOrDigit(x) && (x != '-') && (x != '_'))
                {
                    exit = true;
                    break;
                }

            }
            if (!exit && validLenght)
            {
                string result = new string(chars);
                Console.WriteLine(result);
                //results.Add(result);
            }

        }
        // Console.WriteLine(string.Join("\n",results));

    }

}