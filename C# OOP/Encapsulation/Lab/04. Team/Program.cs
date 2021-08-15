using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {   
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]));
                    persons.Add(person);

                }

                var team = new Team("teamPro");
                persons.ForEach(p => team.AddPlayer(p));
                Console.WriteLine($"First team: {team.FirstTeam.Count} players.");
                Console.WriteLine($"Reserve team: {team.ReserveTeam.Count} players.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
           



        }


    }
}
