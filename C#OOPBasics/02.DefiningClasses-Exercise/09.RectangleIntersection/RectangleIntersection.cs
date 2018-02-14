using System;
using System.Collections.Generic;
using System.Linq;

public class RectangleIntersection
{
    public static void Main(string[] args)
    {
        var rectanglesAndChecks = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        var numberOfRectangles = int.Parse(rectanglesAndChecks[0]);
        var intersectionChecks = int.Parse(rectanglesAndChecks[1]);

        var rectangles = new List<Rectangle>();

        for (int i = 0; i < numberOfRectangles; i++)
        {
            var rectangleInfo = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var rectangle = new Rectangle(
                rectangleInfo[0], 
                double.Parse(rectangleInfo[1]),
                double.Parse(rectangleInfo[2]),
                double.Parse(rectangleInfo[3]),
                double.Parse(rectangleInfo[4]));

            rectangles.Add(rectangle);
        }

        for (int i = 0; i < intersectionChecks; i++)
        {
            var pairsOfIds = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var firstRectangle = rectangles.Where(a => a.Id == pairsOfIds[0]).First();
            var secondRectangle = rectangles.Where(a => a.Id == pairsOfIds[1]).First();
            
            Console.WriteLine(firstRectangle.Intersects(secondRectangle));
        }
    }
}