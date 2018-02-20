using System;
using System.Collections.Generic;

public class Validation
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));

                people.Add(person);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }

        }

        var persentage = decimal.Parse(Console.ReadLine());

        people.ForEach(p => p.IncreaseSalary(persentage));
        people.ForEach(p => Console.WriteLine(p));
    }
}