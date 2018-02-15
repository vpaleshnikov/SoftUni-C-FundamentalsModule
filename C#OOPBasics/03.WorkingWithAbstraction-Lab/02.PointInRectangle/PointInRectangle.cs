using System;
using System.Linq;

public class PointInRectangle
{
    public static void Main()
    {
        var rectangleCoordinates = Console.ReadLine()
            .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var topX = rectangleCoordinates[0];
        var topY = rectangleCoordinates[1];
        var bottomX = rectangleCoordinates[2];
        var botoomY = rectangleCoordinates[3];


        var rectangle = new Rectangle(topX, topY, bottomX, botoomY);

        var pointsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < pointsCount; i++)
        {
            var pointCoordinates = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var x = pointCoordinates[0];
            var y = pointCoordinates[1];

            var point = new Point(x, y);

            Console.WriteLine(IsPointInsideTheReactangle(rectangle, point));
        }
    }

    public static bool IsPointInsideTheReactangle(Rectangle rectangle, Point point)
    {
        return point.X >= rectangle.TopLeftX && point.X <= rectangle.BottomRightX 
            && point.Y >= rectangle.TopLeftY && point.Y <= rectangle.BottomRightY;
    }
}