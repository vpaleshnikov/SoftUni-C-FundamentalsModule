using System;

public class Box
{
    private double lenght;
    private double width;
    private double height;

    public double Lenght
    {
        get { return this.lenght;}
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Lenght cannot be zero or negative.");
            }
            this.lenght = value;
        }
    }

    public double Width
    {
        get { return this.width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get { return this.height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double GetSurfaceArea()
    {
        return (2 * this.lenght * this.width) + (2 * this.lenght * this.height) + (2 * this.width * this.height);
    }

    public double LateralSurfaceArea()
    {
        return (2 * this.lenght * this.height) + (2 * this.width * this.height);
    }

    public double GetVolume()
    {
        return this.lenght * this.width * this.height;
    }
}