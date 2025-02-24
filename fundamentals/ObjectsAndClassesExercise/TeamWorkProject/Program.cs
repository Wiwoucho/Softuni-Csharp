using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            HashSet<string> teamNames = new HashSet<string>();
            HashSet<string> teamCreators = new HashSet<string>();
            Dictionary<string, string> userTeams = new Dictionary<string, string>(); // User -> Team mapping

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];

                if (teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamCreators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    teamNames.Add(teamName);
                    teamCreators.Add(creator);
                    userTeams[creator] = teamName;
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") break;

                string[] parts = input.Split("->");
                string user = parts[0];
                string teamName = parts[1];

                if (!teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (userTeams.ContainsKey(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    teams.First(t => t.TeamName == teamName).Members.Add(user);
                    userTeams[user] = teamName;
                }
            }

            var validTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName);

            var disbandedTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName);

            foreach (var team in validTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
