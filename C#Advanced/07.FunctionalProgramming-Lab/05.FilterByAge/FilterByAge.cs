using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = age;
                }
                dict[name] = age;
                
            }

            var condition = Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());
            var format = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (condition == "older")
            {
                var older = dict.Where(d => d.Value >= ageFilter).ToDictionary(k => k.Key, v => v.Value);

                Print(format, older);
            }
            else
            {
                var younger = dict.Where(d => d.Value < ageFilter).ToDictionary(k => k.Key, v => v.Value);

                Print(format, younger);
            }
        }

        private static void Print(List<string> format, Dictionary<string, int> dict)
        {
            if (format.Count > 1)
            {
                foreach (var person in dict)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
            else
            {
                if (format[0] == "name")
                {
                    foreach (var person in dict)
                    {

                        Console.WriteLine($"{person.Key}");
                    }
                }
                else
                {
                    foreach (var person in dict)
                    {
                        Console.WriteLine($"{person.Value}");
                    }
                }
            }
        }
    }
}