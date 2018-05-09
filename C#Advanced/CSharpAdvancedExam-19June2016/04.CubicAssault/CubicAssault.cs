﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CubicAssault
{
    class CubicAssault
    {
        public static int ConvertThreshold = 1_000_000;

        static void Main(string[] args)
        {
            var meteorNames = new List<string>()
            {
                "Green", "Red", "Black"
            };

            var regions = new Dictionary<string, Dictionary<string, long>>();

            string input;
            while ((input = Console.ReadLine()) != "Count em all")
            {
                var regionTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var regionName = regionTokens[0];
                var meteorType = regionTokens[1];
                var meteorCount = long.Parse(regionTokens[2]);

                if (!regions.ContainsKey(regionName))
                {
                    regions[regionName] = new Dictionary<string, long>() {
                        {
                            "Green", 0
                        },
                        {
                            "Red", 0
                        },
                        {
                            "Black", 0
                        }
                    };
                }
                regions[regionName][meteorType] += meteorCount;

                for (int i = 0; i < meteorNames.Count - 1; i++)
                {
                    var nextTypeCount = regions[regionName][meteorNames[i]] / ConvertThreshold;

                    if (nextTypeCount > 0)
                    {
                        regions[regionName][meteorNames[i + 1]] += nextTypeCount;
                        regions[regionName][meteorNames[i]] %= ConvertThreshold;
                    }
                }
            }

            var orderedRegions = regions
                .OrderByDescending(r => r.Value["Black"])
                .ThenBy(r => r.Key.Length)
                .ThenBy(r => r.Key)
                .ToDictionary(r => r.Key, r => r.Value);

            foreach (var region in orderedRegions)
            {
                Console.WriteLine(region.Key);
                foreach (var meteorType in region.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"-> {meteorType.Key} : {meteorType.Value}");
                }
            }
        }
    }
}