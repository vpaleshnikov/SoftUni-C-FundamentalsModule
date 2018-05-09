using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var customStack = new CustomStack<int>();

        string input;
        while ((input = Console.ReadLine()) != "END") 
        {
            var tokens = input
                .Split(new[] { ", ", " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var currentCommand = tokens[0];

            switch (currentCommand)
            {
                case "Push":
                    customStack.Push(tokens.Skip(1).Select(int.Parse).ToArray());
                    break;
                case "Pop":
                    customStack.Pop();
                    break;
            }
        }
        Console.WriteLine(customStack);
    }
}