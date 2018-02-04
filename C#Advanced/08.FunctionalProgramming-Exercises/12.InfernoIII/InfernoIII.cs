using System;
using System.Linq;
using System.Collections.Generic;

namespace _12.InfernoIII
{
    class InfernoIII
    {
        static void Main(string[] args)
        {
            var powers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var filter = new List<string>();

            var input = Console.ReadLine();

            while (input != "Forge")
            {
                var commandsInput = input.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandsInput[0];
                var filterType = commandsInput[1];
                var filterParameter = commandsInput[2];

                if (command == "Exclude")
                {
                    filter.Add($"{filterType} {filterParameter}");
                }
                else if (command == "Reverse")
                {
                    filter.Remove($"{filterType} {filterParameter}");
                }

                input = Console.ReadLine();
            }

            foreach (var filt in filter)
            {
                var commands = filt.Split(' ');
                
                if (commands[1] == "Left" && commands[2] == "Right")
                {
                    var sum = int.Parse(commands[3]);

                    for (int i = 0; i < powers.Count; i++)
                    {
                        var powersLeft = (i == 0) ? 0 : powers[i - 1];
                        var powersRight = (i == powers.Count - 1) ? 0 : powers[i + 1];

                        if (powersLeft + powers[i] + powersRight == sum)
                        {
                            powers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (commands[1] == "Right")
                {
                    var sum = int.Parse(commands[2]);

                    while (powers.Last() == sum && powers.Count > 0)
                    {
                        powers.RemoveAt(powers.Count - 1);
                    }

                    for (int i = 0; i < powers.Count - 1; i++)
                    {
                        if (powers[i] + powers[i + 1] == sum)
                        {
                            powers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (commands[1] == "Left")
                {
                    var sum = int.Parse(commands[2]);

                    while (powers.Count > 0 && powers.First() == sum)
                    {
                        powers.RemoveAt(0);
                    }

                    for (int i = powers.Count - 1; i > 0; i--)
                    {
                        if (powers[i] + powers[i - 1] == sum)
                        {
                            powers.RemoveAt(i);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",powers));
        }
    }
}