using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    input = input.Select(n => n + 1).ToList();
                }
                else if (command == "multiply")
                {
                    input = input.Select(n => n * 2).ToList();
                }
                else if (command == "subtract")
                {
                    input = input.Select(n => n - 1).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",input));
                }

                command = Console.ReadLine();   
            }
        }
    }
}