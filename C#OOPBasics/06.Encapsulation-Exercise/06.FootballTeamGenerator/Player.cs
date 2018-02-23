using System;

public class Player
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    private Stats stats;

    public Stats Stats
    {
        get { return stats; }
        set { stats = value; }
    }
    
    public Player(string name, Stats stats)
    {
        this.Name = name;
        this.Stats = stats;
    }

    public double AverageStats()
    {
        return (stats.Drible + stats.Endurance + stats.Passing + stats.Shooting + stats.Sprint) / 5;
    }
}