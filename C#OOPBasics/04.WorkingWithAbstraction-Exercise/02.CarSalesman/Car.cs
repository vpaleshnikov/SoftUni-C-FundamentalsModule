public class Car
{
    public string Model { get; set; }

    public string Engine { get; set; }

    public string Weight { get; set; }

    public string Color { get; set; }
    
    public Car(string model, string engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = "n/a";
        this.Color = "n/a";
    }

    public Car(string model, string engine, string weight, string color) : this(model, engine)
    {
        this.Weight = weight;
        this.Color = color;
    }
}