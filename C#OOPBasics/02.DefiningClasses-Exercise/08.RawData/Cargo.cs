public class Cargo
{
    public double CargoWeight { get; set; }

    public string CargoType { get; set; }

    public Cargo(double cargoWeight, string cargoType)
    {
        this.CargoWeight = cargoWeight;
        this.CargoType = cargoType;
    }
}