public class Tyre
{
    public double Pressure { get; set; }

    public int Age { get; set; }

    public Tyre(double pressure, int age)
    {
        this.Pressure = pressure;
        this.Age = age;
    }
}