using System;
using System.Collections.Generic;
using System.Text;

public class Engineer:SpecialisedSoldier
{
    public List<Repair> Repairs { get; set; }

    public Engineer(int id, string firstName, string lastName, decimal salary, string corp)
        : base(id, firstName, lastName, salary, corp)
    {
        this.Repairs = new List<Repair>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(
            $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
        sb.AppendLine($"Corps: {this.Corp}");
        sb.AppendLine($"Repairs:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");
        return sb.ToString().Trim();
    }
}