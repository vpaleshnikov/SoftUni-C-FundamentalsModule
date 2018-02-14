using System;
using System.Linq;

public class OldesFamilyMember
{
    public static void Main()
    {
        var family = new Family();

        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            var input = Console.ReadLine().Split(new []{" "},StringSplitOptions.RemoveEmptyEntries);
            
            var person = new Person()
            {
                Name = input[0],
                Age =  int.Parse(input[1])
            };
            
           family.people.Add(person);
        }

        foreach (var person in family.people.OrderByDescending(a => a.Age))
        {
            Console.WriteLine($"{person.Name} {person.Age}");
            break;
        }
    }
}