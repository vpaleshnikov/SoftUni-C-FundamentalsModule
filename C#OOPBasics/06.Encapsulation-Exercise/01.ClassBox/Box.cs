public class Box
{
    public double Lenght { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double GetSurfaceArea()
    {
        return (2 * this.Lenght * this.Width) + (2 * this.Lenght * this.Height) + (2 * this.Width * this.Height);
    }

    public double LateralSurfaceArea()
    {
        return (2 * this.Lenght * this.Height) + (2 * this.Width * this.Height);
    }

    public double GetVolume()
    {
        return this.Lenght * this.Width * this.Height;
    }
}