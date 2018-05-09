using System;

public class StartUp
{
    public static void Main()
    {
        var list = new CustomList<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split();
            var command = tokens[0];

            switch (command)
            {
                case "Add":
                    list.Add(tokens[1]);
                    break;
                case "Remove":
                    int index = int.Parse(tokens[1]);
                    list.Remove(index);
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(tokens[1]));
                    break;
                case "Swap":
                    var firstIndex = int.Parse(tokens[1]);
                    var secondIndex = int.Parse(tokens[2]);
                    list.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(tokens[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    break;
                case "Sort":
                    list.Sort();
                    break;
            }
        }
    }
}