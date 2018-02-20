using System;
using System.Collections.Generic;
using System.Linq;

public class Persons
{
    public static void Main()
    {
        var people = new List<Person>();
        var peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var person = new Person(input[0], input[1], int.Parse(input[2]));
            people.Add(person);
        }

        people
            .OrderBy(a => a.FirstName)
            .ThenBy(a => a.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p));
    }
}