using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace Classes
{
    class Team
    {
        public string Leader { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }


        public Team()
        {
            Members = new List<string>();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> teamList = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();
                string leader = input[0];
                string teamName = input[1];
                if (ExistingTeam(teamList, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (ExistingLeader(teamList, leader))
                {
                    Console.WriteLine($"{leader} cannot create another team!");
                }
                else
                {
                    Team currentTeam = new Team
                    {
                        Leader = leader,
                        TeamName = teamName
                    };
                    Console.WriteLine($"Team {teamName} has been created by {leader}!");
                    teamList.Add(currentTeam);
                }

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") break;
                string[] token = input.Split("->").ToArray();
                string leader = token[0];
                string team = token[1];
                if (!ExistingTeam(teamList, team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (ExistingPlayers(teamList, leader))
                {
                    Console.WriteLine($"Member {leader} cannot join team {team}!");
                }
                else
                {
                    foreach (var idxTeam in teamList)
                    {
                        if (idxTeam.TeamName == team)
                        {
                            idxTeam.Members.Add(leader);
                        }
                    }
                }

            }

            List<Team> sorted = teamList
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            List<Team> disband = teamList
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName).ToList();
            foreach (var idxTeam in sorted)
            {
                Console.WriteLine(idxTeam.TeamName);
                Console.WriteLine($"- {idxTeam.Leader}");
                idxTeam.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, idxTeam.Members.Select(x => "-- " + x)));

            }

            Console.WriteLine("Teams to disband:");
            foreach (var idx in disband)
            {
                Console.WriteLine(idx.TeamName);
            }

        }

        private static bool ExistingPlayers(List<Team> teamList, string leader)
        {
            foreach (var idxTeam in teamList)
            {

                if (idxTeam.Leader == leader || idxTeam.Members.Contains(leader))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ExistingLeader(List<Team> teamList, string leader)
        {
            foreach (var idxTeam in teamList)
            {
                if (idxTeam.Leader == leader)
                    return true;
            }

            return false;
        }

        private static bool ExistingTeam(List<Team> teamList, string teamName)
        {
            foreach (var idxTeam in teamList)
            {
                if (idxTeam.TeamName == teamName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}