using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private List<Player> players;
    private int rating;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public int Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    public Team(string name)
    {
        this.Name = name;
        this.Players = new List<Player>();
        this.Rating = rating;
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        this.Players.Remove(player);
    }

    public int AverageRating()
    {
        return (int)(Math.Round(this.Players.Sum(x => x.AverageStats() / this.Players.Count)));
    }
}