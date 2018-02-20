public class Engine
{
    public int EngineSpeed { get; set; }

    public int Power { get; set; }

    public Engine(int engineSpeed, int power)
    {
        this.EngineSpeed = engineSpeed;
        this.Power = power;
    }
}