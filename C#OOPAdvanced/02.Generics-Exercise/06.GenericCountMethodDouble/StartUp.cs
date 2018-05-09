using System;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var collection = new Box<double>();

        for (int i = 0; i < n; i++)
        {
            collection.Add(double.Parse(Console.ReadLine()));
        }

        var element = double.Parse(Console.ReadLine());

        Console.WriteLine(collection.GetGreatersCount(element));
    }
}