using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        string input;
        var ids = new List<IIdentifiable>();

        while ((input = Console.ReadLine()) != "End")
        {
            var inputParts = input.Split(' ');

            if (inputParts.Length == 3)
            {
                IIdentifiable citizen = new Citizen(inputParts[2]);
                ids.Add(citizen);
            }
            else if (inputParts.Length == 2)
            {
                IIdentifiable robot = new Robot(inputParts[1]);
                ids.Add(robot);
            }
        }

        var fakeNumber = Console.ReadLine();

        foreach (var id in ids)
        {
            if (id.Id.EndsWith(fakeNumber))
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}