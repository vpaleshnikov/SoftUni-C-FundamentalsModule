using System;
using System.Collections.Generic;
using System.Linq;

public class FootballTeamGenerator
{
    public static void Main()
    {
        var teams = new List<Team>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(';');
            if (tokens[0].ToLower() == "team")
            {
                var team = CreateNewTeam(tokens);
                teams.Add(team);
            }
            else if (tokens[0].ToLower() == "add")
            {
                var teamName = tokens[1];
                var playerName = tokens[2];
                var endurance = int.Parse(tokens[3]);
                var sprint = int.Parse(tokens[4]);
                var dribble = int.Parse(tokens[5]);
                var passing = int.Parse(tokens[6]);
                var shooting = int.Parse(tokens[7]);
                
                if (teams.Any(t => t.Name == teamName))
                {
                    var team = teams.First(x => x.Name == teamName);
                    try
                    {
                        team.AddPlayer(new Player(playerName, new Stats(endurance, sprint, dribble, passing, shooting)));
                    }
                    catch (ArgumentException argumentException)
                    {
                        Console.WriteLine(argumentException.Message);
                    }
                    teams.Remove(teams.First(x => x.Name == teamName));
                    teams.Add(team);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                }
            }
            else if (tokens[0].ToLower() == "remove")
            {
                var teamName = tokens[1];
                var playerName = tokens[2];

                if (teams.Any(t => t.Players.Any(p => p.Name == playerName)))
                {
                    var team = teams.First(x => x.Name == teamName);
                    var player = team.Players.First(p => p.Name == playerName);

                    team.RemovePlayer(player);
                    teams.Remove(teams.First(t => t.Name == teamName));
                    teams.Add(team);
                }
                else
                {
                    Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                }
            }
            else if (tokens[0].ToLower() == "rating")
            {
                if (teams.Any(t => t.Name == tokens[1]))
                {
                    if (teams.Count == 0)
                    {
                        Console.WriteLine($"{tokens[1]} - 0");
                    }
                    else
                    {
                        var team = teams.First(t => t.Name == tokens[1]);
                        Console.WriteLine($"{team.Name} - {team.AverageRating()}");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {tokens[1]} does not exist.");
                }
            }

        }
    }

    private static Team CreateNewTeam(string[] tokens)
    {
        var teamName = tokens[1];
        var team = new Team(teamName);

        return team;
    }
}