using System;

public class TeamExercise
{
    public static void Main()
    {
        int playersCount = int.Parse(Console.ReadLine());
        var team = new Team("SoftUni");

        for (int i = 0; i < playersCount; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var player = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            team.AddPlayer(player);
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}