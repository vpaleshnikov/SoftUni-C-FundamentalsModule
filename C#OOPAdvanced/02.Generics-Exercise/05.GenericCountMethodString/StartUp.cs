using System;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var collection = new Box<string>();

        for (int i = 0; i < n; i++)
        {
            collection.Add(Console.ReadLine());
        }

        var element = Console.ReadLine();

        Console.WriteLine(collection.GetGreatersCount(element));
    }
}