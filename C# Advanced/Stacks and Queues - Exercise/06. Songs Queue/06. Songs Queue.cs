using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Queue<string> songQueue = new Queue<string>(songs);
            while (songQueue.Any())
            {
                string xline = Console.ReadLine();
                if (xline.StartsWith("Add"))
                {
                    string songName = xline.Substring(4);
                    if (songQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(songName);
                    }
                }
                else if (xline.StartsWith("Show"))
                {
                    string allSong = string.Join(", ", songQueue);
                    Console.WriteLine(allSong);
                }
                else if (xline.StartsWith("Play"))
                {
                    songQueue.Dequeue();
                }

            }

            Console.WriteLine("No more songs!");
        }
    }



}