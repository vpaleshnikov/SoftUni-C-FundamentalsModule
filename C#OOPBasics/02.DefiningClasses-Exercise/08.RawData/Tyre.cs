public class Tyre
{
    public double TyrePressure { get; set; }

    public double TyreAge { get; set; }

    public Tyre(double pressure, double age)
    {
        this.TyrePressure = pressure;
        this.TyreAge = age;
    }
}