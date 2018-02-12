using System;
using System.Linq;

namespace _02.CubicsRube
{
    class CubicsRube
    {
        static void Main(string[] args)
        {
            var dimensionSize = int.Parse(Console.ReadLine());
            var sum = 0L;
            var counter = 0;

            string input;
            while ((input = Console.ReadLine()) != "Analyze")
            {
                var tokens = input.Split(' ').Select(int.Parse).ToArray();

                if (tokens.Take(3).Any(p => p < 0 || p >= dimensionSize))
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sum += tokens[3];
                    counter++;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(Math.Pow(dimensionSize, 3) - counter);
        }
    }
}
