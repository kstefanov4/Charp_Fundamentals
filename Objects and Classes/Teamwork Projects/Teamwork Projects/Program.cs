using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Team
    {
        private string teamName_;
        private string creatorName_;
        private List<string> teamMembers_;

        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            creatorName_ = creatorName;
            TeamMembers = new List<string>();
        }

        public string TeamName
        {
            get => teamName_;
            set => teamName_ = value;
        }
        public string CreatorName
        {
            get => creatorName_;

        }
        public List<string> TeamMembers
        {
            get => teamMembers_;
            set => teamMembers_ = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string creator = input.Split("-")[0];
                string teamName = input.Split("-")[1];
                

                if (teamList.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamList.Any(team => team.CreatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName,creator);
                    teamList.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string user = command.Split("->")[0];
                string teamToJoin = command.Split("->")[1];

                if (!teamList.Any(team => team.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teamList.Any(team => team.TeamMembers.Contains(user) || teamList.Any(team => team.CreatorName == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    teamList.First(team => team.TeamName == teamToJoin)
                        .TeamMembers.Add(user);
                    
                }

                command = Console.ReadLine();
            }

            List<Team> teamToDisband = teamList.Where(team => team.TeamMembers.Count == 0).ToList(); 
            List<Team> teamsWithMembers = teamList.Where(team => team.TeamMembers.Count > 0).ToList();
            
            foreach (Team team in teamsWithMembers.OrderByDescending(x => x.TeamMembers.Count).ThenBy(x=>x))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (string member in team.TeamMembers.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamToDisband.OrderBy(x=>x))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
