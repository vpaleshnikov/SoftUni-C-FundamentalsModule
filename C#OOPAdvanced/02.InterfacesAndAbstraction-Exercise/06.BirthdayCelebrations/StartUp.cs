using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        string input;
        var birthdates = new List<IBirthdate>();

        while ((input = Console.ReadLine()) != "End")
        {
            var inputParts = input.Split(' ');

            if (inputParts[0] == "Robot")
            {
                continue;
            }

            if (inputParts.Length == 5)
            {
                var citizen = new Citizen(inputParts[4]);
                birthdates.Add(citizen);
            }
            else if (inputParts.Length == 3)
            {
                var pet = new Pet(inputParts[2]);
                birthdates.Add(pet);
            }
        }

        var year = Console.ReadLine();
        var years = new List<string>();

        foreach (var birthdate in birthdates)
        {
            if (birthdate.BirthDate.EndsWith(year))
            {
                Console.WriteLine(birthdate.BirthDate);
            }
        }
    }
}