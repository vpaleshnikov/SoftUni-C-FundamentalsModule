using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier
{
    public List<Mission> Missions { get; set; }

    public Commando(int id, string firstName, string lastName, decimal salary, string corp)
        : base(id, firstName, lastName, salary, corp)
    {
        this.Missions = new List<Mission>();
    }

    public void CompleteMission()
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(
            $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
        sb.AppendLine($"Corps: {this.Corp}");
        sb.AppendLine($"Missions:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
        return sb.ToString().Trim();
    }
}