public class Engine
{
    public double EngineSpeed { get; set; }

    public double EnginePower { get; set; }

    public Engine(double engineSpeed, double enginePower)
    {
        this.EngineSpeed = engineSpeed;
        this.EnginePower = enginePower;
    }
}