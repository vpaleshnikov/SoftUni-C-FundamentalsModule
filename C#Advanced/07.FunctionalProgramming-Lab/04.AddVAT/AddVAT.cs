using System;
using System.Linq;

namespace _04.AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n + (n * 0.2))
                .ToList();

            foreach (var number in input)
            {
                Console.WriteLine($"{number:F2}");
            }

        }
    }
}