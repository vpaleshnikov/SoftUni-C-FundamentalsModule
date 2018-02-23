using System;

public class Topping
{
    private string type;
    private double weight;

    private const double minWeight = 1.0;
    private const double maxWeight = 50.0;

    public string Type
    {
        get { return this.type; }
        set
        {
            if (value.ToLower() != "meat"
                && value.ToLower() != "veggies"
                && value.ToLower() != "cheese"
                && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < minWeight || value > maxWeight)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [{minWeight}..{maxWeight}].");
            }

            this.weight = value;
        }
    }

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    private double GetType()
    {
        if (type.ToLower() == "meat")
        {
            return 1.2;
        }
        else if (type.ToLower() == "veggies")
        {
            return 0.8;
        }
        else if (type.ToLower() == "cheese")
        {
            return 1.1;
        }

        return 0.9;
    }

    public double GetCalories()
    {
        return (2 * this.Weight) * this.GetType();
    }
}