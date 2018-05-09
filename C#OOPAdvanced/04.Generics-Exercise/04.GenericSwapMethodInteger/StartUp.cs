using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var collection = new Box<int>();

        for (int i = 0; i < n; i++)
        {
            collection.Add(int.Parse(Console.ReadLine()));
        }

        var swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var firstIndex = swapCommand[0];
        var lastIndex = swapCommand[1];

        collection.Swap(firstIndex, lastIndex);

        Console.WriteLine(collection);
    }
}