using System;
using System.Collections.Generic;

public class BorderControl
{
    public static void Main()
    {
        var society = new List<Society>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3)
            {
                society.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }
            else if (tokens.Length < 3)
            {
                society.Add(new Robot(tokens[0], tokens[1]));
            }
        }

        input = Console.ReadLine();

        foreach (var dystopianSociety in society)
        {
            if (dystopianSociety.Id.EndsWith(input))
            {
                Console.WriteLine($"{dystopianSociety.Id}");
            }
        }
    }
}