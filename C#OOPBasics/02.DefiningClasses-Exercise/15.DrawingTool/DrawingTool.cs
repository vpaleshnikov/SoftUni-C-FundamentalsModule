using System;

public class DrawingTool
{
    public Square Square { get; set; }

    public Rectangle Rectangle { get; set; }

    public void DrawSquare(Square square)
    {
        var size = square.X;
        Console.WriteLine($"|{new string('-', size)}|");
        for (int i = 0; i < size - 2; i++)
        {
            Console.WriteLine($"|{new string(' ', size)}|");
        }
        Console.WriteLine($"|{new string('-', size)}|");
    }

    public void DrawRectangle(Rectangle rectangle)
    {
        var width = rectangle.X;
        var height = rectangle.Y;

        Console.WriteLine($"|{new string('-', width)}|");
        for (int i = 0; i < height - 2; i++)
        {
            Console.WriteLine($"|{new string(' ', width)}|");
        }
        Console.WriteLine($"|{new string('-', width)}|");
    }
}