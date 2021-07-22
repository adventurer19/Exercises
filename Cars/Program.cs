using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject
{


    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string line = Console.ReadLine();
            var filter = new List<string>();
            while (line != "Party!")
            {
                var token = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (token[0] == "Remove")
                {
                    if (token[1] == "StartsWith")
                    {
                        string letter = token[2];
                        names = names.Where(t => !t.StartsWith(letter)).ToList();
                    }
                    else if (token[1] == "Length")
                    {
                        int lenght = int.Parse(token[2]);
                        names = names.Where(t => t.Length != lenght).ToList();
                    }
                  
                }
                else if(token[1]=="Double")
                {
                    if (token[1] == "StartsWith")
                    {
                        string letter = token[2];
                        var words = names.FindAll(t => t.StartsWith(letter));
                        if (words.Count > 0)
                        {
                            var index = names.FindIndex(t => t.StartsWith(letter));
                            names.InsertRange(index,words);

                        }
                    }
                    else if (token[1] == "Length")
                    {
                        int lenght = int.Parse(token[2]);
                        var words = names.FindAll(t => t.Length == lenght);
                        if (words.Count > 0)
                        {
                            var index = names.FindIndex(t => t.Length == lenght);
                            names.InsertRange(index,words);

                        }
                    }


                }

                line = Console.ReadLine();
            }

            string result = $"{string.Join(", ", names)} are going to the party!";
            string noresult = $"Nobody is going to the party!";
            Console.WriteLine(names.Count >= 1 ? result : noresult);

        }
    }

}