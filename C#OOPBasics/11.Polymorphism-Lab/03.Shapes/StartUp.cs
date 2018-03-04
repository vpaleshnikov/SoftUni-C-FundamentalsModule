using System;

public class StartUp
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Shape circle = new Circle(double.Parse(Console.ReadLine()));

        Console.WriteLine($"{rectangle.CalculateArea():F2}");
        Console.WriteLine($"{rectangle.CalculatePerimeter():F2}");
        Console.WriteLine(rectangle.Draw());
        Console.WriteLine($"{circle.CalculateArea():F2}");
        Console.WriteLine($"{circle.CalculatePerimeter():F2}");
        Console.WriteLine(circle.Draw());
    }
}