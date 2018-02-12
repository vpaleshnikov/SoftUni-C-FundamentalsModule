using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HitList
{
    class HitList
    {
        static void Main(string[] args)
        {
            var targetInfoIndex = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, string>>();

            string input;
            while ((input = Console.ReadLine()) != "end transmissions")
            {
                var inputTokens = input.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = inputTokens[0];
                var nameData = inputTokens[1].Split(new[] { ";" },StringSplitOptions.RemoveEmptyEntries).ToList();

                if (nameData.Count > 1)
                {
                    for (int i = 0; i < nameData.Count; i++)
                    {
                        var data = nameData[i].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                        if (!dict.ContainsKey(name))
                        {
                            dict.Add(name, new Dictionary<string, string>());

                            if (!dict[name].ContainsKey(data[0]))
                            {
                                dict[name].Add(data[0], data[1]);
                            }
                            else
                            {
                                dict[name][data[0]] = data[1];
                            }
                        }
                        else
                        {
                            if (!dict[name].ContainsKey(data[0]))
                            {
                                dict[name].Add(data[0], data[1]);
                            }
                            else
                            {
                                dict[name][data[0]] = data[1];
                            }
                        }
                    }                    
                }
                else if (nameData.Count == 1)
                {
                    var data = nameData[0].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<string, string>());

                        if (!dict[name].ContainsKey(data[0]))
                        {
                            dict[name].Add(data[0], data[1]);
                        }
                        else
                        {
                            dict[name][data[0]] = data[1];
                        }
                    }
                    else
                    {
                        if (!dict[name].ContainsKey(data[0]))
                        {
                            dict[name].Add(data[0], data[1]);
                        }
                        else
                        {
                            dict[name][data[0]] = data[1];
                        }
                    }
                }
            }

            var command = Console.ReadLine().Split(new[] { " "},StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            foreach (var data in dict)
            {
                if (data.Key == command[1])
                {
                    Console.WriteLine($"Info on {data.Key}:");
                    foreach (var datas in data.Value.OrderBy(a => a.Key))
                    {
                        sum += datas.Key.Length + datas.Value.Length;
                        Console.WriteLine($"---{datas.Key}: {datas.Value}");
                    }
                }
            }
            if (sum >= targetInfoIndex)
            {
                Console.WriteLine($"Info index: {sum}");
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Info index: {sum}");
                Console.WriteLine($"Need {Math.Abs(targetInfoIndex - sum)} more info.");
            }
        }
    }
}
