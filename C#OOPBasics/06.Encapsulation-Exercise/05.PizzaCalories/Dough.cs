using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    private const double minWeight = 1.0;
    private const double maxWeight = 200.0;

    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            if (value.ToLower() != "white"
                && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (value.ToLower() != "crispy"
                && value.ToLower() != "chewy"
                && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < minWeight || value > maxWeight)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    private double GetType()
    {
        if (flourType.ToLower() == "white")
        {
            return 1.5;
        }

        return 1.0;
    }

    private double GetTechnique()
    {
        if (bakingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }
        else if (bakingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }

        return 1.0;
    }

    public double GetCalories()
    {
        return (2 * this.weight) * this.GetType() * this.GetTechnique();
    }
}