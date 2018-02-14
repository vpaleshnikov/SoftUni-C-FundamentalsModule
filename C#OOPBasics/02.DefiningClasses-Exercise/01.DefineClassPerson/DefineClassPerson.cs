using System;

public class DefineClassPerson
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        var person = new Person()
        {
            Name = name,
            Age = age
        };


        Console.WriteLine($"{person.Name} {person.Age}");
    }
}

