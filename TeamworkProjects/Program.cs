using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string user = arr[0];
                string teamName = arr[1];

                if (TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (CreatorAlreadyListed(teams, user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, user);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }

            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArguments = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = cmdArguments[0];
                string teamName = cmdArguments[1];

                if (!TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else 
                {
                    Team teamToJoin = teams
                        .First(x => x.TeamName == teamName);

                    teamToJoin.AddMember(user);
                }
            }



            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x=>x.Members.Count)
                .ThenBy(t=>t.TeamName)
                .ToList();

            foreach (Team x in teamsWithMembers)
            {
                Console.WriteLine($"{x.TeamName}");
                Console.WriteLine($"- {x.Creator}");
                foreach (string member in x.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }


            List<Team> teamsToDisband = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x=>x.TeamName)
                .ToList();


            Console.WriteLine("Teams to disband:");
            foreach (Team x in teamsToDisband)
            {
                Console.WriteLine($"{x.TeamName}");
            }

        }
        static bool TeamAlreadyExists(List<Team> teams, string teamName)
        {
            return teams.Any(x => x.TeamName == teamName);
        }

        static bool CreatorAlreadyListed(List<Team> teams, string creator)
        {
            return teams.Any(x => x.Creator==creator);
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string member)
        {
            return teams.Any(x => x.Members.Contains(member))||
                teams.Any(x=>x.Creator==member);
        }
    }

    public class Team
    {
        private readonly List<string> members;
        public string TeamName { get; set; }
        public string Creator { get; set; }


        //get-omly property
        public List<string> Members
            => members;

        public Team(string teamName,string creator)
        {
            TeamName = teamName;
            Creator = creator;
            this.members = new List<string>();
        }

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}
