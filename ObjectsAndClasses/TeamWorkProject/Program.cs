using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();
            int teamCounter = 0;
            while (teamCounter<count)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.Creator = newTeam[0];
                team.TeamName= newTeam[1];
                
                team.Members = membersList;
                
                if (!allTeams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!allTeams.Select(x => x.Creator).Contains(team.Creator))
                    {
                        allTeams.Add(team);
                        teamCounter++;
                        Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.Creator} cannot create another team!");
                        

                    }

                }
                else
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    
                }
            }
            string registration;
            while((registration=Console.ReadLine())!= "end of assignment")
            {
                string[] cmd = registration.Split("->").ToArray();
                string name = cmd[0];
                string team = cmd[1];
                if(!allTeams.Select(x=>x.TeamName).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                if (allTeams.Select(x => x.Members).Any(x => x.Contains(name)) || allTeams.Select(x => x.Creator).Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {team}!");
                }
                else
                {
                    int teamToJoinIndex = allTeams.FindIndex(x => x.TeamName == team);
                    allTeams[teamToJoinIndex].Members.Add(name);
                }
                
            }
            var teamsToDisband = allTeams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var otherTeams = allTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0);
            foreach (var item in otherTeams)
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creator}");
                foreach (var members in item.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {members}");
                }
            }
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine($"{item.TeamName}");
            }
        }
        class Team
        {



            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> Members { get; set; }
        }
    }
}

