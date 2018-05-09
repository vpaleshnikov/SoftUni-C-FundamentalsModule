using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var people = new List<IBuyer>();
        var numberOfInputLine = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInputLine; i++)
        {
            var input = Console.ReadLine().Split(' ');

            if (input.Length == 4)
            {
                var citizen = new Citizen(input[0]);
                people.Add(citizen);
            }
            else if (input.Length == 3)
            {
                var rebel = new Rebel(input[0]);
                people.Add(rebel);
            }
        }

        string buyer;
        while ((buyer = Console.ReadLine()) != "End")
        {
            foreach (var person in people)
            {
                if (person.Name == buyer)
                {
                    person.BuyFood();
                }
            }
        }

        Console.WriteLine(people.Sum(x => x.Food));
    }
}