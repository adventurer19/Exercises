using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Football_Team_Generatorn
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var listOfTeams = new List<Team>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var token = input.Split(';');
                string command = token[0];
                string teamName = token[1];
                switch (command)
                {
                    case "Add" when listOfTeams.Any(x => x.Name == teamName):
                        var name = token[2];
                        var a1 = int.Parse(token[3]);
                        var a2 = int.Parse(token[4]);
                        var a3 = int.Parse(token[5]);
                        var a4 = int.Parse(token[6]);
                        var a5 = int.Parse(token[7]);
                        try
                        {
                            var player = new Player(name, a1, a2, a3, a4, a5);
                            listOfTeams.First(x=>x.Name==teamName).AddPlayer(player);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Remove" when listOfTeams.Any(x => x.Name == teamName):
                        try
                        {
                            listOfTeams.First(x => x.Name == teamName).Removed(token[2]);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            
                        }
                        break;
                    case"Team":
                        listOfTeams.Add(new Team(teamName));
                        break;
                    case "Rating" when listOfTeams.Any(x => x.Name == teamName):
                        Team team = listOfTeams.First(x => x.Name == teamName);
                        Console.WriteLine($"{teamName} - {team.AvgRating}");
                        break;
                    default:
                        Console.WriteLine($"Team {teamName} does not exist.");
                        break;
                }
            }
        }
    }
}
