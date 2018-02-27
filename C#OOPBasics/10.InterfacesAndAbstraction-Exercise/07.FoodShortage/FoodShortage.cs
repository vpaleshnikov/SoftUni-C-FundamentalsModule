using System;
using System.Collections.Generic;

public class FoodShortage
{
    public static void Main()
    {
        var buyers = new List<IBuyer>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 3)
            {
                buyers.Add(new Rebel(tokens[0]));
            }
            else if (tokens.Length > 3)
            {
                buyers.Add(new Citizen(tokens[0]));
            }
        }

        var result = 0;
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var buyer in buyers)
            {
                if (buyer.Name == input)
                {
                    if (buyer.GetType().FullName == "Citizen")
                    {
                        result += 10;
                    }
                    else if (buyer.GetType().FullName == "Rebel")
                    {
                        result += 5;
                    }
                }
            }
        }

        Console.WriteLine(result);
    }
}