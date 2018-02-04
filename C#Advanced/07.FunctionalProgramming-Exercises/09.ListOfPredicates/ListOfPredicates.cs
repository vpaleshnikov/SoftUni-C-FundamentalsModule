using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < input.Length; i++)
            {
                list = list.Where(a => a % input[i] == 0).ToList();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}