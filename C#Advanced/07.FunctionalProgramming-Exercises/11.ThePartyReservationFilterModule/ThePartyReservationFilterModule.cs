using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class ThePartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var filters = new List<string>();

            var input = Console.ReadLine();

            while (input != "Print")
            {
                var sequenceOfCommands = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = sequenceOfCommands[0];
                var filterType = sequenceOfCommands[1];
                var filterParameter = sequenceOfCommands[2];

                if (command == "Add filter")
                {
                    filters.Add($"{filterType} {filterParameter}");
                }
                else if(command == "Remove filter")
                {
                    filters.Remove($"{filterType} {filterParameter}");
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    names = names.Where(n => !n.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    names = names.Where(n => !n.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    names = names.Where(n => n.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    names = names.Where(n => !n.Contains(commands[1])).ToList();
                }
            }
            
            Console.WriteLine(string.Join(" ",names));
        }
    }
}