using System;

public class Stats
{
    private double endurance;
    private double sprint;
    private double drible;
    private double passing;
    private double shooting;

    private const double minStats = 0.0;
    private const double maxStats = 100.0;

    public double Endurance
    {
        get { return endurance; }
        set
        {
            if (value < minStats || value > maxStats)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            endurance = value;
        }
    }

    public double Sprint
    {
        get { return sprint; }
        set
        {
            if (value < minStats || value > maxStats)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            sprint = value;
        }
    }

    public double Drible
    {
        get { return drible; }
        set
        {
            if (value < minStats || value > maxStats)
            {
                throw new ArgumentException("Drible should be between 0 and 100.");
            }
            drible = value;
        }
    }

    public double Passing
    {
        get { return passing; }
        set
        {
            if (value < minStats || value > maxStats)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            passing = value;
        }
    }

    public double Shooting
    {
        get { return shooting; }
        set
        {
            if (value < minStats || value > maxStats)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            shooting = value;
        }
    }

    public Stats(double endurance, double sprint, double drible, double passing, double shooting)
    {
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Drible = drible;
        this.Passing = passing;
        this.Shooting = shooting;
    }
}