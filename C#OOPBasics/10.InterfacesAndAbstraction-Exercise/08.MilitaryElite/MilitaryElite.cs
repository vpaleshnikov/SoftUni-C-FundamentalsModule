using System;
using System.Collections.Generic;

public class MilitaryElite
{
    public static void Main()
    {
        var soldiers = new List<Soldier>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "Private")
            {
                AddPrivate(soldiers, tokens);
            }
            else if (tokens[0] == "LeutenantGeneral")
            {
                AddLeutanant(soldiers, tokens);
            }
            else if (tokens[0] == "Engineer")
            {
                AddEngineer(soldiers, tokens);
            }
            else if (tokens[0] == "Commando")
            {
                AddCommando(soldiers, tokens);
            }
            else if (tokens[0] == "Spy")
            {
                AddSpy(soldiers, tokens);
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    private static void AddSpy(List<Soldier> soldiers, string[] tokens)
    {
        soldiers.Add(new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4])));
    }

    private static void AddCommando(List<Soldier> soldiers, string[] tokens)
    {
        if (tokens[5] == "Airforces" || tokens[5] == "Marines")
        {
            var commando = new Commando(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]),
                tokens[5]);

            if (tokens.Length > 5)
            {
                for (int i = 6; i < tokens.Length; i += 2)
                {
                    if (tokens[i + 1] == "inProgress" || tokens[i + 1] == "Finished")
                    {
                        commando.Missions.Add(new Mission(tokens[i], tokens[i + 1]));
                    }
                }
            }
            soldiers.Add(commando);
        }
    }

    private static void AddEngineer(List<Soldier> soldiers, string[] tokens)
    {
        if (tokens[5] == "Airforces" || tokens[5] == "Marines")
        {
            var engineer = new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]), tokens[5]);

            if (tokens.Length > 5)
            {
                for (int i = 6; i < tokens.Length; i += 2)
                {
                    var repair = new Repair(tokens[i], int.Parse(tokens[i + 1]));
                    engineer.Repairs.Add(repair);
                }
            }
            soldiers.Add(engineer);
        }
    }

    private static void AddLeutanant(List<Soldier> soldiers, string[] tokens)
    {
        var leutenantGeneral = new LeutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]));

        foreach (var soldier in soldiers)
        {
            if (soldier.GetType().FullName == "Private" && !leutenantGeneral.Privates.Contains((Private)soldier))
            {
                leutenantGeneral.Privates.Add((Private)soldier);
            }
        }

        soldiers.Add(leutenantGeneral);
    }

    private static void AddPrivate(List<Soldier> soldiers, string[] tokens)
    {
        soldiers.Add(new Private(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4])));
    }
}