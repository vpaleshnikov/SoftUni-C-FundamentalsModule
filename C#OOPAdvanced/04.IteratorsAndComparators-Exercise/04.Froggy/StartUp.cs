using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inputStones = Console.ReadLine()
            .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var lake = new Lake<int>(inputStones);

        Console.WriteLine(lake);
    }
}