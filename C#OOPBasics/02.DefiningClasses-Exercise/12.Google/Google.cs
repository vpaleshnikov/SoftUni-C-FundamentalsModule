using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Google
{
    public static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var person = people.FirstOrDefault(p => p.Name == tokens[0]);
            if (person == null)
            {
                person = new Person(tokens[0]);
                AddPersonalInformation(tokens, person);
                people.Add(person);
            }
            else
            {
                AddPersonalInformation(tokens, person);
            }
        }

        var name = Console.ReadLine();

        foreach (var person in people)
        {
            if (person.Name == name)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine("Company:");
                if (person.Company != null)
                {
                    Console.WriteLine($"{person.Company.Name} {person.Company.Department} {person.Company.Salary:F2}");
                }

                Console.WriteLine("Car:");
                if (person.Car != null)
                {
                    Console.WriteLine($"{person.Car.Model} {person.Car.Speed}");
                }

                Console.WriteLine("Pokemon:");
                if (person.Pokemons.Count > 0)
                {
                    foreach (var pokemons in person.Pokemons)
                    {
                        Console.WriteLine($"{pokemons.Name} {pokemons.Type}");
                    }
                }

                Console.WriteLine("Parents:");
                if (person.Parents.Count > 0)
                {
                    foreach (var parent in person.Parents)
                    {
                        Console.Write($"{parent.Name} ");
                        Console.WriteLine(String.Format($"{parent.Birthday:dd/MM/yyyy}"));
                    }
                }

                Console.WriteLine("Children:");
                if (person.Children.Count > 0)
                {
                    foreach (var child in person.Children)
                    {
                        Console.Write($"{child.Name} ");
                        Console.WriteLine(String.Format($"{child.Birthday:dd/MM/yyyy}"));
                    }
                }
            }
        }
    }

    private static void AddPersonalInformation(string[] tokens, Person person)
    {
        if (tokens[1] == "company")
        {
            person.Company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4]));
        }
        else if (tokens[1] == "car")
        {
            person.Car = new Car(tokens[2], int.Parse(tokens[3]));
        }
        else if (tokens[1] == "pokemon")
        {
            person.Pokemons.Add(new Pokemon(tokens[2], tokens[3]));
        }
        else if (tokens[1] == "parents")
        {
            person.Parents.Add(new Parent(tokens[2], DateTime.ParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
        }
        else if (tokens[1] == "children")
        {
            person.Children.Add(new Child(tokens[2], DateTime.ParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
        }
    }
}