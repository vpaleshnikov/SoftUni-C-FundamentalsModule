using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var personInfo = input.Split();

            var personName = personInfo[0];
            var personAge = int.Parse(personInfo[1]);
            var personTown = personInfo[2];

            people.Add(new Person(personName, personAge, personTown));
        }

        var indexOfPerson = int.Parse(Console.ReadLine());

        var person = FindPerson(indexOfPerson, people);
        
        PrintOutput(people, person, indexOfPerson);
    }

    private static Person FindPerson(int indexOfPerson, List<Person> people)
    {
        var person = new Person();

        var indexFinder = 0;
        foreach (var p in people)
        {
            indexFinder++;
            if (indexFinder == indexOfPerson)
            {
                person = p;
            }
        }
        return person;
    }

    private static void PrintOutput(List<Person> people, Person person, int indexOfPerson)
    {
        var equals = 1;
        var notEquals = 0;
        var total = people.Count;
        var counter = 0;
        var isMatch = false;

        foreach (var p in people)
        {
            counter++;
            if (counter != indexOfPerson)
            {
                if (p.CompareTo(person) == 0)
                {
                    isMatch = true;
                    equals++;
                }
                else
                {
                    notEquals++;
                }
            }
        }
        if (isMatch)
        {
            Console.WriteLine($"{equals} {notEquals} {total}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}