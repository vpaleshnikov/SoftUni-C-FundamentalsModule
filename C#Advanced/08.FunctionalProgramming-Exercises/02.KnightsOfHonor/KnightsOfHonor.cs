using System;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}