using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GreedyTimes
{
    class GreedyTimes
    {
        static void Main(string[] args)
        {
            long capacity = long.Parse(Console.ReadLine());

            var goldDict = new Dictionary<string, Dictionary<string, long>>();
            var gemDict = new Dictionary<string, Dictionary<string, long>>();
            var cashDict = new Dictionary<string, Dictionary<string, long>>();

            long goldAmount = 0;
            long gemAmount = 0;
            long cashAmount = 0;

            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (long i = 0; i < input.Length; i += 2)
            {
                var type = input[i];
                var amount = long.Parse(input[i + 1]);

                if (!(capacity >= goldAmount + gemAmount + cashAmount + amount))
                {
                    continue;
                }

                if (type.ToLower() == "gold")
                {
                    if (!goldDict.ContainsKey("Gold"))
                    {
                        goldDict.Add("Gold", new Dictionary<string, long>());

                        if (!goldDict["Gold"].ContainsKey(type))
                        {
                            goldDict["Gold"].Add(type, amount);
                            goldAmount += amount;
                        }
                        else
                        {
                            goldDict["Gold"][type] += amount;
                            goldAmount += amount;
                        }
                    }
                    else
                    {
                        if (!goldDict["Gold"].ContainsKey(type))
                        {
                            goldDict["Gold"].Add(type, amount);
                            goldAmount += amount;
                        }
                        else
                        {
                            goldDict["Gold"][type] += amount;
                            goldAmount += amount;
                        }
                    }
                }

                else if (type.ToLower().EndsWith("gem") && type.Length >= 4)
                {
                    if (gemAmount + amount > goldAmount)
                    {
                        continue;
                    }
                    else
                    {
                        if (!gemDict.ContainsKey("Gem"))
                        {
                            gemDict.Add("Gem", new Dictionary<string, long>());

                            if (!gemDict["Gem"].ContainsKey(type))
                            {
                                gemDict["Gem"].Add(type, amount);
                                gemAmount += amount;
                            }
                            else
                            {
                                gemDict["Gem"][type] += amount;
                                gemAmount += amount;
                            }
                        }
                        else
                        {
                            if (!gemDict["Gem"].ContainsKey(type))
                            {
                                gemDict["Gem"].Add(type, amount);
                                gemAmount += amount;
                            }
                            else
                            {
                                gemDict["Gem"][type] += amount;
                                gemAmount += amount;
                            }
                        }
                    }
                }

                else if (type.Length == 3)
                {
                    if (cashAmount + amount > gemAmount)
                    {
                        continue;
                    }

                    if (!cashDict.ContainsKey("Cash"))
                    {
                        cashDict.Add("Cash", new Dictionary<string, long>());

                        if (!cashDict["Cash"].ContainsKey(type))
                        {
                            cashDict["Cash"].Add(type, amount);
                            cashAmount += amount;
                        }
                        else
                        {
                            cashDict["Cash"][type] += amount;
                            cashAmount += amount;
                        }
                    }
                    else
                    {
                        if (!cashDict["Cash"].ContainsKey(type))
                        {
                            cashDict["Cash"].Add(type, amount);
                            cashAmount += amount;
                        }
                        else
                        {
                            cashDict["Cash"][type] += amount;
                            cashAmount += amount;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            long totalAmmount = 0;

            long allGoldValue = 0;
            long allGemValue = 0;
            long allCashValue = 0;

            if (goldDict.Count > 0)
            {
                foreach (var gold in goldDict)
                {
                    allGoldValue = gold.Value.Values.Sum();

                    Console.WriteLine($"<{gold.Key}> ${allGoldValue}");
                    foreach (var item in gold.Value)
                    {
                        totalAmmount += item.Value;
                        Console.WriteLine($"##{item.Key} - {item.Value}");
                    }
                }
            }

            if (gemDict.Count > 0)
            {
                foreach (var gem in gemDict)
                {
                    allGemValue += gem.Value.Values.Sum();

                    Console.WriteLine($"<{gem.Key}> ${allGemValue}");
                    foreach (var item in gem.Value.OrderByDescending(a => a.Key))
                    {
                        totalAmmount += item.Value;

                        if (totalAmmount > capacity)
                        {
                            return;
                        }

                        Console.WriteLine($"##{item.Key} - {item.Value}");
                    }

                }
            }

            if (cashDict.Count > 0)
            {
                foreach (var cash in cashDict)
                {
                    allCashValue += cash.Value.Values.Sum();

                    Console.WriteLine($"<{cash.Key}> ${allCashValue}");

                    foreach (var item in cash.Value.OrderByDescending(a => a.Key))
                    {
                        totalAmmount += item.Value;

                        if (totalAmmount > capacity)
                        {
                            return;
                        }

                        Console.WriteLine($"##{item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}