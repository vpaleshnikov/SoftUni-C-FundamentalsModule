using System;
using System.Collections.Generic;

public class BirthdayCelebrations
{
    public static void Main()
    {
        var personOrPets = new List<BirthdateAble>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { " ", "/" }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "Citizen")
            {
                personOrPets.Add(new Citizen(tokens[1], tokens[4], tokens[5], tokens[6]));
            }
            else if (tokens[0] == "Pet")
            {
                personOrPets.Add(new Pet(tokens[1], tokens[2], tokens[3], tokens[4]));
            }
        }

        var year = Console.ReadLine();

        foreach (var personOrPet in personOrPets)
        {
            if (personOrPet.Year == year)
            {
                Console.WriteLine($"{personOrPet.Day}/{personOrPet.Month}/{personOrPet.Year}");
            }
        }
    }
}