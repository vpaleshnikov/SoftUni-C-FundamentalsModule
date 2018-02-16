using System;
using System.Collections.Generic;
using System.Linq;

public class CatLady
{
    public static void Main()
    {
        var cats = new List<Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var breed = tokens[0];

            var cat = new Cat();
            cat.Breed = breed;
            cat.Name = tokens[1];

            if (cat.Breed == "Siamese")
            {
                cat.Siamese = new Siamese(int.Parse(tokens[2]));
            }
            else if (cat.Breed == "Cymric")
            {
                cat.Cymric = new Cymric(double.Parse(tokens[2]));
            }
            else if (cat.Breed == "StreetExtraordinaire")
            {
                cat.StreetExtraordinaire = new StreetExtraordinaire(int.Parse(tokens[2]));
            }

            cats.Add(cat);
        }

        string name = Console.ReadLine();
        foreach (var cat in cats)
        {
            if (name == cat.Name)
            {
                if (cat.Breed == "Cymric")
                {
                    Console.WriteLine($"Cymric {cat.Name} {cat.Cymric.FurLenght:F2}");
                }
                else if (cat.Breed == "Siamese")
                {
                    Console.WriteLine($"Siamese {cat.Name} {cat.Siamese.EarsSize}");
                }
                else
                {
                    Console.WriteLine($"{cat.Breed} {cat.Name} {cat.StreetExtraordinaire.DecibelsOfMeows}");
                }
            }
        }
    }
}