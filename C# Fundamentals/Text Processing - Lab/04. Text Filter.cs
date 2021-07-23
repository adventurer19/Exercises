using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {

        string[] banWords = Console.ReadLine().Split(", ").ToArray();
        string text = Console.ReadLine();
        for (int i = 0; i < banWords.Length; i++)
        {
            string replace = String.Empty;
            for (int j = 0; j < banWords[i].Length; j++)
            {
                replace += "*";
            }
            while (text.Contains(banWords[i]))
            {
                text = text.Replace(banWords[i], replace);
            }
        }

        Console.WriteLine(text);

    }
}