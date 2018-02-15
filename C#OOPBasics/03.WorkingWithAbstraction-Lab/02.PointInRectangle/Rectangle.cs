public class Rectangle
{
    public int TopLeftX { get; set; }

    public int TopLeftY { get; set; }

    public int BottomRightX { get; set; }

    public int BottomRightY { get; set; }

    public Point Point { get; set; }

    public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
    {
        this.TopLeftX = topLeftX;
        this.TopLeftY = topLeftY;
        this.BottomRightX = bottomRightX;
        this.BottomRightY = bottomRightY;
    }
}