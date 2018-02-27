public class Ferrari : ICar
{
    public string Model { get; private set; }
    public string DriverName { get; private set; }

    public string Brake() { return "Brakes!"; }

    public string Gas() { return "Zadu6avam sA!"; }

    public Ferrari(string driverName)
    {
        this.Model = "488-Spider";
        this.DriverName = driverName;
    }

    public override string ToString()
    {
        return $"{this.Model}/{Brake()}/{Gas()}/{this.DriverName}";
    }
}