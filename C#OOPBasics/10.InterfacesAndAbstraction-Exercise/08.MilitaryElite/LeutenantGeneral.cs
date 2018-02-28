using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private
{
    public List<Private> Privates { get; set; }

    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<Private>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
        sb.AppendLine($"Privates:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");
        return sb.ToString().Trim();
    }
}