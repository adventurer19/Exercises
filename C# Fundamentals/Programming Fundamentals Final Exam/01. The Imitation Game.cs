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
            string encrypted = Console.ReadLine();
            string input = String.Empty;
            while (input != "Decode")
            {
                input = Console.ReadLine();
                string[] part = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string line = part[0];
                if (line == "Move")
                {
                    int moves = int.Parse(part[1]);
                    string subString = encrypted.Substring(0, moves);
                    encrypted = encrypted.Remove(0, subString.Length);
                    encrypted += subString;
                }
                else if (line == "Insert")
                {
                    int index = int.Parse(part[1]);
                    int validIndex = Math.Min(index, encrypted.Length);
                    string value = part[2];
                    encrypted = encrypted.Insert(validIndex, value);
                }
                else if (line == "ChangeAll")
                {
                    string subString = part[1];
                    if (encrypted.Contains(subString))
                    {
                        string value = part[2];
                        encrypted = encrypted.Replace(subString, value);
                    }

                }

            }
            Console.WriteLine($"The decrypted message is: {encrypted}");
        }
    }


}