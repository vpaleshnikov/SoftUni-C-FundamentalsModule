using System;

public class StartUp
{
    public static void Main()
    {
        var type = Console.ReadLine();
        var drawingTool = new DrawingTool();

        if (type == "Square")
        {
            var size = int.Parse(Console.ReadLine());
            var square = new Square(size);
            drawingTool.DrawSquare(square);

        }
        else
        {
            var rectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            drawingTool.DrawRectangle(rectangle);
        }
    }
}