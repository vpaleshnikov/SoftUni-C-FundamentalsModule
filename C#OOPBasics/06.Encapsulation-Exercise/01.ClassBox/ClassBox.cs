using System;

public class ClassBox
{
    public static void Main()
    {
        var lenght = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var box = new Box(lenght, width, height);

        Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {box.GetVolume():F2}");
    }
}