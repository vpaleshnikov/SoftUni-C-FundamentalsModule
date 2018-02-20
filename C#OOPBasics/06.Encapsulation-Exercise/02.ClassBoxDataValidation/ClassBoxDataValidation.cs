using System;

public class ClassBoxDataValidation
{
    public static void Main()
    {
        try
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(lenght, width, height);

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.GetVolume():F2}");
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
        }
    }
}