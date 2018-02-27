using System;

public class FerrariExercise
{
    static void Main()
    {
        var driverName = Console.ReadLine();

        var ferrari = new Ferrari(driverName);

        Console.WriteLine(ferrari);
    }
}