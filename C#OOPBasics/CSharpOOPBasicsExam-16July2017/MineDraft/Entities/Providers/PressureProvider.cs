public class PressureProvider : Provider
{
    public PressureProvider(double energyOutput) 
        : base(energyOutput)
    {
        this.EnergyOutput = energyOutput + (energyOutput * 0.5);
    }
}