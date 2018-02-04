using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine();

            while (commands != "Party!")
            {
                var commandsParts = commands.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var command = commandsParts[0];
                var criteria = commandsParts[1];
                var filter = commandsParts[2];

                if (criteria == "StartsWith")
                {
                    ActionManager(command, input, a => a.StartsWith(filter));
                }
                else if (criteria == "EndsWith")
                {
                    ActionManager(command, input, a => a.EndsWith(filter));
                }
                else if (criteria == "Length")
                {
                    ActionManager(command, input, a => a.Length == int.Parse(filter));
                }

                commands = Console.ReadLine();
            }

            if (input.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", input.OrderBy(a => a))} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ActionManager(string command, List<string> input, Func<string, bool> condition)
        {
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (condition(input[i]))
                {
                    if (command == "Remove")
                    {
                        input.RemoveAt(i);
                    }
                    else if (command == "Double")
                    {
                        input.Add(input[i]);
                    }
                }
            }
        }
    }
}