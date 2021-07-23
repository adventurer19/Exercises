using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string firstword = Console.ReadLine().ToLower();
        string phrase = Console.ReadLine();
        string yoyo = phrase.Substring(0);

        while (phrase.Contains(firstword))
        {
            phrase = phrase.Replace(firstword, "");
        }

        Console.WriteLine(phrase);




    }
}