using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace traning_2
{
    class Song
    {

        public string typeList;
        public string name;
        public string time;

        public Song(string Atype, string Aname, string Atime)
        {
            typeList = Atype;
            name = Aname;
            time = Atime;
        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split('_', StringSplitOptions.RemoveEmptyEntries).ToArray();
                songs.Add(new Song(parts[0], parts[1], parts[2]));

            }

            string outPutType = Console.ReadLine();
            if (outPutType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.name);
                }
            }
            else
            {
                List<Song> filtered = songs.Where(s => s.typeList == outPutType).ToList();
                foreach (Song song in filtered)
                {
                    Console.WriteLine(song.name);
                }

            }

        }

    }
}