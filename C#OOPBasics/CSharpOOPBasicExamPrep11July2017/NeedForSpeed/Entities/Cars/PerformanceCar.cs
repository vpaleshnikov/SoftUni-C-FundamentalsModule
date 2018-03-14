using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    public PerformanceCar(int id, string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        : base(id, brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.HorsePower += (this.HorsePower * 50) / 100;
        this.Suspension -= (this.Suspension * 25) / 100;
        this.AddOns = new List<string>();
    }

    public List<string> AddOns { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        if (this.AddOns.Count > 0)
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", this.AddOns)}");
        }
        else
        {
            sb.AppendLine($"Add-ons: None");
        }

        return sb.ToString().Trim();
    }

}