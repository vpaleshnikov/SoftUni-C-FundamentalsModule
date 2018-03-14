using System.Text;

public abstract class Car
{
    protected Car(int id,string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.Id = id;
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePower = horsePower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.OverallPerformance = 0;
    }

    public int Id { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int YearOfProduction { get; set; }

    public int HorsePower { get; set; }

    public int Acceleration { get; set; }

    public int Suspension { get; set; }

    public int Durability { get; set; }

    public int OverallPerformance { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}")
            .AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s")
            .AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return sb.ToString().Trim();
    }
}