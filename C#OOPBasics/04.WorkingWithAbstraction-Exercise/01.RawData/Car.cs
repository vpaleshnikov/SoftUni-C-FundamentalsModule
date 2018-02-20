using System.Collections.Generic;

public class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public List<Tyre> Tyres { get; set; }

    public Car(string model)
    {
        this.Model = model;

        this.Tyres = new List<Tyre>();
    }
}