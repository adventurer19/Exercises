using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            string concealedMsg = Console.ReadLine();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] instructions = input.Split(":|:").ToArray();
                if (instructions[0] == "InsertSpace")
                {
                    int index = int.Parse(instructions[1]);
                    concealedMsg = concealedMsg.Insert(index, " ");

                }
                else if (instructions[0] == "Reverse")
                {
                    string substring = instructions[1];
                    if (concealedMsg.Contains(substring))
                    {
                        int index = concealedMsg.IndexOf(substring);
                        concealedMsg = concealedMsg.Remove(index, substring.Length);
                        char[] reversed = substring.ToCharArray();
                        Array.Reverse(reversed);
                        string reverse = new string(reversed);
                        concealedMsg += reverse;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;

                    }
                }
                else if (instructions[0] == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];
                    concealedMsg = concealedMsg.Replace(substring, replacement);
                }

                Console.WriteLine(concealedMsg);
            }

            Console.WriteLine($"You have a new text message: {concealedMsg}");

        }
    }


}