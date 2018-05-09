using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int baterry)
    {
        this.Model = model;
        this.Color = color;
        this.Baterry = baterry;
    }

    public string Model { get; }

    public string Color { get; }

    public int Baterry { get; }
    
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Baterry} Batteries");
        sb.AppendLine(Start());
        sb.AppendLine(Stop());

        return sb.ToString().Trim();
    }
}